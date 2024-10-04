<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertTypePage.aspx.cs" Inherits="WebApplicationFront.View.Admin.InsertTypePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert New Type</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 400px;
            margin: 100px auto;
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

        input[type="text"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 16px;
        }

        input[type="text"]:focus {
            border-color: #007bff;
            outline: none;
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
                <asp:Label ID="NameLabel" runat="server" Text="New Type"></asp:Label> 
            </div>
            <div>
                <asp:TextBox ID="TypeBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="InsertTypeBtn" runat="server" Text="Insert New Type" OnClick="InsertTypeBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
