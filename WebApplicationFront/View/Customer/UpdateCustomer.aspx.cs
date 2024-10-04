using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;

namespace WebApplicationFront.View.Customer
{
    public partial class UpdateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }

        protected void UpdateProfile(String name)
        {
            MsUser user = UserHandler.getUser(name);
            int id = UserHandler.getId(name);
            String username = NameBox.Text;
            String email = EmailBox.Text;
            String gender = GenderBox.Text;
            String DOB = DOBBox.Text;

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

        protected void Update_Click(object sender, EventArgs e)
        {
            String name = Session["Username"].ToString();
            UpdateProfile(name);
            
        }
    }
}