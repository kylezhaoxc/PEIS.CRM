using Infrastructure.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PEIS.CRM.WebApiControllers
{
    [RoutePrefix("api/custStatistic")]
    public class CustomerStatisticApiController : ApiController
    {
        ICustomerLogic _customerLogic;
        IFeeLogic _feeLogic;
        IExamLogic _examLogic;
        IConclusionLogic _conclusionLogic;

        public CustomerStatisticApiController(ICustomerLogic customerLogic, IFeeLogic feeLogic, IExamLogic examLogic, IConclusionLogic conclusionLogic)
        {
            _customerLogic = customerLogic;
            _feeLogic = feeLogic;
            _examLogic = examLogic;
            _conclusionLogic = conclusionLogic;
        }

        [Route("idCard/{idCard}")]
        public IHttpActionResult GetCustomerStatisticsByIdCard(string idCard)
        {
            var cust = _customerLogic.GetLatestCustomerByIdCard(idCard);
            string name = cust.CustomerName;
            var exams = _examLogic.GetAllPhysicalExamByIdCard(idCard);
            string freq = "";
            var alldates = exams.OrderByDescending(p => p.CheckedDate).Select(p => p.CheckedDate);

            if (alldates.Count() == 1)
            {
                freq = "n/a";
            }
            else
            {
                var timeSpan = alldates.First() - alldates.Last();
                freq = $"{(int)(alldates.Count() / timeSpan.Value.TotalDays) * 365}/year";
            }
            var highFreq = _conclusionLogic.GetConclusionsByIdCard(idCard)
                .Where(p => !string.IsNullOrEmpty(p.ConclusionTypeName))
                .Select(p => p.ConclusionTypeName)
                .GroupBy(p => p)
                .OrderByDescending(g => g.Count())
                .First().Key;
            var result = new
            {
                Name = name,
                ExamFrequency = freq,
                CustomerId = cust.ID_ArcCustomer,
                LastExamTime = alldates.FirstOrDefault(),
                FreqSymptom = highFreq
            };
            return Json(result);
        }

        [Route("lowFreq/{size?}")]
        public IHttpActionResult GetLowFreqCustomers(int size = 20)
        {
            var losing = _customerLogic.GetLowFreqCustomers();
            return Json(losing);
        }

    }
}
