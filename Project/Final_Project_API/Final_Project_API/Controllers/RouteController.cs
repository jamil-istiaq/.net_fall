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
    public class RouteController : ApiController
    {
        [Route("api/route/all")]
        [HttpGet]
        public List<RouteModel> Get()
        {
            return RouteService.Get();
        }

        [Route("api/route/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, RouteService.Get(id));
        }

        [Route("api/route/create")]
        [HttpPost]
        public HttpResponseMessage Create(RouteModel em)
        {
            RouteService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/route/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(RouteModel em)
        {
            RouteService.Edit(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/route/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            RouteService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
