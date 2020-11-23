<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project5.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #0033CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1><asp:Label ID="Label1" runat="server" Text="Member Page"></asp:Label></h1>
        <div>
            <asp:Button ID="homePageButton" runat="server" OnClick="homePageButton_Click" Text="Home Page" />
            <asp:Label ID="lbl_currentTime" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_weatherTitle" runat="server" Text="5-Day Weather Forecast!" ForeColor="#0033CC"></asp:Label>
            <br />
            <asp:Label ID="lbl_weatherInstructions" runat="server" Text="Enter your Zip Code to get the weather:"></asp:Label>
            &nbsp
            <asp:TextBox ID="txt_weather" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="bttn_weather" runat="server" Text="Get Weather!" OnClick="bttn_weather_Click" />
        </div>
        <asp:Label ID="lbl_weatherResults" runat="server"></asp:Label>
   
    <div>
        <h3><span class="auto-style1">Youtube Search!</span></h3>
        <p><asp:Label ID="Label2" runat="server" Text="Enter Key Word to get Top Youtube Search Result"></asp:Label>
        :&nbsp;&nbsp;
        <asp:TextBox ID="txt_youtube" runat="server"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
            </p>
        <asp:Image ID="Image1" runat="server" Height="100px" Width="113px" />
&nbsp;&nbsp;
        <br />
        <asp:Label ID="VideoTitle" runat="server"></asp:Label>
    </div>
         </form>
</body>
</html>
