<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfileAdmin.aspx.cs" Inherits="WebApplicationFront.View_backend.UpdateProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Profile</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
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

        table {
            width: 100%;
            margin-bottom: 20px;
        }

        td {
            padding: 10px;
            vertical-align: middle;
        }

        asp\:TextBox {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        asp\:Button {
            background-color: #28a745;
            color: white;
            border: none;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 4px;
            transition: background-color 0.3s;
            display: inline-block;
        }

        asp\:Button:hover {
            background-color: #218838;
        }

        .error {
            color: red;
            font-weight: bold;
            margin-top: 10px;
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
                            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Email</td>
                        <td>
                            <asp:TextBox ID="emailBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Date of Birth</td>
                        <td>
                            <asp:TextBox ID="dobBox" runat="server" TextMode="Date"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td>
                            <asp:TextBox ID="genderBox" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" Text="" CssClass="error"></asp:Label>
            </div>

            <div>
                <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
            </div>
        </div>
    </form>
</body>
</html>
