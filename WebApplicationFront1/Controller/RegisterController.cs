using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationFront1.Controller
{
    public class RegisterController
    {
        public static String registerNewUser(String username, String email, String gender, String password, String password_confirm, String DOB)
        {
            if (username == "" || email == "" || password == "" || password_confirm == "" || DOB == "")
            {
                return "Input can't empty";
            }

            if (username.Length < 5 || username.Length > 15)
            {
                return "username length must between 5 and 15";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email must be ended with '.com'";
            }

            if (gender != "female" && gender != "male")
            {
                return "gender must be choose either male/female";
            }

            if (password != password_confirm)
            {
                return "password must be same with confirm password";
            }


            WebService.WebService service = new WebService.WebService();

            DateTime userDOB = DateTime.Parse(DOB);

            service.registerNewUser(username, email, password, userDOB, gender, "Customer");

            return "register sucessfully";
        }
    }
}