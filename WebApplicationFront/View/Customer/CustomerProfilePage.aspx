<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerProfilePage.aspx.cs" Inherits="WebApplicationFront.View.Customer.CustomerProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Profile</title>
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
            max-width: 800px;
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
            border-radius: 5px;
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

        table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        table tr td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }

        table tr td:first-child {
            font-weight: bold;
            width: 150px;
            color: #333;
        }

        table tr td asp:Label {
            font-size: 16px;
            color: #555;
        }

        asp:Button {
            background-color: #28a745;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            width: 48%;
            margin-right: 2%;
            display: inline-block;
        }

        asp:Button:hover {
            background-color: #218838;
        }

        asp:Button#ResetPassBtn {
            background-color: #ffc107;
        }

        asp:Button#ResetPassBtn:hover {
            background-color: #e0a800;
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
