<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="WebApplicationFront.View_backend.OrderQueue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Queue</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        form {
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
            background-color: #007bff;
            padding: 15px;
            color: white;
            border-radius: 8px 8px 0 0;
        }

        .nav-left h1 {
            margin: 0;
            font-size: 24px;
        }

        .nav-right asp:Button {
            margin-left: 15px;
            background-color: white;
            color: #007bff;
            border: none;
            padding: 10px 15px;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .nav-right asp:Button:hover {
            background-color: #e0e0e0;
        }

        asp:Button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 4px;
            transition: background-color 0.3s;
            margin-top: 15px;
        }

        asp:Button:hover {
            background-color: #0056b3;
        }

        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        .gridview th,
        .gridview td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        .gridview th {
            background-color: #007bff;
            color: white;
        }

        .gridview tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .gridview tr:hover {
            background-color: #ddd;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
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
            </div>
            <div>
                <asp:GridView ID="CartView" runat="server" AutoGenerateColumns="false" CssClass="gridview">
                    <Columns>
                        <asp:BoundField DataField="CartID" HeaderText="Cart ID" SortExpression="CartID" />
                        <asp:BoundField DataField="UserId" HeaderText="User ID" SortExpression="UserId" />
                        <asp:BoundField DataField="MsUser.UserName" HeaderText="User Name" SortExpression="MsUser.UserName" />
                        <asp:BoundField DataField="SupplementID" HeaderText="Supplement ID" SortExpression="SupplementID" />
                        <asp:BoundField DataField="MsSupplement.SupplementName" HeaderText="Supplement Name" SortExpression="MsSupplement.SupplementName" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    </Columns>
                </asp:GridView>
            </div>
            <div>
                <asp:Button ID="Btn_handle" runat="server" Text="Handle" OnClick="Btn_handle_Click" />
            </div>
        </div>
    </form>
</body>
</html>
