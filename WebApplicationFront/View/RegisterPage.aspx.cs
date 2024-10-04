using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;


namespace WebApplicationFront1.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            String username = TB_Username.Text;
            String email = TB_Email.Text;
            String gender = TB_Gender.Text;
            String password = TB_Password.Text;
            String password_confirm = TB_Password_confirm.Text;
            String DOB = TB_DOB.Text;

            String isSucessful = UserController.registerNewUser(username, email, gender, password, password_confirm, DOB);

            if (isSucessful == "register sucessfully")
            {
                ErrorLabel.Text = isSucessful;
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                ErrorLabel.Text = isSucessful;
            } 

            

        }

        protected void btn_to_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btn_to_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }
    }
}