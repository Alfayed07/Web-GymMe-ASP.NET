using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFront.View_backend
{
    public partial class OrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null)
            {
                Response.Redirect("/View/LoginPage.aspx");
            }
            HttpCookie roleCookie = Request.Cookies["Role"];
            HttpCookie usernameCookie = Request.Cookies["Username"];

            if (roleCookie != null)
            {
                NameLbl.Text = usernameCookie.Value;

            }
            else
            {
                NameLbl.Text = Session["Username"].ToString();
            }
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