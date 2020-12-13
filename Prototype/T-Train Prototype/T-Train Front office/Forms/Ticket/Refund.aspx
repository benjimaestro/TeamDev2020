<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Refund.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.Refund" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 469px; top: 21px; position: absolute; right: 378px;" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 617px; top: 21px; position: absolute; right: 275px;" Text="My tickets" OnClick="btnTickets_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 721px; top: 20px; position: absolute" Text="Account settings" OnClick="btnSettings_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 174px; top: 15px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 362px; top: 447px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 217px; top: 323px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 444px; top: 325px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 623px; top: 325px; position: absolute" Text="14:25"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 352px; top: 158px; position: absolute; height: 113px; width: 283px" Text="Are you sure that you want to refund the ticket? It may take up to 2 weeks for the refund to be processed. During this time you will be unable to book the same ticket again."></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 134px; top: 271px; position: absolute" Text="Ticket to be refunded:"></asp:Label>
        <asp:Button ID="btnRefund" runat="server" style="z-index: 1; left: 282px; top: 380px; position: absolute" Text="Confirm refund (!)" OnClick="btnRefund_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 559px; top: 381px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="Label21" runat="server" Font-Size="X-Large" style="z-index: 1; left: 365px; top: 113px; position: absolute" Text="Ticket refund procedure"></asp:Label>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 883px; top: 20px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
    </form>
</body>
</html>
