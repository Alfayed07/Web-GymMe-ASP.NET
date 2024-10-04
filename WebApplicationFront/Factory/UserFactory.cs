using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Factory
{
    public class UserFactory
    {
        public static MsUser createNewUser(String username, String email, String password, DateTime DOB, String gender, String role)
        {
            return new MsUser
            {
                UserName = username,
                UserEmail = email,
                Password = password,
                UserDOB = DOB,
                UserGender = gender,
                UserRole = role
            };
        }
    }
}