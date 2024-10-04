<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSupplementPage.aspx.cs" Inherits="WebApplicationFront1.View.OrderSupplementPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GymMe</title>
    <link rel="stylesheet" href="./css/mainStyle.css" />
    <link rel="stylesheet" href="./css/table.css" />
    <link rel="stylesheet" href="./css/orderSupplement.css" />
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
                    <asp:Button ID="btn_profile" runat="server" Text="Profile" OnClick="btn_profile_Click" />
                    <asp:Button ID="btn_history" runat="server" Text="History" OnClick="btn_history_Click" />
                    <asp:Button ID="btn_order_supplement" runat="server" Text="Order" OnClick="btn_order_supplement_Click" />
                    
                </div>
           

        </div>
    </form>
</body>
</html>