using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFront1.View
{
    public partial class HomePage : System.Web.UI.Page
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

                    if (Session["Role"] == null)
                    {
                        Response.Redirect("~/View/LoginPage.aspx");
                    }

                    if (Session["Role"].ToString() == "Customer")
                    {
                        Response.Redirect("~/View/OrderSupplementPagePage.aspx");
                    }
                }

            }
            protected void btn_to_home_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

            protected void btn_to_manage_supplement_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/View/ManageSupplementPage.aspx");
            }

            protected void btn_to_queue_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/View/TransactionQueuePage.aspx");
            }

            protected void btn_to_transaction_report_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/View/TransactionDetailPage.aspx");
            }
            protected void btn_profile_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/View/ProfilePage.aspx");
            }

            protected void btn_logout_Click(object sender, EventArgs e)
            {
                Session.Clear();
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }
    }