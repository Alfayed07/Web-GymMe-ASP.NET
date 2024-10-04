using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;

namespace WebApplicationFront.View_backend
{
    public partial class InsertSupplementPage : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                if (!IsPostBack)
                {
                    List<MsSupplement> list = SupplementHandler.getSupplement();
                    GV.DataSource = list;
                    GV.DataBind();

                    List<MsSupplementType> listType = SupplementHandler.getSupplementTypeList();
                    TypeGV.DataSource = listType;
                    TypeGV.DataBind();
                }
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

        protected void GV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GV.Rows[e.RowIndex];
            int id;
            if (int.TryParse(row.Cells[0].Text, out id))
            {
                SupplementHandler.deleteSupplement(id);
            }
            else
            {
                Console.WriteLine("Error Occured");
            }

        }

        protected void GV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV.Rows[e.NewEditIndex];
            int id;
            if (int.TryParse(row.Cells[0].Text, out id))
            {
                Response.Redirect("/View/Admin/Updatepage.aspx?id=" + id);
            }
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Admin/InsertPage.aspx");
        }

        protected void InsertTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/InsertTypePage.aspx");
        }
    }

}
