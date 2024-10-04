using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Factory;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.Handler
{
    public class UserHandler
    {
        public static void registerNewUser(String username, String email, String password, DateTime DOB, String gender, String role)
        {
            MsUser newUser = UserFactory.createNewUser(username, email, password, DOB, gender, role);
            UserRepository.createNewMsUser(newUser);
        }

        public static String login(String username, String password)
        {
            MsUser currentUser = UserRepository.getMsUser(username);
            if (currentUser == null)
            {
                return "user not exist";
            }

            if (currentUser.Password != password)
            {
                return "password incorrect";
            }

            return currentUser.UserRole;
        }

        public static MsUser getUser(String username)
        {
            return UserRepository.getMsUser(username);
        }

        public static List<MsUser> getAllUsers()
        {
            return UserRepository.getAllMsUser();
        }

        public static void updateUserProfile(int id, String username, String email, DateTime DOB, String gender)
        {
            UserRepository.updateMsUser(id, username, email, DOB, gender);
        }

        public static Boolean updatePassword(String username, String oldPassword, String newPassword)
        {
            MsUser user = UserRepository.getMsUser(username);
            if (user.Password != oldPassword)
            {
                return false;
            }

            UserRepository.updateMsUserPassword(username, newPassword);
            return true;
        }

        public static int getId(String username)
        {
           return UserRepository.getId(username);
        }

        public static String getUsername(String username)
        {
            return UserRepository.getUsername(username);    
        }

        public static String getPassword (String pass)
        {
            return UserRepository.getPassword(pass);
        }
    }
}