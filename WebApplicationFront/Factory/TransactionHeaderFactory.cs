using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader createNewTransactionHeader(int userId)
        {
            return new TransactionHeader
            {
                UserId = userId,
                TransactionDate = DateTime.Now,
                Status = "unhandled"
            };
        }
    }
}