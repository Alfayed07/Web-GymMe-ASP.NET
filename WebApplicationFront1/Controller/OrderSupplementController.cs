using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationFront1.Controller
{
    public class OrderSupplementController
    {
        public static String addCartItem(int userId, int supplementId, int quantity)
        {
            if (quantity < 1)
            {
                return "Quantity must bigger than 0";
            }

            WebService.WebService service = new WebService.WebService();
            service.addNewCart(userId, supplementId, quantity);

            return "Yay! item added to cart!";
        }

    }
}