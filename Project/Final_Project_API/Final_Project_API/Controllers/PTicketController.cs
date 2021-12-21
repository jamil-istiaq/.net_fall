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
    public class PTicketController : ApiController
    {
        [Route("api/ticket/all")]
        [HttpGet]
        public List<PTicketModel> Get()
        {
            return PTicketService.Get();
        }
        
        [Route("api/ticket/purchase")]
        [HttpPost]
        public HttpResponseMessage Create(PTicketModel pt)
        {
            PTicketService.Create(pt);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/ticket/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, PTicketService.Get(id));
        }
    }
}
