using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Handler;

namespace WebApplicationFront.Controller
{
    public class SupplementController
    {
        public static String insertSupplement(String name, String date, String priceStr, int typeId)
        {
            if (name == "" || date == "" || priceStr == "")
            {
                return "Input can't empty, 0, or negative";
            }

            if (!name.Contains("Supplement"))
            {
                return "Name must contain word 'Supplement' on it";
            }

            int price = int.Parse(priceStr);
            
            if (price < 3000)
            {
                return "price must be at least 3000";
            }

            DateTime newDate = DateTime.Parse(date);
            if (newDate < DateTime.Now)
            {
                return "Date must be greater than today's date";
            }
            
            SupplementHandler.insertNewSupplement(name, newDate, price, typeId);

            return "insert sucessfull";
        }

        public static String updateSupplement(int supplementId, String name, String date, int price, int typeId)
        {
            if (name == "" || date == "" || price <= 0 || typeId <= 0)
            {
                return "Input can't empty, 0, or negative";
            }

            if (!name.Contains("Supplement"))
            {
                return "Name must contain word 'Supplement' on it";
            }

            if (price < 3000)
            {
                return "price must be at least 3000";
            }

            DateTime newDate = DateTime.Parse(date);
            if (newDate < DateTime.Now)
            {
                return "Date must be greater than today's date";
            }
            
            SupplementHandler.updateSupplement(supplementId, name, newDate, price, typeId);

            return "update sucessfull";
        }

        public static void deleteSupplement(int supplementId)
        {
            SupplementHandler.deleteSupplement(supplementId);
        }

        public static String addCartItem(int userId, int supplementId, String quantity)
        {
            if (quantity == "")
            {
                return "Quantity must bigger than 0";
            }
            CartHandler.addNewCart(userId, supplementId, quantity);

            return "Yay! item added to cart!";
        }
    }
}