using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class TransactionHeaderRepo
    {

        private static Database1Entities db = InstanceDB.getInstance();
        public static void createNewTransactionHeader(TransactionHeader newTransactionHeader)
        {
            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();
        }

        public static void updateStatus(int id, String status)
        {
            TransactionHeader currentTransacrionHeader = db.TransactionHeaders.Where(TH => TH.TransactionID == id).FirstOrDefault();
            currentTransacrionHeader.Status = status;
            db.SaveChanges();
        }

        public static List<TransactionHeader> getAllTransactionDetailbyId(int id)
        {
            List<TransactionHeader> getAllTransactionHeader = db.TransactionHeaders.Where(TH => TH.UserId == id).ToList();
            return getAllTransactionHeader;
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}