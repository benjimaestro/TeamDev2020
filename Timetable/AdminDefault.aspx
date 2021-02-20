<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDefault.aspx.cs" Inherits="Timetable.AdminDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style3 {
            z-index: 1;
            left: 10px;
            top: 34px;
            position: absolute;
            height: 42px;
            width: 1152px;
        }
        .auto-style4 {
            position: absolute;
            top: 185px;
            left: 10px;
            z-index: 1;
            width: 175px;
        }
        .auto-style5 {
            position: absolute;
            top: 87px;
            left: 10px;
            z-index: 1;
            width: 175px;
        }
        .auto-style6 {
            position: absolute;
            top: 137px;
            left: 10px;
            z-index: 1;
            width: 175px;
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
        <asp:Button ID="btnTeachers" runat="server" CssClass="auto-style5" OnClick="btnTeachers_Click" Text="Manage Accounts" />
        <br/>
        <asp:Button ID="btnLogout" runat="server" CssClass="auto-style4" OnClick="btnLogout_Click" Text="Log Out" />
        <asp:Button ID="btnRooms" runat="server" CssClass="auto-style6" OnClick="btnRooms_Click" Text="Manage Rooms" />
    </form>
</body>
</html>
