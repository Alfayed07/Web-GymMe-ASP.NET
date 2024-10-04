using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;
using WebApplicationFront.Repository;


namespace WebApplicationFront1.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie roleCookie = Request.Cookies["Role"];
                if (roleCookie != null)
                {
                    Session["Role"] = roleCookie.Value;
                }

                if (Session["Role"] != null)
                {
                    if (Session["Role"].ToString() == "Customer")
                    {
                        Response.Redirect("~/View/Customer/OrderSupplementPage.aspx");
                    }
                    else if (Session["Role"].ToString() == "Admin")
                    {
                        Response.Redirect("~/View/Admin/HomePage.aspx");
                    }
                }
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            String username = TB_Username.Text;
            String password = TB_Password.Text;
            Boolean isRememberMe = CheckBox.Checked;


            String isSucessful = UserController.login(username, password);

            if (isRememberMe)
            {
                HttpCookie roleCookie = createNewCookie("Role", isSucessful);
                HttpCookie usernameCookie = createNewCookie("Username", username);

                Response.Cookies.Add(roleCookie);
                Response.Cookies.Add(usernameCookie);
            }
            if (isSucessful == "Customer" || isSucessful == "Admin")
            {
                if (isSucessful == "Customer")
                {
                    Session["Role"] = "Customer";
                    Session["Username"] = username;
                    Response.Redirect("~/View/Customer/OrderSupplementPage.aspx");
                }
                else if (isSucessful == "Admin")
                {
                    Session["Role"] = "Admin";
                    Session["Username"] = username;
                    Response.Redirect("~/View/Admin/HomePage.aspx");
                }


                Label_message.Text = isSucessful;

            }
            else
            {
                Label_message.Text = isSucessful;
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

        private static HttpCookie createNewCookie(string name, string value)
        {
            HttpCookie newCookie = new HttpCookie(name);
            newCookie.Value = value;
            newCookie.Expires = DateTime.Now.AddMinutes(3);
            return newCookie;
        }
    }
}