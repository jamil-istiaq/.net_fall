using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BussEnLayer;
using BussLayer;
using System.Web.Http.Cors;
using Final_Project_API.Auth;

namespace Final_Project_API.Controllers
{
    
    [EnableCors("*","*","*")]
    public class AuthController : ApiController
    {
        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthService.Logout(token);
                if (rs)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Sucess fully logged out");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid token to logout");
        }

        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(UserInfoModel user)
        {
            
            var token = AuthService.Authenticate(user);
            if (token != null)
            {

                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }
    }
}
    

