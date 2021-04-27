<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTickets.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.MyTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 31px; top: 56px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" Visible="False" />
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 361px; top: 432px; position: absolute; right: 408px;" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 642px; top: 21px; position: absolute" Text="Account Settings" OnClick="btnSettings_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 188px; top: 21px; position: absolute" Text="T-Train"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 829px; top: 21px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblNoTickets" runat="server" style="z-index: 1; left: 203px; top: 176px; position: absolute" Text="You have not purchased any tickets yet." Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        <asp:Label ID="lblStaticFind" runat="server" style="z-index: 1; left: 237px; top: 213px; position: absolute; right: 643px;" Text="Find connections:" Visible="False"></asp:Label>
        <asp:Button ID="btnConnections2" runat="server" style="z-index: 1; left: 587px; top: 380px; position: absolute; right: 265px;" Text="All Connections" OnClick="btnConnections_Click" Visible="False" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblAnother" runat="server" style="z-index: 1; left: 178px; top: 380px; position: absolute" Text="Need to book another ticket? Find connections here:" Visible="False" Font-Size="Large"></asp:Label>
        <p>
            <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 374px; top: 213px; position: absolute; right: 478px;" Text="All Connections" OnClick="btnConnections_Click" Visible="False" />
        <asp:ListBox ID="lstTickets" runat="server" style="z-index: 0; left: 176px; top: 169px; position: absolute; height: 182px; width: 558px" Visible="False"></asp:ListBox>
        <asp:Label ID="lblStaticYourTickets" runat="server" style="z-index: 1; left: 111px; top: 121px; position: absolute" Text="Your tickets:" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
