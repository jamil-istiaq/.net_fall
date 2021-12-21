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
    [CustomAuth]
    [EnableCors("*", "*", "*")]
    public class ScdTrainController : ApiController
    {

        [Route("api/time/all")]
        [HttpGet]
        public List<ScheduleModel> Get()
        {
            return ScdService.Get();
        }

        [Route("api/time/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, ScdService.Get(id));
        }

        [Route("api/time/create")]
        [HttpPost]
        public HttpResponseMessage Create(ScheduleModel em)
        {
            ScdService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/time/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(ScheduleModel em)
        {
            ScdService.Edit(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/time/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            ScdService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
