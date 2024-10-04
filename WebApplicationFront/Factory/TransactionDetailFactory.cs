using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail createNewTransactionDetail(int transactionId, int supplementId, int quantity)
        {
            return new TransactionDetail
            {
                TransactionID = transactionId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }
    }
}