<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplicationFront1.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        form {
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
        }

        h1 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
        }

        nav {
            display: flex;
            justify-content: space-between;
            margin-bottom: 20px;
        }

        nav asp:Button {
            background-color: #007BFF;
            color: white;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            width: 48%;
        }

        nav asp:Button:hover {
            background-color: #0056b3;
        }

        div {
            margin-bottom: 10px;
        }

        label, asp:Label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        asp:TextBox {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        asp:CheckBox {
            margin-right: 5px;
        }

        asp:Button {
            background-color: #28a745;
            color: white;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            width: 100%;
            margin-top: 10px;
        }

        asp:Button:hover {
            background-color: #218838;
        }

        asp:Label[ForeColor="Red"] {
            color: red;
            font-size: 12px;
        }
    </style>
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
