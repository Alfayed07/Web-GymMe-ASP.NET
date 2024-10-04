using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;

namespace WebApplicationFront.View_backend
{
    public partial class InsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Role"] == null)
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
            Response.Redirect("/View/Admin/HomePage.aspx");
        }

        protected void btn_Manage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Admin/ManagePage.aspx");
        }

        protected void btn_Order_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Admin/OrderQueue.aspx");
        }

        protected void btn_Report_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/ProfilePage.aspx");
        }

        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            String[] cookies = Request.Cookies.AllKeys;
            foreach (String x in cookies )
            {
                Response.Cookies[x].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}