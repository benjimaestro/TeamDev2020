<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActionSuccess.aspx.cs" Inherits="T_Train_Front_office.Forms.User.ActionSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 445px; top: 26px; position: absolute" Text="Staff Dashboard" OnClick="Button10_Click" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnMyTickets" runat="server" style="z-index: 1; left: 606px; top: 25px; position: absolute; " Text="My tickets" OnClick="Button2_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 717px; top: 27px; position: absolute" Text="Account settings" OnClick="Button3_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 193px; top: 23px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 357px; top: 367px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 198px; top: 142px; position: absolute" Text="Your ticket has been refunded. You should expect an email with the details of the procedure soon."></asp:Label>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 880px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
    </form>
</body>
</html>
