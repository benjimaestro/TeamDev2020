<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PromoteAdmin.aspx.cs" Inherits="Timetable.PromoteAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Teacher</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 105px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblAdmin" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute" Text="Promote (teacher)?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 60px; top: 60px; position: absolute" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
