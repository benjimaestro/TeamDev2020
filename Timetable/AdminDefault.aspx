<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDefault.aspx.cs" Inherits="Timetable.AdminDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 312px" Text="Admin Page"></asp:Label>
        <br/>
        <br/>
        <br/>
        <a href="TeacherLogin.aspx">
            <asp:Label ID="lblContact" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; width: 120px" Text='Contact messages' Font-Underline="True" />
        </a>
        <br/>
        <a href="TeacherLogin.aspx">
            <asp:Label ID="lblTeacherAccounts" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; width: 120px" Text='Manage teacher accounts' Font-Underline="True" />
        </a>
        <br/>
        <a href="TeacherLogin.aspx">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; width: 120px" Text='Manage rooms' Font-Underline="True" />
        </a>
    </form>
</body>
</html>
