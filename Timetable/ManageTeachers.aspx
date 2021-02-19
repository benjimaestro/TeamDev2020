<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageTeachers.aspx.cs" Inherits="Timetable.ManageTeachers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Teachers</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 80px;
            position: absolute;
            width: 140px;
        }
        .auto-style2 {
            z-index: 1;
            left: 393px;
            top: 78px;
            position: absolute;
        }
        .auto-style3 {
            position: absolute;
            top: 78px;
            left: 281px;
            z-index: 1;
            width: 102px;
            right: 805px;
        }
        .auto-style4 {
            z-index: 1;
            left: 169px;
            top: 78px;
            position: absolute;
            width: 102px;
            right: 917px;
        }
        .auto-style5 {
            position: absolute;
            top: 447px;
            left: 12px;
            z-index: 1;
            width: 124px;
        }
        .auto-style6 {
            z-index: 1;
            left: 374px;
            top: 446px;
            position: absolute;
        }
        .auto-style7 {
            position: absolute;
            top: 446px;
            left: 148px;
            z-index: 1;
            width: 112px;
        }
        .auto-style8 {
            z-index: 1;
            left: 14px;
            top: 377px;
            position: absolute;
            right: 979px;
        }
        .auto-style9 {
            z-index: 1;
            left: 497px;
            top: 117px;
            position: absolute;
            width: 478px;
            height: 246px;
        }
        .auto-style10 {
            z-index: 1;
            left: 274px;
            top: 446px;
            position: absolute;
            width: 87px;
        }
        .auto-style11 {
            position: absolute;
            top: 420px;
            left: 10px;
            z-index: 1;
        }
        .auto-style12 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 405px;
            left: 10px;
            z-index: 1;
            color: black;
            background-color: black;
        }
        .auto-style19 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 38px;
            left: 10px;
            z-index: 1;
            color: black;
            background-color: black;
        }
        .auto-style13 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 490px;
            left: 10px;
            z-index: 1;
            color: black;
            background-color: black;
        }
        .auto-style14 {
            position: absolute;
            top: 513px;
            left: 15px;
            z-index: 1;
        }
        .auto-style15 {
            z-index: 1;
            left: 13px;
            top: 57px;
            position: absolute;
        }
        .auto-style16 {
            z-index: 1;
            left: 10px;
            top: 114px;
            position: absolute;
            height: 249px;
            width: 471px;
        }
        .auto-style17 {
            z-index: 1;
            left: 10px;
            top: 4px;
            position: absolute;
            height: 42px;
            width: 488px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="Manage Users" CssClass="auto-style17"></asp:Label>
        <hr class="auto-style19" />
        <asp:ListBox ID="lstTeachers" runat="server" CssClass="auto-style16"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" MaxLength="100" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Search Names or EMails" CssClass="auto-style15"></asp:Label>
        <asp:Button ID="btnSearchNames" runat="server" Text="Search Names" CssClass="auto-style4" OnClick="btnSearchNames_Click"/>
        <asp:Button ID="btnClearFilter" runat="server" Text="Show All" CssClass="auto-style2" OnClick="btnClearFilter_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add New User" OnClick="btnAdd_Click" CssClass="auto-style8" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit Details" OnClick="btnEdit_Click" CssClass="auto-style10" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete User" OnClick="btnDelete_Click" CssClass="auto-style6" ForeColor="Red" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style9"></asp:Label>
        <asp:Button ID="btnSearchEMails" runat="server" CssClass="auto-style3" Text="Search EMails" OnClick="btnSearchEMails_Click" />
        <asp:Button ID="btnTimetable" runat="server" CssClass="auto-style5" OnClick="btnTimetable_Click" Text="Manage Timetable" />
        <asp:Button ID="btnMessages" runat="server" CssClass="auto-style7" Text="View Messages" OnClick="btnMessages_Click" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style11" Text="Manage Selected User"></asp:Label>
        <br/>
        <hr class="auto-style12" />
        <hr class="auto-style13" />
        <br/>
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style14" OnClick="btnBack_Click" Text="Back" />
    </form>
    </body>
</html>
