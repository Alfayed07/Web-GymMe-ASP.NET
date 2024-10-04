using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;

namespace WebApplicationFront.View.Customer
{
    public partial class HistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String name = Session["Username"].ToString();
            int ID = UserHandler.getId(name);
            List<TransactionHeader> transactions = TransactionHandler.getAllTransactionHeaderById(ID);
            GridView1.DataSource = transactions;
            GridView1.DataBind();
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
    }
}