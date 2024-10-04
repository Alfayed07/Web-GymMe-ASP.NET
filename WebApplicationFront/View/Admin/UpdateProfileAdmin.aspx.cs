using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;

namespace WebApplicationFront.View_backend
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("/View/LoginPage.aspx");
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            String name = Session["Username"].ToString();
            UpdateAdmin(name);
            
        }

        protected void UpdateAdmin(String name)
        {
            MsUser user = UserHandler.getUser(name);
            int id = UserHandler.getId(name);
            String username = nameBox.Text;
            String email = emailBox.Text;
            String gender = genderBox.Text;
            String DOB = dobBox.Text;

            String success = UserController.UpdateUser(id, username, email, DOB, gender);
            if (success == "Profile success to change")
            {
                String[] cookies = Request.Cookies.AllKeys;
                foreach (String x in cookies)
                {
                    Response.Cookies[x].Expires = DateTime.Now.AddDays(-1);
                }
                Session.Clear();
                Response.Redirect("~/View/LoginPage.aspx");
                
            }
            ErrorLabel.Text = success;


        }

    }
}