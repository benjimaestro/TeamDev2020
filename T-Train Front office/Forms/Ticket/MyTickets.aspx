<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTickets.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.MyTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 508px; top: 25px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 350px; top: 501px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 660px; top: 24px; position: absolute" Text="Account settings" OnClick="btnSettings_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 188px; top: 17px; position: absolute" Text="T-Train"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 824px; top: 24px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblNoTickets" runat="server" style="z-index: 1; left: 233px; top: 155px; position: absolute" Text="You have not purchased any tickets yet." Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        <asp:Label ID="lblStaticFind" runat="server" style="z-index: 1; left: 262px; top: 197px; position: absolute; right: 549px;" Text="Find connections:" Visible="False"></asp:Label>
        <asp:Button ID="btnConnections2" runat="server" style="z-index: 1; left: 566px; top: 455px; position: absolute" Text="All connections" OnClick="btnConnections2_Click" Visible="False" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblAnother" runat="server" style="z-index: 1; left: 220px; top: 457px; position: absolute" Text="Need to book another ticket? Find connections here:" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 391px; top: 196px; position: absolute" Text="All connections" OnClick="btnConnections_Click" Visible="False" />
        <asp:ListBox ID="lstTickets" runat="server" style="z-index: 1; left: 179px; top: 246px; position: absolute; height: 182px; width: 558px" Visible="False"></asp:ListBox>
        <asp:Label ID="lblTicketSelected" runat="server" style="z-index: 1; left: 627px; top: 198px; position: absolute" Text="You have to select a ticket first." Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Label ID="lblStaticYourTickets" runat="server" style="z-index: 1; left: 102px; top: 212px; position: absolute" Text="Your tickets:" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
