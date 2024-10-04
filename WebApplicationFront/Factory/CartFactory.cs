using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Factory
{
    public class CartFactory
    {
        public static MsCart createNewCart(int userId, int supplementId, int quantity)
        {
            return new MsCart
            {
                UserId = userId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }
    }
}