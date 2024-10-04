<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCustomer.aspx.cs" Inherits="WebApplicationFront.View.Customer.UpdateCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Customer</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 600px;
            margin: 30px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        table {
            width: 100%;
            border-collapse: collapse;
        }

        td {
            padding: 10px;
            font-size: 16px;
            color: #333;
        }

        td:first-child {
            text-align: right;
            padding-right: 15px;
        }

        input[type="text"], input[type="date"] {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        input[type="text"]:focus, input[type="date"]:focus {
            border-color: #007BFF;
            outline: none;
        }

        .error-label {
            color: red;
            margin-top: 10px;
            text-align: center;
            font-size: 14px;
        }

        .button-container {
            text-align: center;
            margin-top: 20px;
        }

        .button-container asp:Button {
            background-color: #007BFF;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
        }

        .button-container asp:Button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <table>
                    <tr>
                        <td>Name</td>
                        <td>
                            <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Email</td>
                        <td>
                            <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Date of Birth</td>
                        <td>
                            <asp:TextBox ID="DOBBox" runat="server" TextMode="Date"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td>
                            <asp:TextBox ID="GenderBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" CssClass="error-label" Text=""></asp:Label>
            </div>
            <div class="button-container">
                <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
            </div>
        </div>
    </form>
</body>
</html>
