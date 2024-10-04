<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagePage.aspx.cs" Inherits="WebApplicationFront.View_backend.InsertSupplementPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Supplements</title>
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

        .title {
            font-size: 28px;
            margin: 20px 0;
            color: #333;
        }

        .title div {
            margin-bottom: 15px;
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
        }

        asp:Button:hover {
            background-color: #0056b3;
        }

        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
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
                <h1 class="title">Manage Supplement</h1>
                <div>
                    <asp:Button ID="InsertButton" runat="server" Text="Insert New Supplement" OnClick="InsertButton_Click" />
                    <asp:Button ID="InsertTypeButton" runat="server" Text="Insert New Type" OnClick="InsertTypeButton_Click" />
                </div>
                <br />
                <div>
                    <asp:GridView ID="TypeGV" runat="server" CssClass="gridview"></asp:GridView>
                </div>
                <br />
                <div>
                    <asp:GridView ID="GV" runat="server" AutoGenerateColumns="False" OnRowDeleting="GV_RowDeleting" OnRowEditing="GV_RowEditing" CssClass="gridview">
                        <Columns>
                            <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID" />
                            <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName" />
                            <asp:BoundField DataField="SupplementExpirtyDate" HeaderText="Expired" SortExpression="SupplementPrice" />
                            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
                            <asp:BoundField DataField="MsSupplementType.SupplementTypeName" HeaderText="Type of Supplement" SortExpression="SupplementTypeId" />
                            <asp:CommandField ButtonType="Button" HeaderText="Update and Delete" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
