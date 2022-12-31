using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;

namespace FinalProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        public static LoginBL bl = new LoginBL();
        
        // POST: api/Login
        public User Post(User login)
        {
            User isUser = bl.CheckLogin(login);
            return isUser;
        }

        public User Put(int id)
        {
            return bl.EditUser(id);
        }
    }
}
