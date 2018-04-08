using Infrastructure.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PEIS.CRM.WebApiControllers
{
    [RoutePrefix("api/dict")]
    public class DictionaryApiController : ApiController
    {
        IDictLogic _dictLogic;


        public DictionaryApiController(IDictLogic dictLogic)
        {
            _dictLogic = dictLogic;
        }

        [HttpPost]
        [Route("{name}/{key}/{value}")]
        public IHttpActionResult AddKVP(string name, string key, string value)
        {
            try
            {
                _dictLogic.AddDictItem(name, key, value);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpGet]
        [Route("{name}")]
        public IHttpActionResult ListKVPs(string name)
        {
            try
            {
                var res = _dictLogic.ListDictItem(name);
                return Json(res);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
