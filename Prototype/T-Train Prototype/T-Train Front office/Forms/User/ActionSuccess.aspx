<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ActionSuccess.aspx.vb" Inherits="T_Train_Front_office.ActionSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 535px; top: 26px; position: absolute" Text="Staff Dashboard" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 695px; top: 25px; position: absolute; " Text="My tickets" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 810px; top: 27px; position: absolute" Text="Account settings" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 357px; top: 367px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 198px; top: 142px; position: absolute" Text="Your ticket has been refunded. You should expect an email with the details of the procedure soon."></asp:Label>
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 310px; top: 177px; position: absolute" Text="Back to Homepage" />
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 504px; top: 177px; position: absolute" Text="Back to My tickets" />
    </form>
</body>
</html>
