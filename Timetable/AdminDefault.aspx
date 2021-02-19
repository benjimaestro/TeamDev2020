﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDefault.aspx.cs" Inherits="Timetable.AdminDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 90px;
            position: absolute;
            width: 248px;
        }
        .auto-style2 {
            z-index: 1;
            left: 10px;
            top: 120px;
            position: absolute;
            width: 120px;
        }
        .auto-style3 {
            z-index: 1;
            left: 10px;
            top: 34px;
            position: absolute;
            height: 42px;
            width: 1152px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="Admin Page" CssClass="auto-style3"></asp:Label>
        <br/>
        <br/>
        <br/>
        <br/>
        <a href="ManageTeachers.aspx">
            <asp:Label ID="lblTeacherAccounts" runat="server" Text='Manage teacher accounts' Font-Underline="True" CssClass="auto-style1" />
        </a>
        <br/>
        <a href="ManageRooms.aspx">
            <asp:Label ID="Label1" runat="server" Text='Manage rooms' Font-Underline="True" CssClass="auto-style2" />
        </a>
    </form>
</body>
</html>
