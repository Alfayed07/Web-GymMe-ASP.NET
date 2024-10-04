using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Factory;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class TransactionRepository
    {
        private static Database1Entities db = InstanceDB.getInstance();

        public static void insertNewTransaction(int userid, List<int> idSupplement, List<int> quantity)
        {
            TransactionHeader transaction = TransactionHeaderFactory.createNewTransactionHeader(userid);
            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();

            foreach (var item in idSupplement.Zip(quantity, Tuple.Create))
            {
                TransactionDetail transactions = TransactionDetailFactory.createNewTransactionDetail(transaction.TransactionID
                    , item.Item1, item.Item2);
                db.TransactionDetails.Add(transactions);
            }
            db.SaveChanges();
        }
    }
}