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
    public class TrainListController : ApiController
    {
        [Route("api/trainlist/all")]
        [HttpGet]
        public List<TrainListModel> Get()
        {
            return TrainListService.Get();
        }

        [Route("api/trainlist/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, TrainListService.Get(id));
        }

        [Route("api/trainlist/create")]
        [HttpPost]
        public HttpResponseMessage Create(TrainListModel em)
        {
            TrainListService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/trainlist/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(TrainListModel em)
        {
            TrainListService.Edit(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/chart/trainlist/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            TrainListService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
