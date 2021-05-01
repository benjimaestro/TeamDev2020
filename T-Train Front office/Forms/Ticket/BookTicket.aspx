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
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 217px; top: 29px; position: absolute" Text="T-Train"></asp:Label>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 32px; top: 67px; position: absolute; right: 764px;" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
            <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 690px; top: 29px; position: absolute; right: 97px" Text="Account Settings" OnClick="btnSettings_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 584px; top: 29px; position: absolute" Text="My Tickets" OnClick="btnTickets_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 849px; top: 29px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 382px; top: 405px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="lblConnLoc" runat="server" style="z-index: 1; left: 115px; top: 200px; position: absolute; right: 793px;"></asp:Label>
        <asp:Label ID="lblConnTime" runat="server" style="z-index: 1; left: 554px; top: 200px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 32px; top: 147px; position: absolute" Text="You are booking a ticket for this connection:" Font-Bold="True"></asp:Label>
        <asp:Button ID="btnPayment" runat="server" style="z-index: 1; left: 303px; top: 347px; position: absolute" Text="Make Payment" OnClick="btnPayment_Click1" />
        <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 536px; top: 347px; position: absolute" Text="Back to Connections" />
        <p>
        <asp:Label ID="lblConnPrice" runat="server" style="z-index: 1; left: 696px; top: 200px; position: absolute"></asp:Label>
        <asp:Label ID="lblStaticInstructions" runat="server" style="z-index: 1; left: 217px; top: 250px; position: absolute; height: 67px; width: 539px;" Font-Bold="True">Once you press Make Payment, a new window will open where you complete the payment. Once you finish, the ticket will be added to your account. If you abandon the payment, the ticket will not be added.</asp:Label>
        </p>
        <p>
        <asp:Label ID="lblConnDate" runat="server" style="z-index: 1; left: 399px; top: 200px; position: absolute; "></asp:Label>
        </p>
    </form>
</body>
</html>
