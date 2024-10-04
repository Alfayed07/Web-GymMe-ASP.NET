using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Factory;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.Handler
{
    public class SupplementHandler
    {
        public static void insertType(String name)
        {
            MsSupplementType supplementType = SupplementFactory.createSupplementType(name);
            SupplementRepository.insertType(supplementType);

        }
        public static List<MsSupplementType> getSupplementTypeList()
        {
            return SupplementRepository.getAllType();
        }

        public static void updateType(int id, String name)
        {
            SupplementRepository.updateType(id, name);  
        }

        public static void deleteType(int id)
        {
            SupplementRepository.deleteType(id);
        }

        public static List<String> getSupplementTypeName()
        {
            return SupplementRepository.getSupplementTypeName();
        }


        public static List<MsSupplement> getSupplement()
        {
            return SupplementRepository.getMsSupplementList();
        }

        public static void insertNewSupplement(String name,DateTime date,int price,int typeId)
        {
            MsSupplement newSupplement = SupplementFactory.createNewSupplement(name,date,price,typeId);
            SupplementRepository.insertNewSupplement(newSupplement);
        }

        public static MsSupplement updateSupplement(int id,String name,DateTime date,int price,int typeId)
        {
            return SupplementRepository.updateSupplement(id,name,date,price,typeId);
        }

        public static void deleteSupplement(int id)
        {
            SupplementRepository.deleteSupplement(id);
        }

        public static MsSupplement getSupplementById(int id)
        {
            return SupplementRepository.getSupplementbyId(id);
        }

        public static List<String> getSupplementName()
        {
            return SupplementRepository.GetSupplementName();
        }

        public static int getID(String name)
        {
            return SupplementRepository.getId(name);
        }

        public static int getTypeId(String name)
        {
            return SupplementRepository.getTypeId(name);
        }
    }
}