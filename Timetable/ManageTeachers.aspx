<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageTeachers.aspx.cs" Inherits="Timetable.ManageTeachers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 315px;
            position: absolute;
            width: 140px;
        }
        .auto-style2 {
            z-index: 1;
            left: 238px;
            top: 350px;
            position: absolute;
        }
        .auto-style3 {
            position: absolute;
            top: 350px;
            left: 125px;
            z-index: 1;
            width: 102px;
            right: 969px;
        }
        .auto-style4 {
            z-index: 1;
            left: 13px;
            top: 350px;
            position: absolute;
            width: 102px;
        }
        .auto-style5 {
            position: absolute;
            top: 418px;
            left: 101px;
            z-index: 1;
            width: 124px;
        }
        .auto-style6 {
            z-index: 1;
            left: 358px;
            top: 418px;
            position: absolute;
        }
        .auto-style7 {
            position: absolute;
            top: 418px;
            left: 234px;
            z-index: 1;
            width: 112px;
        }
        .auto-style8 {
            z-index: 1;
            left: 14px;
            top: 418px;
            position: absolute;
            right: 1145px;
        }
        .auto-style9 {
            z-index: 1;
            left: 497px;
            top: 37px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 57px;
            top: 418px;
            position: absolute;
        }
        .auto-style11 {
            position: absolute;
            top: 392px;
            left: 10px;
            z-index: 1;
        }
        .auto-style12 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 377px;
            left: 10px;
            z-index: 1;
            color: black;
            background-color: black;
        }
        .auto-style13 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 453px;
            left: 10px;
            z-index: 1;
            color: black;
            background-color: black;
        }
        .auto-style14 {
            position: absolute;
            top: 475px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 145px" Text="Default"></asp:Label>
        <asp:ListBox ID="lstTeachers" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 249px; width: 471px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" MaxLength="100" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 292px; position: absolute" Text="Search Names or EMails"></asp:Label>
        <asp:Button ID="btnSearchNames" runat="server" Text="Search Names" CssClass="auto-style4" OnClick="btnSearchNames_Click"/>
        <asp:Button ID="btnClearFilter" runat="server" Text="Show All" CssClass="auto-style2" OnClick="btnClearFilter_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="auto-style8" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" CssClass="auto-style10" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="auto-style6" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style9"></asp:Label>
        <asp:Button ID="btnSearchEMails" runat="server" CssClass="auto-style3" Text="Search EMails" OnClick="btnSearchEMails_Click" />
        <asp:Button ID="btnTimetable" runat="server" CssClass="auto-style5" OnClick="btnTimetable_Click" Text="Manage Timetable" />
        <asp:Button ID="btnMessages" runat="server" CssClass="auto-style7" Text="View Messages" OnClick="btnMessages_Click" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style11" Text="Manage Selected User"></asp:Label>
    <hr class="auto-style12" />
    <hr class="auto-style13" />
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style14" OnClick="btnBack_Click" Text="Back" />
    </form>
    </body>
</html>
