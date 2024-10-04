using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplicationFront1.WebService;

namespace WebApplicationFront1.Controller
{
    public class ManageSupplementController
    {
        public static String insertSupplement(String name, String date, String priceStr, String typeIdStr)
        {
            if (name == "" || date == "" || priceStr == "" || typeIdStr == "")
            {
                return "Input can't empty, 0, or negative";
            }

            if (!name.Contains("Supplement"))
            {
                return "Name must contain word 'Supplement' on it";
            }

            int price = int.Parse(priceStr);
            int typeId = int.Parse(typeIdStr);
            if (price < 3000)
            {
                return "price must be at least 3000";
            }

            DateTime newDate = DateTime.Parse(date);
            if (newDate < DateTime.Now)
            {
                return "Date must be greater than today's date";
            }
            WebService.WebService service = new WebService.WebService();
            service.createNewSupplement(name, newDate, price, typeId);

            return "insert sucessfull";
        }

        public static String updateSupplement(String supplementId, String name, String date, int price, int typeId)
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
            WebService.WebService service = new WebService.WebService();
            service.updateSupplement(int.Parse(supplementId), name, newDate, price, typeId);

            return "update sucessfull";
        }

        public static void deleteSupplement(int supplementId)
        {
            WebService.WebService service = new WebService.WebService();
            service.deleteSupplement(supplementId);
        }
    }
}