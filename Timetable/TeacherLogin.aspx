﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherLogin.aspx.cs" Inherits="Timetable.TeacherLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Timetable Login</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 34px;
            position: absolute;
            height: 42px;
            width: 312px;
        }
        .auto-style2 {
            position: absolute;
            top: 224px;
            left: 156px;
            z-index: 1;
            width: 261px;
            height: 92px;
        }
        .auto-style3 {
            position: absolute;
            top: 179px;
            left: 156px;
            z-index: 1;
            width: 266px;
        }
        .auto-style4 {
            z-index: 1;
            left: 156px;
            top: 90px;
            position: absolute;
            width: 256px;
            bottom: 574px;
        }
        .auto-style5 {
            z-index: 1;
            left: 156px;
            top: 120px;
            position: absolute;
            width: 256px;
            height: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="Login" CssClass="auto-style1"></asp:Label>
        <br/>
        <br/>
        <br/>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style4" Height="21px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style5"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute; width: 120px" Text="Email:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute; width: 120px" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 156px; top: 150px; position: absolute; width: 266px;" Text="Log in" OnClick="btnLogin_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style2"></asp:Label>
        <asp:Button ID="btnForgotPassword" runat="server" CssClass="auto-style3" OnClick="btnForgotPassword_Click" Text="Forgot Password" />
    </form>
</body>
</html>
