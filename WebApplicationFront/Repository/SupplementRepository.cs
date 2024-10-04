using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Factory;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class SupplementRepository
    {

        private static Database1Entities db = InstanceDB.getInstance();
        

        public static void insertType(MsSupplementType supplementType)
        {
            db.MsSupplementTypes.Add(supplementType);
            db.SaveChanges();
        }

        public static List<MsSupplementType> getAllType()
        {
            return (from x in db.MsSupplementTypes select x).ToList();  
        }

        public static List<String> getSupplementTypeName()
        {
            
            return (from x in db.MsSupplementTypes
                    select x.SupplementTypeName).ToList();
        }

        public static MsSupplementType getTypebyId(int id)
        {
            return (from x in db.MsSupplementTypes
                    where x.SupplementTypeID.Equals(id)
                    select x).ToList().FirstOrDefault();
        }
        
        public static MsSupplementType updateType(int id, string name)
        {
            MsSupplementType supplementId = getTypebyId(id); 
            supplementId.SupplementTypeName = name;
            return supplementId;
        }
        
        public static void deleteType(int id)
        {
            MsSupplementType supplementType = getTypebyId(id);
            db.MsSupplementTypes.Remove(supplementType);
            db.SaveChanges();
        }


        public static MsSupplement getSupplementbyId(int id)
        {
            // Database1Entities db = InstanceDB.getInstance();
            // db = InstanceDB.getInstance();
            MsSupplement supplement = db.MsSupplements.Where(supp => supp.SupplementID == id).FirstOrDefault();
            return supplement;
        }
        public static List<MsSupplement> getMsSupplementList()
        {
            // Database1Entities db = InstanceDB.getInstance();
            // db = InstanceDB.getInstance();
            return db.MsSupplements.ToList();
        }

        public static void insertNewSupplement(MsSupplement supplement)
        {
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }

        public static MsSupplement updateSupplement(int supplementId, String name, DateTime date, int price, int typeId)
        {
            // Database1Entities db = InstanceDB.getInstance();
            MsSupplement supplement = getSupplementbyId(supplementId);
            supplement.SupplementName = name;
            supplement.SupplementExpirtyDate = date;
            supplement.SupplementPrice = price;
            supplement.SupplementTypeID = typeId;
            db.SaveChanges();

            return supplement;
        }

        public static void deleteSupplement(int id)
        {
            // Database1Entities db = InstanceDB.getInstance();
            // db = InstanceDB.getInstance();
            MsSupplement supplement = getSupplementbyId(id);
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
        }

        public static List<String> GetSupplementName()
        {
            return (from x in db.MsSupplements
                    select x.SupplementName).ToList();
        }

        public static int getId(String name)
        {
            return (from x in db.MsSupplements
                    where x.SupplementName.Equals(name)
                    select x.SupplementID).FirstOrDefault();
        }

        public static int getTypeId(String name)
        {
            return (from x in db.MsSupplementTypes
                    where x.SupplementTypeName.Equals(name)
                    select x.SupplementTypeID).FirstOrDefault();
        }
    }
}