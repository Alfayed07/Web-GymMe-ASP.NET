<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplicationFront1.View.LoginPage" %>

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
            <h1>Login Page</h1><br/>
            
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
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TB_Password" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
            <asp:CheckBox ID="CheckBox" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Remember me"></asp:Label>
           <div>
               <asp:Label ID="Label_message" runat="server" Text="" ForeColor="Red"></asp:Label>
           </div>
            <div>
                 <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
            </div>
        </div>
    </form>
</body>
</html>