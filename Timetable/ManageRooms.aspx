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
        .auto-style2 {
            position: absolute;
            top: 437px;
            left: 15px;
            z-index: 1;
        }
        .auto-style3 {
            z-index: 1;
            left: 505px;
            top: 41px;
            position: absolute;
        }
        .auto-style4 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 350px;
            left: 10px;
            z-index: 1;
            background-color: black;
            color: black;
        }
        .auto-style5 {
            position: absolute;
            top: 362px;
            left: 10px;
            z-index: 1;
            width: 195px;
        }
        .auto-style6 {
            width: 467px;
            height: 1px;
            position: absolute;
            top: 417px;
            left: 10px;
            z-index: 1;
            background-color: black;
            color: black;
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
        <asp:DropDownList ID="ddlSubjectSearch" runat="server" AutoPostBack="true" CssClass="auto-style1" OnSelectedIndexChanged="ddlSubjectSearch_SelectedIndexChanged"></asp:DropDownList>
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style2" OnClick="btnBack_Click" Text="Back" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style3"></asp:Label>
    <hr class="auto-style4" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="Manage Room"></asp:Label>
    </form>
    <hr class="auto-style6" />
</body>
</html>
