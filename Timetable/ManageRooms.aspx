<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageRooms.aspx.cs" Inherits="Timetable.ManageRooms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 322px;
            left: 10px;
            z-index: 1;
            width: 152px;
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 145px" Text="Default"></asp:Label>
        <asp:ListBox ID="lstRooms" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 249px; width: 471px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 292px; position: absolute" Text="Filter by subject"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 14px; top: 388px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 57px; top: 388px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 105px; top: 388px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 431px; position: absolute" ForeColor="Red"></asp:Label>
        <asp:DropDownList ID="ddlSubjectSearch" runat="server" AutoPostBack="true" CssClass="auto-style1" OnSelectedIndexChanged="ddlSubjectSearch_SelectedIndexChanged"></asp:DropDownList>
    </form>
</body>
</html>
