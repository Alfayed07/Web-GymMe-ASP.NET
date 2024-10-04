using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplicationFront.Module;

namespace WebApplicationFront1.Controller
{
    public class LoginController
    {
        public static String login(String username, String password)
        {
            if (username == "" || password == "")
            {
                return "Input can't empty";
            }

            if (username.Length < 5 || username.Length > 15)
            {
                return "username length must between 5 and 15";
            }

            WebService.WebService service = new WebService.WebService();
            String loginResult = json<String>.decode(service.login(username, password));
            if (loginResult == "login sucessfull")
            {
                return "login sucessfully";
            }
            else
            {
                return loginResult;
            }


        }
    }
}