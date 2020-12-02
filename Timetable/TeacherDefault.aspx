<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherDefault.aspx.cs" Inherits="Timetable.TeacherDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 312px" Text="Hello, <teacher>"></asp:Label>
        <br/>
        <br/>
        <br/>
        <a href="TeacherLogin.aspx">
            <asp:Label ID="lblContact" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; width: 120px" Text='View timetable' Font-Underline="True" />
        </a>
        <br/>
        <a href="TeacherLogin.aspx">
            <asp:Label ID="lblTeacherAccounts" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; width: 120px" Text='Contact messages' Font-Underline="True" />
        </a>
        <br/>
    </form>
</body>
</html>
