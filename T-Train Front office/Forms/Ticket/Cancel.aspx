<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancel.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.Cancel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 37px; top: 57px; position: absolute; " Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 37px; top: 26px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        </p>
        <div>
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 212px; top: 26px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 363px; top: 389px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 160px; top: 174px; position: absolute" Text="Ticket to be cancelled:" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblConnLocation" runat="server" style="z-index: 1; left: 216px; top: 274px; position: absolute"></asp:Label>
        <asp:Label ID="lblConnDate" runat="server" style="z-index: 1; left: 418px; top: 274px; position: absolute"></asp:Label>
        <asp:Label ID="lblConnTime" runat="server" style="z-index: 1; left: 618px; top: 274px; position: absolute"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 521px; top: 333px; position: absolute" Text="Back to Customer" OnClick="btnCustomer2_Click" Visible="False" />
        <asp:Label ID="Label21" runat="server" Font-Size="X-Large" style="z-index: 1; left: 365px; top: 113px; position: absolute" Text="Cancel ticket procedure"></asp:Label>
        </p>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 216px; top: 235px; position: absolute"></asp:Label>
        <asp:Label ID="lblPurchasedAt" runat="server" style="z-index: 1; left: 509px; top: 235px; position: absolute"></asp:Label>
        <p>
        <asp:Button ID="btnCancelTicket" runat="server" style="z-index: 1; left: 284px; top: 333px; position: absolute" Text="Cancel Ticket (!)" OnClick="btnCancelTicket_Click" Visible="False" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 848px; top: 26px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <asp:Label ID="lblCustNotFound" runat="server" style="z-index: 1; left: 61px; top: 236px; position: absolute" Font-Bold="True" ForeColor="Red" Visible="False">Customer not found.</asp:Label>
        <asp:Label ID="lblConnNotFound" runat="server" style="z-index: 1; left: 59px; top: 274px; position: absolute" Font-Bold="True" ForeColor="Red" Visible="False">Connection not found.</asp:Label>
        <asp:Label ID="lblTicketNotFound" runat="server" style="z-index: 1; left: 427px; top: 174px; position: absolute" Font-Bold="True" ForeColor="Red" Visible="False">Ticket not found.</asp:Label>
        </p>
    </form>
</body>
</html>
