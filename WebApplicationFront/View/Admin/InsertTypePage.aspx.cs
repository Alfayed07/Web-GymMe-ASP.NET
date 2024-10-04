using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Handler;

namespace WebApplicationFront.View.Admin
{
    public partial class InsertTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }

        }

        protected void InsertTypeBtn_Click(object sender, EventArgs e)
        {
            String type = TypeBox.Text;
            SupplementHandler.insertType(type);
            Response.Redirect("~/View/Admin/ManagePage.aspx");
        }
    }
}