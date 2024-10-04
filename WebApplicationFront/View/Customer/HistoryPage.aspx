<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryPage.aspx.cs" Inherits="WebApplicationFront.View.Customer.HistoryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>History Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 1000px;
            margin: 30px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        h1 {
            font-size: 24px;
            margin: 0;
            color: #333;
        }

        nav {
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: #007BFF;
            padding: 10px 20px;
            color: white;
            border-radius: 5px;
            margin-bottom: 20px;
        }

        .nav-left h1 {
            color: white;
            margin: 0;
        }

        .nav-right asp:Button {
            background-color: white;
            color: #007BFF;
            padding: 8px 15px;
            border: none;
            border-radius: 4px;
            margin-left: 10px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .nav-right asp:Button:hover {
            background-color: #0056b3;
            color: white;
        }

        div {
            margin-bottom: 20px;
        }

        asp:GridView {
            width: 100%;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        asp:GridView th {
            background-color: #007BFF;
            color: white;
            padding: 10px;
        }

        asp:GridView td {
            padding: 10px;
            text-align: center;
            border-bottom: 1px solid #ddd;
        }

        asp:Label {
            font-size: 18px;
            color: #333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
            <div>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
            <div>
                <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
