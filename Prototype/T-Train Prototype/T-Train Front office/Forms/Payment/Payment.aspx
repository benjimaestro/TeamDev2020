<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="T_Train_Front_office.Forms.Payment.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 551px; top: 30px; position: absolute" Text="Back to Customer" OnClick="btnCustomer_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 730px; top: 31px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 188px; top: 24px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 348px; top: 455px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 888px; top: 30px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 64px; top: 145px; position: absolute" Text="Payment Details"></asp:Label>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 105px; top: 216px; position: absolute" Text="Payment Value:"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 105px; top: 249px; position: absolute" Text="Payment Start Date:"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 104px; top: 282px; position: absolute" Text="Payment End Date:"></asp:Label>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 245px; top: 217px; position: absolute" Text="14.90"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 247px; top: 251px; position: absolute" Text="17/02/2021 14:26"></asp:Label>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 250px; top: 283px; position: absolute" Text="17/02/2021 14:31 / This payment has not been finalized."></asp:Label>
        <asp:Button ID="btnCustomer2" runat="server" style="z-index: 1; left: 406px; top: 360px; position: absolute" Text="Back to Customer" OnClick="btnCustomer2_Click" />
    </form>
</body>
</html>
