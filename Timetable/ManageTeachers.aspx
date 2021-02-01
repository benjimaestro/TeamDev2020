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
            left: 255px;
            top: 350px;
            position: absolute;
        }
        .auto-style3 {
            position: absolute;
            top: 350px;
            left: 148px;
            z-index: 1;
            width: 102px;
        }
        .auto-style4 {
            right: 1113px;
            z-index: 1;
            left: 13px;
            top: 350px;
            position: absolute;
        }
        .auto-style5 {
            position: absolute;
            top: 388px;
            left: 101px;
            z-index: 1;
        }
        .auto-style6 {
            z-index: 1;
            left: 269px;
            top: 388px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 145px" Text="Default"></asp:Label>
        <asp:ListBox ID="lstTeachers" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 249px; width: 471px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" MaxLength="100" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 292px; position: absolute" Text="Search names or emails"></asp:Label>
        <asp:Button ID="btnSearchNames" runat="server" Text="Search Names" CssClass="auto-style4" OnClick="btnSearchNames_Click"/>
        <asp:Button ID="btnClearFilter" runat="server" Text="Show All" CssClass="auto-style2" OnClick="btnClearFilter_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 14px; top: 388px; position: absolute; right: 1292px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 57px; top: 388px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="auto-style6" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 431px; position: absolute" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnSearchEMails" runat="server" CssClass="auto-style3" Text="Search EMails" OnClick="btnSearchEMails_Click" />
        <asp:Button ID="btnTimetable" runat="server" CssClass="auto-style5" OnClick="btnTimetable_Click" Text="Manage Timetable" />
    </form>
</body>
</html>
