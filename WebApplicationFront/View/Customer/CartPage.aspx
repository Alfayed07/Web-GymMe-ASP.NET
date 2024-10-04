<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="WebApplicationFront.View_backend.CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        form {
            width: 100%;
            max-width: 1200px;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            margin: 0;
            font-size: 24px;
            color: #333;
        }

        nav {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 10px;
            background-color: #007BFF;
            color: white;
            margin-bottom: 20px;
        }

        .nav-left h1 {
            margin: 0;
            color: white;
        }

        .nav-right asp:Button {
            background-color: #007BFF;
            color: white;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin-left: 10px;
        }

        .nav-right asp:Button:hover {
            background-color: #0056b3;
        }

        asp:GridView {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        asp:GridView th, asp:GridView td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: left;
        }

        asp:GridView th {
            background-color: #f2f2f2;
        }

        asp:DropDownList, asp:TextBox {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            margin-bottom: 15px;
        }

        asp:Label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        asp:Button {
            background-color: #28a745;
            color: white;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            width: 100%;
            margin-bottom: 15px;
        }

        asp:Button:hover {
            background-color: #218838;
        }

        asp:Button#ClearBtn {
            background-color: #dc3545;
        }

        asp:Button#ClearBtn:hover {
            background-color: #c82333;
        }

        asp:Label[ForeColor="Red"] {
            color: red;
            font-size: 12px;
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
                        <asp:Button ID="btn_Order" runat="server" Text="Order" OnClick="btn_Order_Click" />
                        <asp:Button ID="btn_History" runat="server" Text="History" OnClick="btn_History_Click" />
                        <asp:Button ID="btn_Profile" runat="server" Text="Profile" OnClick="btn_Profile_Click" />
                        <asp:Button ID="btn_Logout" runat="server" Text="Logout" OnClick="btn_Logout_Click" />
                    </div>
                </nav>
            </div>
            <div>
                <asp:GridView ID="GV" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID" />
                        <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName" />
                        <asp:BoundField DataField="SupplementExpirtyDate" HeaderText="Expired" SortExpression="SupplementPrice" />
                        <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
                        <asp:BoundField DataField="MsSupplementType.SupplementTypeName" HeaderText="Type of Supplement" SortExpression="SupplementTypeId" />
                    </Columns>
                </asp:GridView>
            </div>
            <br />
            <div>
                <asp:DropDownList ID="SupplementList" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="QuantityLbl" runat="server" Text="Quantity"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="QuantityBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
            <div>
                <asp:Button ID="OrderBtn" runat="server" Text="Order Supplement" OnClick="OrderBtn_Click" />
            </div>
            <br />
            <div>
                <asp:GridView ID="CartList" runat="server">
                </asp:GridView>
            </div>
            <div>
                <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />
                <asp:Button ID="ClearBtn" runat="server" Text="Clear Cart" OnClick="ClearBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
