using Infrastructure.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PEIS.CRM.WebApiControllers
{
    [RoutePrefix("api/exams")]
    public class ExamHistoryApiController : ApiController
    {
        IExamLogic _examLogic;
        IFeeLogic _feeLogic;

        public ExamHistoryApiController(IExamLogic examLogic, IFeeLogic feeLogic)
        {
            this._examLogic = examLogic;
            this._feeLogic = feeLogic;
        }

        [Route("examHistory/idCard/{idCard}")]
        public IHttpActionResult GetExamLogicByIDCard(string idCard)
        {
            var allHistory = _examLogic.GetAllPhysicalExamByIdCard(idCard);
            return Json(allHistory);
        }

        [Route("feeHistory/customerId/{customerId}")]
        public IHttpActionResult GetHistoryFeeForCustomerId(int customerId)
        {
            var allFees = _feeLogic.GetFeeDetailForCustomerId(customerId);
            return Json(allFees);
        }

        [Route("reports/customerId/{customerId}")]
        public IHttpActionResult GetReportsByCustomerId(int customerId)
        {
            var allReports = _examLogic.GetAllReportsByCustId(customerId);
            return Json(allReports);
        }

    }
}
