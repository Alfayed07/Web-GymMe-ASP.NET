using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFront.Controller;
using WebApplicationFront.Handler;
using WebApplicationFront.Model;
using WebApplicationFront.Repository;

namespace WebApplicationFront.View_backend
{
    public partial class InsertPage1 : System.Web.UI.Page
    {
        private static Database1Entities db = InstanceDB.getInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                if (IsPostBack == false)
                {
                    List<String> typelist = SupplementHandler.getSupplementTypeName();
                    TypeList.DataSource = typelist;
                    TypeList.DataBind();
                }
            }
            else
            {
                Response.Redirect("/View/LoginPage.aspx");
            }

        }

        protected void InsertNew_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            String expired = ExpiredBox.Text;
            String number = PriceBox.Text;
            String typename = TypeList.Text;
            int id = SupplementHandler.getTypeId(typename);

            
            String success = SupplementController.insertSupplement(name, expired, number, id);
            if (success == "insert sucessfull")
            {
                Response.Redirect("/View/Admin/ManagePage.aspx");
            }
            ErrorLabel.Text = success;           
        }

    }
}