using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.View_backend
{
    public partial class ProfilePage : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Role"] != null && Session["Username"] != null)
            {
                String role = Session["Role"].ToString();
                String name = Session["Username"].ToString();

                MsUser user = UserHandler.getUser(name);
                if (user != null)
                {
                    NameLbl.Text = user.UserName;
                    EmailLbl.Text = user.UserEmail;
                    DOBLbl.Text = user.UserDOB.ToString("D");
                    GenderLbl.Text = user.UserGender;
                    RoleLbl.Text = user.UserRole;
                }
                else
                {
                    Console.WriteLine("User not found");
                }
            }

            else
            {
                Response.Redirect("~/View/LoginPage.aspx");
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
            foreach (String x in cookies)
            {
                Response.Cookies[x].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void UpdProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/UpdateProfileAdmin.aspx");
        }

        protected void ResetPassBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ResetPasswordPage.aspx");
        }
    }
}