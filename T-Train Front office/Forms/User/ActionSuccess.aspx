<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActionSuccess.aspx.cs" Inherits="T_Train_Front_office.Forms.User.ActionSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="lblPaymentSuccess" runat="server" style="z-index: 1; left: 198px; top: 173px; position: absolute" Text="Your purchase was succesful. You can view your tickets by pressing My tickets button anytime." Visible="False"></asp:Label>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 32px; top: 71px; position: absolute" Text="Staff Dashboard" OnClick="Button10_Click" Visible="False" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnMyTickets" runat="server" style="z-index: 1; left: 569px; top: 29px; position: absolute; height: 26px;" Text="My Tickets" OnClick="Button2_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 682px; top: 29px; position: absolute" Text="Account Settings" OnClick="Button3_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 193px; top: 29px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 400px; top: 340px; position: absolute; right: 314px;" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 198px; top: 142px; position: absolute" Text="Your ticket has been refunded. You should expect an email with the details of the procedure soon." Visible="False"></asp:Label>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 847px; top: 29px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
            <asp:Label ID="lblPaymentFailure" runat="server" style="z-index: 1; left: 198px; top: 198px; position: absolute" Text="Sorry, your payment could not be completed. Try again and if this continues, contact us directly." Visible="False"></asp:Label>
            <asp:Label ID="lblStaticAddSuccess" runat="server" style="z-index: 1; left: 342px; top: 220px; position: absolute" Text="Success! New connection/ticket type has been added." Visible="False"></asp:Label>
        </p>
        <asp:Label ID="lblStaticModSuccess" runat="server" style="z-index: 1; left: 342px; top: 245px; position: absolute" Text="Success! The connection/ticket type has been modified." Visible="False"></asp:Label>
        <asp:Label ID="lblStaticDelSuccess" runat="server" style="z-index: 1; left: 342px; top: 268px; position: absolute" Text="Success! The connection/ticket type has been deleted." Visible="False"></asp:Label>
        <asp:Label ID="lblStaticTicketCancelled" runat="server" style="z-index: 1; left: 391px; top: 298px; position: absolute" Text="Success! The ticket has been cancelled." Visible="False"></asp:Label>
    </form>
</body>
</html>
