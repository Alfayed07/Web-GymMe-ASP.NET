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
    public partial class UpdatePage : System.Web.UI.Page
    {
        private static Database1Entities db = InstanceDB.getInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                if (IsPostBack == false)
                {
                    int id;
                    if (int.TryParse(Request.QueryString["id"], out id))
                    {
                        MsSupplement supplement = SupplementHandler.getSupplementById(id);
                        List<String> typelist = SupplementHandler.getSupplementTypeName();
                        TypeList.DataSource = typelist;
                        TypeList.DataBind();

                        NameBox.Text = supplement.SupplementName;
                        ExpiredBox.Text = supplement.SupplementExpirtyDate.ToString();
                        PriceBox.Text = supplement.SupplementPrice.ToString();
                        TypeList.SelectedValue = supplement.MsSupplementType.SupplementTypeName;

                    }
                }
            }
            else
            {
                Response.Redirect("/View/LoginPage.aspx");
            }

        }

        protected void UpdButton_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(Request.QueryString["id"], out id))
            {
                String name = NameBox.Text.ToLower();
                String expired = ExpiredBox.Text.ToLower();
                int price = Convert.ToInt32(PriceBox.Text.ToLower());
                String typeName = TypeList.Text.ToString();
                int getid = SupplementHandler.getTypeId(typeName);

                String success = SupplementController.updateSupplement(id, name, expired, price, getid);
                Response.Redirect("/View/Admin/ManagePage.aspx");
            }
        }
    }
}