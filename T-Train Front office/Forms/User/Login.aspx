<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 348px; top: 455px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        </div>
        <p>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 856px; top: 36px; position: absolute" Text="Signup" OnClick="Button5_Click" />
        </p>
        <p>
            <asp:Button ID="btnSignup2" runat="server" style="z-index: 1; left: 489px; top: 396px; position: absolute" Text="Signup" OnClick="btnSignup2_Click" />
        </p>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        </p>
        <asp:Label ID="lblAccCreated" runat="server" style="z-index: 1; left: 276px; top: 161px; position: absolute" Text="Your account is now live! Use the form below to login." Font-Bold="True" Font-Size="Large" ForeColor="#00CC00" Visible="False"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 395px; top: 226px; position: absolute; height: 19px; right: 529px;" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 469px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 381px; top: 266px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 468px; top: 267px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 449px; top: 316px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnResetPassword" runat="server" style="z-index: 1; left: 403px; top: 353px; position: absolute" Text="Lost password?" OnClick="btnResetPassword_Click" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 351px; top: 402px; position: absolute; right: 493px;" Text="Not yet registered?"></asp:Label>
        <p>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 392px; top: 118px; position: absolute" Text="Login to your account now"></asp:Label>
        </p>
    </form>
</body>
</html>
