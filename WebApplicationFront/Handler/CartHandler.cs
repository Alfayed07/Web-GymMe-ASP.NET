using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Factory;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.Handler
{
    public class CartHandler
    {
        public static void addNewCart(int userId, int SupplementId, String quantity)
        {   
            int Quantity = Convert.ToInt32(quantity);
            MsCart newCart = CartFactory.createNewCart(userId, SupplementId, Quantity);
            CartRepository.AddCart(newCart);
        }

        public static List<MsCart> getCartList(int id)
        {
            return CartRepository.getCartList(id);
        }

        public static void removeCart(int userId)
        {
            CartRepository.deleteCart(userId);
        }

        

        public static int getCartbyUserId(int id)
        {
            return CartRepository.getCartbyUserId(id);
        }
    }
}