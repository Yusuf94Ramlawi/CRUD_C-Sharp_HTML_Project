using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProject.Models
{
    public class LoginBL
    {
        masterEntities masterEntities = new masterEntities();

        public User CheckLogin(User login)
        {
            try { 
                var User = masterEntities.Users.Where(x => x.username == login.username && x.password == login.password).First();
                return User;
            }
            catch { return null; }
        }
    }
}