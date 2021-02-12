<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTicket.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.BookTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 184px; top: 24px; position: absolute" Text="T-Train"></asp:Label>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 333px; top: 28px; position: absolute; right: 514px;" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
            <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 493px; top: 29px; position: absolute; right: 342px" Text="Account Settings" OnClick="btnSettings_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 661px; top: 28px; position: absolute" Text="My tickets" OnClick="btnTickets_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 771px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 355px; top: 396px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 110px; top: 247px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 303px; top: 247px; position: absolute; right: 770px;" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 420px; top: 247px; position: absolute" Text="14:25"></asp:Label>
        </p>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 34px; top: 187px; position: absolute" Text="You are booking a ticket for this connection:"></asp:Label>
        <asp:Button ID="btnPayment" runat="server" style="z-index: 1; left: 266px; top: 317px; position: absolute" Text="Make Payment" OnClick="btnPayment_Click1" />
        <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 452px; top: 317px; position: absolute" Text="Back to Connections" />
    </form>
</body>
</html>
