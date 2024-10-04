using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Factory;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.Handler
{
    public class TransactionHandler
    {
        public static void createNewTransaction(int userId)
        {
            TransactionHeader newTransactionHeader = TransactionHeaderFactory.createNewTransactionHeader(userId);
            TransactionHeaderRepo.createNewTransactionHeader(newTransactionHeader);

            int transactionId = newTransactionHeader.TransactionID;

            List<MsCart> cartList = CartRepository.getCartList(userId);
            List<TransactionDetail> TDlist = new List<TransactionDetail>();
            foreach (MsCart cart in cartList)
            {
                TransactionDetail newTransactionDetail = TransactionDetailFactory.createNewTransactionDetail(transactionId, cart.SupplementID, cart.Quantity);
                TDlist.Add(newTransactionDetail);
            }

            TransactionDetailRepo.addNewTransactionDetail(TDlist);

            CartRepository.deleteCart(userId);
        }

        public static List<TransactionHeader> getAllTransactionHeaderById(int id)
        {
            return TransactionHeaderRepo.getAllTransactionDetailbyId(id);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionHeaderRepo.getAllTransactionHeader();
        }

        public static List<TransactionDetail> getAllTransactionDetail(int id)
        {
            return TransactionDetailRepo.GetAllTransactionDetailById(id);
        }

        public static void updateTransactionHeaderStatus(int id)
        {
            TransactionHeaderRepo.updateStatus(id, "Handled");
        }

        public static void insertTransaction(int id, List<int> supplementid, List<int> quantity)
        {
            TransactionRepository.insertNewTransaction(id, supplementid, quantity);
        }
    }
}