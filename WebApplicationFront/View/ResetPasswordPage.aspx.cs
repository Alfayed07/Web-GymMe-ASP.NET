using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;

namespace WebApplicationFront.View
{
    public partial class ResetPasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }

        protected void UpdatePassBtn_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }

        protected void UpdatePassword()
        {
            String username = Session["Username"].ToString();
            String oldPassword = OldPassBox.Text;
            String newPassword = NewPassBox.Text;

            String success = UserController.ChangePass(username, oldPassword, newPassword);
            if (success == "Password has been changed")
            {
                String role = Session["Role"].ToString();
                if (role == "Admin")
                {
                    Response.Redirect("~/View/Admin/ProfilePage.aspx");
                }
                else if (role == "Customer")
                {
                    Response.Redirect("~/View/Customer/CustomerProfilePage.aspx");
                }
            }

            ErrorLabel.Text = success;
        }
    }
}