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
        ICustRelationLogic _relationLogic;
        
    }
}
