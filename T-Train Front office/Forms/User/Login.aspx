﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 348px; top: 450px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        </div>
        <p>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
        </p>
        <p>
            <asp:Button ID="btnSignup2" runat="server" style="z-index: 1; left: 497px; top: 399px; position: absolute" Text="Register" OnClick="btnSignup2_Click" />
        </p>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        </p>
        <asp:Label ID="lblAccCreated" runat="server" style="z-index: 1; left: 276px; top: 161px; position: absolute" Text="Your account is now live! Use the form below to login." Font-Bold="True" Font-Size="Large" ForeColor="#00CC00" Visible="False"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 381px; top: 226px; position: absolute; height: 19px; right: 549px;" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 468px; top: 226px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 381px; top: 266px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 468px; top: 266px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 457px; top: 313px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnResetPassword" runat="server" style="z-index: 1; left: 403px; top: 353px; position: absolute" Text="Forgot Password?" OnClick="btnResetPassword_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 324px; top: 192px; position: absolute; right: 487px;" Font-Bold="True" ForeColor="Red"></asp:Label>
        <p>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 392px; top: 118px; position: absolute" Text="Login to your account now"></asp:Label>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 363px; top: 399px; position: absolute; right: 501px;" Text="Not yet registered?"></asp:Label>
        </p>
    </form>
</body>
</html>
