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
    public class FairChartController : ApiController
    {
        [Route("api/chart/all")]
        [HttpGet]
        public List<FairChartModel> Get()
        {
            return ChartService.Get();
        }

        [Route("api/chart/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, ChartService.Get(id));
        }

        [Route("api/chart/create")]
        [HttpPost]
        public HttpResponseMessage Create(FairChartModel em)
        {
            ChartService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/chart/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(FairChartModel em)
        {
            ChartService.Edit(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/chart/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            ChartService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
