<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSupplementPage.aspx.cs" Inherits="WebApplicationFront1.View.ManageSupplementPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>GymMe</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main_content">
            <nav>
                <div class="nav-left">
                    <h1>GymMe</h1>
                </div>
                <div class="nav-right">
                    <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />            
                    <asp:Button ID="btn_history" runat="server" Text="History" OnClick="btn_history_Click" />
                    <asp:Button ID="btn_profile" runat="server" Text="Profile" OnClick="btn_profile_Click" />
                    <asp:Button ID="btn_to_home" runat="server" Text="Home" OnClick="btn_to_home_Click" />
                    <asp:Button ID="btn_to_manage_supplement" runat="server" Text="Manage" OnClick="btn_to_manage_supplement_Click" />
                    <asp:Button ID="btn_to_order_queue" runat="server" Text="Queue" OnClick="btn_to_queue_Click" />
                    <asp:Button ID="btn_to_transaction_report" runat="server" Text="Report" OnClick="btn_to_transaction_report_Click" />

                </div>
            </nav>
            <h1 class="title">
                Manage Supplement
            </h1>
            s
            <asp:GridView ID="GV" runat="server" OnRowEditing="btn_update" OnRowDeleting="btn_delete">
                <Columns>
                    <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="ACTION"></asp:CommandField>
                </Columns>
            </asp:GridView>

            <asp:Button ID="btn_InsertSupplement" runat="server" Text="Insert Supplement" OnClick="btn_InsertSupplement_Click"/>
            
            <br />
        </div>
    </form>
</body>
</html>

