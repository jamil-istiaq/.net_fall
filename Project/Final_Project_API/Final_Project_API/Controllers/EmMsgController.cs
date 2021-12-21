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
    public class EmMsgController : ApiController
    {
        [Route("api/em/all")]
        [HttpGet]
        public List<EmMsgModel> Get()
        {
            return EmMsgService.Get();
        }

        [Route("api/em/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmMsgService.Get(id));
        }

        [Route("api/em/create")]
        [HttpPost]
        public HttpResponseMessage Create(EmMsgModel em)
        {
            EmMsgService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/em/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(EmMsgModel em)
        {
            EmMsgService.Edit(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/em/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            EmMsgService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
