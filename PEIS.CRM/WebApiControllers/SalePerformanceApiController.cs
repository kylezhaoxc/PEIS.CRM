using Infrastructure.Logic;
using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace PEIS.CRM.WebApiControllers
{
    [RoutePrefix("api/sales")]
    public class SalePerformanceApiController : ApiController
    {
        ICustomerLogic _customerLogic;
        IFeeLogic _feeLogic;
        public SalePerformanceApiController(ICustomerLogic customerLogic, IFeeLogic feeLogic)
        {
            _customerLogic = customerLogic;
            _feeLogic = feeLogic;
        }

        [Route("todayStatus")]
        public IHttpActionResult GetStatus()
        {
            var finished = _customerLogic.GetFinishedExam(DateTime.Now.AddYears(-1));
            var unfinished = _customerLogic.GetUnfinishedExam(DateTime.Now.AddYears(-1));

            var finishedArray = finished.Select(p => new
            {
                Name = p.CustomerName,
                Type = p.ExamTypeName,
                Price = _feeLogic.getExamPrice(p)
            }).ToList();
            var unfinishedArray = unfinished.Select(p => new
            {
                Name = p.CustomerName,
                Type = p.ExamTypeName,
                Price = _feeLogic.getExamPrice(p)
            }).ToList();
            var totalCount = finished.Count() + unfinished.Count();
            var totalPrice = finished.Sum(p => _feeLogic.getExamPrice(p)) + unfinished.Sum(p => _feeLogic.getExamPrice(p));

            var result = new
            {
                FinishedList = finishedArray,
                UnfinishedList = unfinishedArray,
                TotalCount = totalCount,
                TotalPrice = totalPrice
            };
            return Json(result);
        }
    }
}
