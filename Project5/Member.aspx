<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project5.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Member Page"></asp:Label>
        <div>
            <asp:Button ID="homePageButton" runat="server" OnClick="homePageButton_Click" Text="Home Page" />
        </div>
    </form>
</body>
</html>
