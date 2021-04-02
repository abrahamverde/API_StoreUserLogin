using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_StoreUserLogin.Models;
using Microsoft.AspNetCore.HttpOverrides;

namespace API_StoreUserLogin.Controllers
{
    [Route("api")]
    [ApiController]
    public class UsersLoginsController : ControllerBase
    {
 
        // POST: api/UsersLogins
        [HttpPost]
        [Route("storeUL")]
        public ActionResult<UsersLogin> storeUL(apiRequest objRequest)
        {
            try
            {
                //FILL OBJECT USER
                UsersLogin objUser = new UsersLogin()
                {
                    Username = objRequest.username,
                    Source = objRequest.source,
                    Ipaddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                    LoginDate = DateTime.Now,
                };

                //STORE DATA IN DATABASE USING ENTITY FRAMEWORK
                using (var objContext = new SGAContext())
                {
                    objContext.UsersLogins.Add(objUser);
                    objContext.SaveChanges();
                }

                //RETURN 200 - OK
                return StatusCode(200, objUser);

            }
            catch (Exception Exp)
            {
                //RETURN 500 INTERNAL SERVER ERROR AND EXCEPCION
                return StatusCode(500, Exp.Message);
            }

        }

    }
}
