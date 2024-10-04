using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class CartRepository
    {
        private static Database1Entities db = InstanceDB.getInstance();
        public static void AddCart(MsCart newCart)
        {           
            db.MsCarts.Add(newCart);
            db.SaveChanges();
        }
        public static List<MsCart> getCartList(int userId)
        {           
            return db.MsCarts.Where(cart => cart.UserId == userId).ToList();
        }

        public static void deleteCart(int id)
        {            
            List<MsCart> userCart = db.MsCarts.Where(cart => cart.UserId == id).ToList();
            db.MsCarts.RemoveRange(userCart);
            db.SaveChanges();
        }

        public static int getCartbyUserId(int id)
        {
            return (from x in db.MsCarts
                    where x.UserId.Equals(id)
                    select x.CartID).ToList().FirstOrDefault();
        }
    }
}