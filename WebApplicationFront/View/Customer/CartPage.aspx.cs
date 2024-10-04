using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.View_backend
{
    public partial class CartPage : System.Web.UI.Page
    {
        private static Database1Entities db = InstanceDB.getInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                List<string> list = SupplementHandler.getSupplementName();
                GV.DataSource = SupplementHandler.getSupplement();
                GV.DataBind();
                SupplementList.DataSource = list;
                SupplementList.DataBind();
                
                String name = Session["Username"].ToString();
                int userid = UserHandler.getId(name);
                CartList.DataSource = CartHandler.getCartList(userid);
                CartList.DataBind();
            }
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            String role = Session["Role"].ToString();
            String name = Session["Username"].ToString();

            int userid = UserHandler.getId(name);    
            String quantity = QuantityBox.Text;
            String list = SupplementList.Text.ToString();
            int supplementid = SupplementHandler.getID(list);
            

            String success = SupplementController.addCartItem(userid, supplementid, quantity);
            if (success == "Yay! item added to cart!") Response.Redirect("/View/Customer/CartPage.aspx");

        }

        protected void btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Customer/OrderSupplementPage.aspx");
        }

        protected void btn_Order_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Customer/CartPage.aspx");
        }

        protected void btn_History_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Customer/HistoryPage.aspx");
        }

        protected void btn_Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Customer/CustomerProfilePage.aspx");
        }

        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            String[] cookies = Request.Cookies.AllKeys;
            foreach (String x in cookies)
            {
                Response.Cookies[x].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            String username = Session["Username"].ToString();
            int userid = UserHandler.getId(username);

            CartHandler.removeCart(userid);

            CartList.DataSource = CartHandler.getCartList(userid);
            CartList.DataBind();
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            String username = Session["Username"].ToString();
            int userId = UserHandler.getId(username);
              
              List<MsCart> cart = CartHandler.getCartList(userId);
              List<int> supplementId = new List<int>();
              List<int> quantity = new List<int>();

              foreach (var c in cart)
              {
                  supplementId.Add(c.SupplementID);
              }
             
            TransactionHandler.createNewTransaction(userId);  
            Response.Redirect("~/View/Customer/CartPage.aspx");
        }
    }
}