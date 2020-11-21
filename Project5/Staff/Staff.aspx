<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project5.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff Page</div>
        <asp:Button ID="homePageButton" runat="server" OnClick="homePageButton_Click" Text="Home Page" />
        <br />
        <br />
        <asp:Label ID="lbl_staffEntry" runat="server" Font-Bold="True" Text="Add New Staff Entry:"></asp:Label>
        <br />
        <asp:Label ID="lbl_Username" runat="server" Text="Username:"></asp:Label>
        &nbsp
        <asp:TextBox ID="txt_Username" runat="server" Width="204px"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Password" runat="server" Text="Password:"></asp:Label>
        &nbsp
        <asp:TextBox ID="TextBox1" runat="server" Width="204px"></asp:TextBox>
        <br />
        &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
        <asp:Button ID="bttn_AddStaff" runat="server" Text="Add" />
    </form>
</body>
</html>
