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
    public class UserController : ApiController
    {
        [CustomAuth]
        [Route("api/users")]
        [HttpGet]
        public List<UserInfoModel>Get()
        {
            return UserInfoService.Get();
        }
        [CustomAuth]
        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserInfoService.Get(id));
        }

        [Route("api/user/signup")]
        [HttpPost]
        public HttpResponseMessage Create(UserInfoModel user)
        {
            UserInfoService.Create(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/user/update")]
        [HttpPost]
        public HttpResponseMessage Edit(UserInfoModel user)
        {
            UserInfoService.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
    
}
