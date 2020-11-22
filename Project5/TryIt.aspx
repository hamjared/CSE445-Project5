<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="Project5.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        p.tryItPage {
            line-height: 2.5;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="tryItPage">
            <asp:Label ID="lbl_title" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Encryption/Decryption TryIt Page"></asp:Label>
            <br />
            <asp:Label ID="lbl_instruction1" runat="server" Text="Enter a string to encrypt:"></asp:Label>
            &nbsp
            <asp:TextBox ID="txt_encrypt" runat="server"></asp:TextBox>
            &nbsp
            <asp:Button ID="bttn_encrypt" runat="server" Text="Encrypt" OnClick="bttn_encrypt_Click" />
            &nbsp
            <asp:Label ID="lbl_encryptResults" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbl_instruction2" runat="server" Text="Enter a string to decrypt:"></asp:Label>
            &nbsp
            <asp:TextBox ID="txt_decrypt" runat="server"></asp:TextBox>
            &nbsp
            <asp:Button ID="bttn_decrypt" runat="server" Text="Decrypt" OnClick="bttn_decrypt_Click" />
            &nbsp
            <asp:Label ID="lbl_decryptResults" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
