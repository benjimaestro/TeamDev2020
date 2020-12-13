<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancel.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.Cancel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 723px; top: 22px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 547px; top: 21px; position: absolute; " Text="Back to Customer" OnClick="btnCustomer_Click" />
        </p>
        <div>
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 206px; top: 14px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 362px; top: 447px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 160px; top: 174px; position: absolute" Text="Ticket to be cancelled:"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 217px; top: 264px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 440px; top: 267px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 618px; top: 267px; position: absolute" Text="14:25"></asp:Label>
        <asp:Button ID="btnCustomer2" runat="server" style="z-index: 1; left: 470px; top: 333px; position: absolute" Text="Back to Customer" OnClick="btnCustomer2_Click" />
        <asp:Label ID="Label21" runat="server" Font-Size="X-Large" style="z-index: 1; left: 365px; top: 113px; position: absolute" Text="Cancel ticket procedure"></asp:Label>
        </p>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 216px; top: 235px; position: absolute" Text="Kent Smith"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 458px; top: 235px; position: absolute" Text="Purchased at: 14/05/2021 17:18"></asp:Label>
        <p>
        <asp:Button ID="btnCancelTicket" runat="server" style="z-index: 1; left: 284px; top: 335px; position: absolute" Text="Cancel ticket (!)" OnClick="btnCancelTicket_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 876px; top: 23px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
    </form>
</body>
</html>
