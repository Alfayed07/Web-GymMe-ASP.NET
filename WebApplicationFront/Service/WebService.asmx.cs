using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;
using WebApplicationFront.Module;

namespace WebApplicationFront.Service
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void registerNewUser(String username, String email, String password, DateTime DOB, String gender, String role)
        {
            UserHandler.registerNewUser(username, email, password, DOB, gender, role);
        }

        [WebMethod]
        public String login(String username, String password)
        {
            String result = UserHandler.login(username, password);
            return json<String>.encode(result);
        }

        [WebMethod]
        public String getUser(String username)
        {
            MsUser user = UserHandler.getUser(username);
            return json<MsUser>.encode(user);
        }

        [WebMethod]
        public String getAllUser()
        {
            return json<List<MsUser>>.encode(UserHandler.getAllUsers());
        }

        [WebMethod] 
        public String getSupplementList()
        {
            return json<List<MsSupplement>>.encode(SupplementHandler.getSupplement());
        }

        [WebMethod]
        public void createNewSupplement(String name, DateTime date, int price, int TypeId)
        {
            SupplementHandler.insertNewSupplement(name, date, price, TypeId);
        }

        [WebMethod]
        public void updateSupplement(int supplementId, String name, DateTime date, int price, int TypeId)
        {
            SupplementHandler.updateSupplement(supplementId, name, date, price, TypeId);
        }

        [WebMethod]
        public void deleteSupplement(int supplementId)
        {
            SupplementHandler.deleteSupplement(supplementId);
        }
        /*
        [WebMethod]
        public String getCartList(int id)
        {
            return json<List<MsCart>>.encode(CartHandler.GetAllCarts(id));
        }

        */

        /*
        [WebMethod]
        public void addNewCart(int userId, int supplementId, int quantity)
        {
            CartHandler.addNewCart(userId, supplementId, quantity);
        }
        */

        [WebMethod]
        public void clearCart(int id)
        {
            CartHandler.removeCart(id);
        }

        [WebMethod]
        public String insertType(String name)
        {
            SupplementHandler.insertType(name);
            return "Inserted";
        }

        [WebMethod]
        public void updateType(int id, String name)
        {
            SupplementHandler.updateType(id, name);
        }
        [WebMethod]

        public void deleteType(int id)
        {
            SupplementHandler.deleteType(id);
        }

    }
}
