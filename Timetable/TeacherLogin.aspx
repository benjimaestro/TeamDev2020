<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherLogin.aspx.cs" Inherits="Timetable.TeacherLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 312px" Text="Teacher Login"></asp:Label>
        <br/>
        <br/>
        <br/>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 156px; top: 90px; position: absolute; width: 256px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 156px; top: 120px; position: absolute; width: 256px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute; width: 120px" Text="EMail:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute; width: 120px" Text="Password:"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 156px; top: 150px; position: absolute; width: 256px;" Text="Log in" />
        <a href="AdminLogin.aspx">
            <asp:Label ID="lblHyperlink" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; width: 120px" Text='Admin login' Font-Underline="True" />
        </a>
    </form>
</body>
</html>
