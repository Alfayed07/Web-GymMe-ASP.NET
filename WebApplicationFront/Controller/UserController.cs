using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;
using WebApplicationFront.Module;

namespace WebApplicationFront.Controller
{
    public class UserController
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

            return UserHandler.login(username, password);
        }


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

            DateTime userDOB = DateTime.Parse(DOB);

            UserHandler.registerNewUser(username, email, password, userDOB, gender, "Customer");

            return "register sucessfully";
        }

        public static String UpdateUser(int id, String name, String email, String DOB, String gender)
        {
            String username = UserHandler.getUsername(name);
            if (name == "" || email == "" || gender == "" || DOB == "")
            {
                return "Input cant be empty";
            }
            if (username == name)
            {
                return "Name Already Exist";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email must be filled with end @.com";
            }
            if (gender != "male" && gender != "female")
            {
                return "Must be male or female";
            }
            DateTime dob = DateTime.Parse(DOB);
            UserHandler.updateUserProfile(id, name, email, dob, gender);

            return "Profile success to change";
        }

        public static String ChangePass(String username, String oldPassword, String newPassword)
        {
            String oldPass = UserHandler.getPassword(oldPassword);
            if (oldPassword == "")
            {
                return "Password must be filled";
            }
            if (newPassword == oldPass)
            {
                return "Password can't be same with the old one";
            }
            UserHandler.updatePassword(username, oldPassword, newPassword);
            
            return "Password has been changed";
        }
    }
}