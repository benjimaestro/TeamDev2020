<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="T_Train_Front_office.Forms.Payment.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 41px; top: 66px; position: absolute; right: 854px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 41px; top: 32px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 211px; top: 32px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 378px; top: 393px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 855px; top: 32px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 64px; top: 145px; position: absolute" Text="Payment Details:" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblErrorNotFound" runat="server" style="z-index: 1; left: 467px; top: 249px; position: absolute" Text="Payment not found." Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Label ID="lblPSD" runat="server" style="z-index: 1; left: 105px; top: 249px; position: absolute" Text="Payment Start Date:"></asp:Label>
        <asp:Label ID="lblED" runat="server" style="z-index: 1; left: 105px; top: 282px; position: absolute" Text="Payment End Date:"></asp:Label>
        <asp:Label ID="lblPaymentValue" runat="server" style="z-index: 1; left: 250px; top: 216px; position: absolute"></asp:Label>
        <asp:Label ID="lblPaymentStartDate" runat="server" style="z-index: 1; left: 250px; top: 249px; position: absolute"></asp:Label>
        <asp:Label ID="lblPaymentEndDate" runat="server" style="z-index: 1; left: 250px; top: 282px; position: absolute"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 408px; top: 340px; position: absolute" Text="Back to Customer" OnClick="btnCustomer2_Click" Visible="False" />
        <p>
        <asp:Label ID="lblPV" runat="server" style="z-index: 1; left: 105px; top: 216px; position: absolute" Text="Payment Value:"></asp:Label>
        </p>
    </form>
</body>
</html>
