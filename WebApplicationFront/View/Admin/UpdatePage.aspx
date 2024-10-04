<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="WebApplicationFront.View_backend.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Supplement</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 20px;
        }

        form {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        div {
            margin-bottom: 15px;
        }

        asp\:Label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
            color: #333;
        }

        asp\:TextBox,
        asp\:DropDownList {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        asp\:Button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 4px;
            transition: background-color 0.3s;
        }

        asp\:Button:hover {
            background-color: #0056b3;
        }

        .error {
            color: red;
            font-weight: bold;
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
                <asp:Label ID="ErrorLabel" runat="server" Text="" CssClass="error"></asp:Label>
            </div>

            <div>
                <asp:Button ID="UpdButton" runat="server" Text="Update" OnClick="UpdButton_Click" />
            </div>
        </div>
    </form>
</body>
</html>
