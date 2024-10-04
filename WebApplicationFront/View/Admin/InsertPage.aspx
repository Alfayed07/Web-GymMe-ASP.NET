<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="WebApplicationFront.View_backend.InsertPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Supplement</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        div {
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        input[type="text"],
        input[type="date"],
        select {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 16px;
        }

        input[type="text"]:focus,
        input[type="date"]:focus,
        select:focus {
            border-color: #007bff;
            outline: none;
        }

        .error {
            color: red;
            font-size: 14px;
        }

        button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 4px;
            transition: background-color 0.3s;
        }

        button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="TypeAvailLabel" runat="server" Text="">Type of Supplement</asp:Label>
                <asp:DropDownList ID="TypeList" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="NameLabel" runat="server" Text="Name of Supplement"></asp:Label>
                <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ExpiredLabel" runat="server" Text="Expired Date"></asp:Label>
                <asp:TextBox ID="ExpiredBox" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="PriceBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" CssClass="error" Text=""></asp:Label>
            </div>

            <div>
                <asp:Button ID="InsertNew" runat="server" Text="Insert" OnClick="InsertNew_Click" />
            </div>

        </div>
    </form>
</body>
</html>
