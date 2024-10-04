<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="WebApplicationFront.View_backend.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 800px;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        .nav-left {
            display: inline-block;
            vertical-align: middle;
        }

        .nav-left h1 {
            margin: 0;
            font-size: 24px;
            color: #007bff;
        }

        .nav-right {
            display: inline-block;
            float: right;
        }

        .nav-right asp:Button {
            margin-left: 15px;
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .nav-right asp:Button:hover {
            background-color: #0056b3;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }

        td:first-child {
            font-weight: bold;
            color: #555;
        }

        asp:Button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 4px;
            margin-top: 20px;
            transition: background-color 0.3s;
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
            </div>
            <div>
                <table>
                    <tr>
                        <td>Name</td>
                        <td>
                            <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Email</td>
                        <td>
                            <asp:Label ID="EmailLbl" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Date of Birth</td>
                        <td>
                            <asp:Label ID="DOBLbl" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td>
                            <asp:Label ID="GenderLbl" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Role</td>
                        <td>
                            <asp:Label ID="RoleLbl" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:Button ID="UpdProfileBtn" runat="server" Text="Update Profile" OnClick="UpdProfileBtn_Click" />
                <asp:Button ID="ResetPassBtn" runat="server" Text="Reset Password" OnClick="ResetPassBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
