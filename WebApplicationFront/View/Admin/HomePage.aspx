<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplicationFront.View_backend.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        .main_content {
            max-width: 1200px;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        nav {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 10px 0;
            background-color: #007bff;
            color: white;
            border-radius: 8px;
        }

        .nav-left h1 {
            margin: 0;
            font-size: 24px;
        }

        .nav-right asp:Button {
            margin-left: 10px;
            background-color: transparent;
            color: white;
            border: none;
            cursor: pointer;
            font-size: 16px;
        }

        .nav-right asp:Button:hover {
            text-decoration: underline;
        }

        .main_content > div {
            margin: 20px 0;
            font-size: 18px;
            text-align: center;
        }

        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        .gridview th, .gridview td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        .gridview th {
            background-color: #007bff;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main_content">
            <nav>
                <div class="nav-left">
                    <h1>GymMe</h1>
                </div>

                <div class="nav-right">
                    <asp:Button ID="btn_Home" runat="server" Text="Home" OnClick="btn_Home_Click" />
                    <asp:Button ID="btn_Manage" runat="server" Text="Manage Supplement" OnClick="btn_Manage_Click" />
                    <asp:Button ID="btn_Order" runat="server" Text="Order Queue" OnClick="btn_Order_Click" />
                    <asp:Button ID="btn_Report" runat="server" Text="Transaction Report" OnClick="btn_Report_Click" />
                    <asp:Button ID="btn_Profile" runat="server" Text="Profile" OnClick="btn_Profile_Click" />
                    <asp:Button ID="btn_Logout" runat="server" Text="Logout" OnClick="btn_Logout_Click" />
                </div>
            </nav>
            <div>welcome to the GymMe</div>
            <div>
                <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label>
            </div>

            <div>
                <asp:GridView ID="ViewCustomer" runat="server" CssClass="gridview"></asp:GridView>
            </div>
            <br />
        </div>
    </form>
</body>
</html>
