using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BussEnLayer;
using BussLayer;
using Final_Project_API.Auth;

namespace Final_Project_API.Controllers
{
    
    [EnableCors("*", "*", "*")]
    public class PayInfoController : ApiController
    {
        [Route("api/payment/all")]
        [HttpGet]
        public List<PayInfoModel> Get()
        {
            return PayInfoService.Get();
        }

        [Route("api/payment/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, PayInfoService.Get(id));
        }

        [Route("api/payment/info")]
        [HttpPost]
        public HttpResponseMessage Create(PayInfoModel em)
        {
            PayInfoService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
