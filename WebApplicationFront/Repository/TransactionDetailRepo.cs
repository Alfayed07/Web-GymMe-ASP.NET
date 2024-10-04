using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class TransactionDetailRepo
    {
        private static Database1Entities db = InstanceDB.getInstance();

        public static void addNewTransactionDetail(List<TransactionDetail> newTransactionDetail)
        {
            db.TransactionDetails.AddRange(newTransactionDetail);
            db.SaveChanges();
        }

        public static List<TransactionDetail> GetAllTransactionDetailById(int id)
        {
            List<TransactionDetail> TDlist = db.TransactionDetails.Where(TD => TD.TransactionID == id).ToList();
            return db.TransactionDetails.ToList();
            // return TDlist;
        }
    }
}