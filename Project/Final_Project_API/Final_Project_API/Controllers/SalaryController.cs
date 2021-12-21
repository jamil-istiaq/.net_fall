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
    public class SalaryController : ApiController
    {
        [Route("api/salary/all")]
        [HttpGet]
        public List<SalaryModel> Get()
        {
            return SalaryService.Get();
        }

        [Route("api/salary/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, SalaryService.Get(id));
        }

        [Route("api/salary/create")]
        [HttpPost]
        public HttpResponseMessage Create(SalaryModel em)
        {
            SalaryService.Create(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/salary/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(SalaryModel em)
        {
            SalaryService.Edit(em);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/salary/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            SalaryService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
