<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="memberPageButton" runat="server" OnClick="memberPageButton_Click" Text="Member Page" />
        <asp:Button ID="staffPageButton" runat="server" OnClick="Button2_Click" Text="Staff Page" />
        <asp:Label ID="lbl_currentTime" runat="server"></asp:Label>
        <div>
            <h1>Smart Home Application</h1>
        </div>
        <div>
            <ul>
                <li>Weather Service</li>
                <li>Youtube Search App</li>
                <li>Closest Store Service</li>
            </ul>
        </div>
        <div>
            <h2>Weather Service</h2>
            <p>This service returns the weather of a given zip code by the user.</p>
            <h2>Youtube Search</h2>
            <p>This service allows users to search key words, the output is the top result from Youtube: The thumbnail of the video and title.</p>
            <h2>Closest Store</h2>
            <p>This service returns the closest grocer given a zip code by the user.</p>
        </div>
        <div>
            <p>To Access these services, please log in by clicking the "Member" button on the top left of the screen. If you do not have an account, you may click on this button to create an account as well.</p>
        </div>
    </form>
</body>
</html>
