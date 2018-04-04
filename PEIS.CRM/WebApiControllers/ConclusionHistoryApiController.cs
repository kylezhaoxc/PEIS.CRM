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
        public IEnumerable<OnCustConclusion> GetAllConclusionsByIdCard(string idNumber)
        {
            return _conclusionLogic.GetConclusionsByIdCard(idNumber);
        }

        [HttpGet]
        [Route("custConclusionId/{id}")]
        public OnCustConclusion GetAllConclusionsByArcId(int id)
        {
            return _conclusionLogic.GetConclusionDetailsById(id);
        }

        [HttpGet]
        [Route("customerName/{name}")]
        public IEnumerable<OnCustConclusion> GetAllConclusionsByName(string customerName)
        {
            return _conclusionLogic.GetConclusionsByIdCard(customerName);
        }

        [HttpGet]
        [Route("conclusionId/{id}")]
        public OnCustConclusion GetConclusionById(int conclusionId)
        {
            return _conclusionLogic.GetConclusionDetailsById(conclusionId);
        }


    }
}
