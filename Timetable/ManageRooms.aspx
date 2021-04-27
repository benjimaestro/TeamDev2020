<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageRooms.aspx.cs" Inherits="Timetable.ManageRooms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Rooms</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 342px;
            left: 10px;
            z-index: 1;
            width: 152px;
            height: 34px;
        }
        .auto-style2 {
            position: absolute;
            top: 477px;
            left: 15px;
            z-index: 1;
        }
        .auto-style3 {
            z-index: 1;
            left: 505px;
            top: 61px;
            position: absolute;
            width: 457px;
            height: 236px;
        }
        .auto-style4 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 374px;
            left: 10px;
            z-index: 1;
            background-color: black;
            color: black;
        }
        .auto-style5 {
            position: absolute;
            top: 392px;
            left: 10px;
            z-index: 1;
            width: 195px;
        }
        .auto-style6 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 451px;
            left: 10px;
            z-index: 1;
            background-color: black;
            color: black;
        }
        .auto-style7 {
            z-index: 1;
            left: 14px;
            top: 418px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 57px;
            top: 418px;
            position: absolute;
            right: 1094px;
        }
        .auto-style9 {
            z-index: 1;
            left: 105px;
            top: 418px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 13px;
            top: 312px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 10px;
            top: 54px;
            position: absolute;
            height: 249px;
            width: 471px;
        }
        .auto-style12 {
            z-index: 1;
            left: 10px;
            top: 12px;
            position: absolute;
            height: 42px;
            width: 499px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="Manage Rooms" CssClass="auto-style12"></asp:Label>
        <asp:ListBox ID="lstRooms" runat="server" CssClass="auto-style11" OnSelectedIndexChanged="lstRooms_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" Text="Filter Rooms by Subject" CssClass="auto-style10"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="auto-style7" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" CssClass="auto-style8" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="auto-style9" ForeColor="Red" />
        <asp:DropDownList ID="ddlSubjectSearch" runat="server" AutoPostBack="true" CssClass="auto-style1" OnSelectedIndexChanged="ddlSubjectSearch_SelectedIndexChanged"></asp:DropDownList>
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style2" OnClick="btnBack_Click" Text="Back" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style3"></asp:Label>
    <hr class="auto-style4" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="Manage Rooms"></asp:Label>
    </form>
    <hr class="auto-style6" />
</body>
</html>
