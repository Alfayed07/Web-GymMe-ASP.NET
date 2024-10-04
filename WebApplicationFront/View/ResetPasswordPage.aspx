<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPasswordPage.aspx.cs" Inherits="WebApplicationFront.View.ResetPasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 400px;
            margin: 50px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        div {
            margin-bottom: 20px;
        }

        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        input[type="text"]:focus, input[type="password"]:focus {
            border-color: #007bff;
            outline: none;
        }

        .error-label {
            color: red;
            font-size: 14px;
            text-align: center;
        }

        asp:Button {
            display: block;
            width: 100%;
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
        }

        asp:Button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:TextBox ID="OldPassBox" runat="server" placeholder="Old Password" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="NewPassBox" runat="server" placeholder="New Password" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" CssClass="error-label" Text=""></asp:Label>
            </div>
            <div>
                <asp:Button ID="UpdatePassBtn" runat="server" Text="Update Password" OnClick="UpdatePassBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
