<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="WebApplicationFront1.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <asp:Button ID="btn_to_login" runat="server" Text="Login" OnClick="btn_to_login_Click" />
                <asp:Button ID="btn_to_logout" runat="server" Text="Register" OnClick="btn_to_register_Click" />
            </nav>
            <h1>Register Page</h1><br />
            <div>
                <div>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_Username" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <div>
                   <div>
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_Email" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <div>
                   <div>
                        <asp:Label ID="Label3" runat="server" Text="Gender (Male/Female)"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_Gender" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <div>
                   <div>
                        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_Password" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <div>
                   <div>
                        <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_Password_confirm" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <div>
                   <div>
                        <asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_DOB" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div>
                <asp:Label ID="Label_message" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
            <div>
                <asp:Button ID="btn_register" runat="server" Text="Register" OnClick="btn_register_Click" />
            </div>
        </div>
    </form>
</body>
</html>
