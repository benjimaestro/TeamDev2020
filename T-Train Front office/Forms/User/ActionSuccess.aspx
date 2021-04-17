<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActionSuccess.aspx.cs" Inherits="T_Train_Front_office.Forms.User.ActionSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 207px; top: 183px; position: absolute" Text="Your purchase was succesful. You can view your tickets by pressing My tickets button anytime." Visible="False"></asp:Label>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 445px; top: 26px; position: absolute" Text="Staff Dashboard" OnClick="Button10_Click" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnMyTickets" runat="server" style="z-index: 1; left: 606px; top: 25px; position: absolute; " Text="My tickets" OnClick="Button2_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 717px; top: 27px; position: absolute" Text="Account settings" OnClick="Button3_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 193px; top: 23px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 393px; top: 456px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 198px; top: 142px; position: absolute" Text="Your ticket has been refunded. You should expect an email with the details of the procedure soon." Visible="False"></asp:Label>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 880px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
            <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 203px; top: 224px; position: absolute" Text="Sorry, your payment could not be completed. Try again and if this continues, contact us directly." Visible="False"></asp:Label>
            <asp:Label ID="lblStaticAddSuccess" runat="server" style="z-index: 1; left: 342px; top: 267px; position: absolute" Text="Success! New connection/ticket type has been added." Visible="False"></asp:Label>
        </p>
        <asp:Label ID="lblStaticModSuccess" runat="server" style="z-index: 1; left: 335px; top: 305px; position: absolute" Text="Success! The connection/ticket type has been modified." Visible="False"></asp:Label>
        <asp:Label ID="lblStaticDelSuccess" runat="server" style="z-index: 1; left: 341px; top: 339px; position: absolute" Text="Success! The connection/ticket type has been deleted." Visible="False"></asp:Label>
        <asp:Label ID="lblStaticTicketCancelled" runat="server" style="z-index: 1; left: 386px; top: 378px; position: absolute" Text="Success! The ticket has been cancelled." Visible="False"></asp:Label>
    </form>
</body>
</html>
