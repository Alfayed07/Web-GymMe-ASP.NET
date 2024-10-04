using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class UserRepository
    {
        private static Database1Entities db = InstanceDB.getInstance();

        public static void createNewMsUser(MsUser newUser)
        {
            db.MsUsers.Add(newUser);
            db.SaveChanges();
        }

        public static List<MsUser> getAllMsUser()
        {
            Database1Entities db = InstanceDB.getInstance();
            db = InstanceDB.getInstance();
            return db.MsUsers.ToList();
        }

        public static MsUser getMsUser(String username)
        {
            return (from x in db.MsUsers
                    where x.UserName.Equals(username)
                    select x).FirstOrDefault();
        }

        public static MsUser getMsUserById(int id)
        {
            return db.MsUsers.Where((u) => u.UserID == id).ToList().FirstOrDefault();
        }

        public static int getId (String username)
        {
            var x = (from y in db.MsUsers
                     where y.UserName.Equals(username)
                     select y.UserID).FirstOrDefault();
            return x;
        }


        public static void updateMsUser(int id, String username, String email, DateTime DOB, String gender)
        {
            MsUser currentMsUser = getMsUserById(id);
            currentMsUser.UserName = username;
            currentMsUser.UserEmail = email;
            currentMsUser.UserDOB = DOB;
            currentMsUser.UserGender = gender;
            db.SaveChanges();
        }

        public static void updateMsUserPassword(String username, String newPassword)
        {
            Database1Entities db = InstanceDB.getInstance();
            MsUser currentUser = getMsUser(username);
            currentUser.Password = newPassword;
            db.SaveChanges();
        }

        public static String getUsername (String username)
        {
            return (from x in db.MsUsers
                    where x.UserName.Equals(username)
                    select x.UserName).FirstOrDefault();    
        }

        public static String getPassword (String password)
        {
            return (from x in db.MsUsers
                    where x.Password.Equals(password)
                    select x.Password).FirstOrDefault();
        }
    }
}