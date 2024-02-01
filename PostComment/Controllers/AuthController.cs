using BLL.Services;
using PostComment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace PostComment.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel login)
        {
            try
            {
                var res = AuthService.Authenticate( login.Uname, login.Password );
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                    
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound , new { Message = "User Not Found"});


            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message= ex.Message});
            }
        }
    }
}
