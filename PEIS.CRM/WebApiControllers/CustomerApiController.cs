using Infrastructure.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PEIS.CRM.WebApiControllers
{
    [RoutePrefix("api/customers")]
    public class CustomerApiController : ApiController
    {
        ICustomerLogic _customerLogic;
        public CustomerApiController(ICustomerLogic logic)
        {
            _customerLogic = logic;
        }

        [HttpGet]
        [Route("customerName/{customerName}")]
        public IHttpActionResult GetCustomerDetailByName(string customerName)
        {
            try
            {
                var result = _customerLogic.GetLatestCustomerByName(customerName);
                if (result == null) return NotFound();
                else return Ok(result);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpGet]
        [Route("IdCard/{IdCardNumber}")]
        public IHttpActionResult GetCustomerDetailByIdCard(string IdCardNumber)
        {
            try
            {
                var result = _customerLogic.GetLatestCustomerByIdCard(IdCardNumber);
                if (result == null) return NotFound();
                else return Ok(result);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        [Route("customerId/{customerId}")]
        public IHttpActionResult GetCustomerDetailByCustomerId(int customerId)
        {
            try
            {
                var result = _customerLogic.GetLatestCustomerByCustomerId(customerId);
                if (result == null) return NotFound();
                else return Ok(result);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }


    }
}

