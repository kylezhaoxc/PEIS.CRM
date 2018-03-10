using Infrastructure.Logic;
using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PEIS.CRM.WebApiControllers
{
    [RoutePrefix("api/conclusions")]
    public class ConclusionHistoryApiController : ApiController
    {
        IConclusionLogic _conclusionLogic;
        ICustRelationLogic _relationLogic;
        IFeeLogic _feeLogic;

        public ConclusionHistoryApiController(IConclusionLogic conclusionLogic, ICustRelationLogic relationLogic, IFeeLogic feeLogic)
        {
            _conclusionLogic = conclusionLogic;
            _relationLogic = relationLogic;
            _feeLogic = feeLogic;
        }

        [HttpGet]
        [Route("idCardNumber/{idNumber}")]
        public IEnumerable<OnCustConclusion> GetAllConclusionsByArcId(string idNumber)
        {
            return _conclusionLogic.GetConclusionIdsByIdCard(idNumber);
        }

        [HttpGet]
        [Route("id/{id}")]
        public OnCustConclusion GetAllConclusionsByArcId(int id)
        {
            return _conclusionLogic.GetConclusionDetailsById(id);
        }

        [HttpGet]
        [Route("fee/{customerId}")]
        public IEnumerable<OnCustFee> GetFeeForCustomerId(int customerId)
        {
            return _feeLogic.GetFeeDetailForCustomerId(customerId);
        }



    }
}
