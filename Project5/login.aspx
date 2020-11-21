<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Project5.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       p.staffLogin {
           line-height: 2.0;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div text-align: left>
            Staff Login Page
            <br />
            <p class="staffLogin">
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <asp:Label ID="lbl_Login" runat="server" Text="Log In"></asp:Label>
                <br />
                <asp:Label ID="lbl_username" runat="server" Text="Username: "></asp:Label> &nbsp
                <asp:TextBox ID="txt_username" runat="server" Width="240px" BorderColor="Black" BorderWidth="1px" style="margin-left: 6px"></asp:TextBox>
                <br />
                <asp:Label ID="lbl_password" runat="server" Text="Password: "></asp:Label> &nbsp
                <asp:TextBox ID="txt_password" runat="server" Width="241px" BorderColor="Black" BorderWidth="1px" style="margin-left: 8px"></asp:TextBox>
                <br />
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                <asp:Button ID="bttn_Login" runat="server" Text="Log In" OnClick="bttn_Login_Click" />
                <br />
            </p>
        </div>
        <asp:Label ID="lbl_errors" runat="server" BorderColor="White" BorderWidth="4px"></asp:Label>
    </form>
</body>
</html>