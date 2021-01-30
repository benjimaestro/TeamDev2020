<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherLogin.aspx.cs" Inherits="Timetable.TeacherLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 34px;
            position: absolute;
            height: 42px;
            width: 312px;
        }
        .auto-style2 {
            position: absolute;
            top: 194px;
            left: 156px;
            z-index: 1;
            width: 261px;
            height: 92px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="Login" CssClass="auto-style1"></asp:Label>
        <br/>
        <br/>
        <br/>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 156px; top: 90px; position: absolute; width: 256px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 156px; top: 120px; position: absolute; width: 256px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute; width: 120px" Text="EMail:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute; width: 120px" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 156px; top: 150px; position: absolute; width: 256px;" Text="Log in" OnClick="btnLogin_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style2"></asp:Label>
    </form>
</body>
</html>
