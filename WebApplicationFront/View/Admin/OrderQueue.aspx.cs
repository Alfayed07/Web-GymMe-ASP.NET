using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Model;

namespace WebApplicationFront.View_backend
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("/View/LoginPage.aspx");
            }
            List<MsCart> list = (from x in db.MsCarts select x).ToList();
            CartView.DataSource = list;
            CartView.DataBind();
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
            foreach (String x in cookies)
            {
                Response.Cookies[x].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void Btn_handle_Click(object sender, EventArgs e)
        {
                Response.Redirect("~/View/Admin/ManagePage.aspx");     
        }
    }
}