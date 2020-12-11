<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Payment.aspx.vb" Inherits="T_Train_Front_office.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" />
        <asp:Button ID="Button11" runat="server" style="z-index: 1; left: 650px; top: 24px; position: absolute" Text="Back to Customer" />
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 826px; top: 24px; position: absolute" Text="Staff Dashboard" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 345px; top: 83px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 348px; top: 455px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 64px; top: 145px; position: absolute" Text="Payment Details"></asp:Label>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 105px; top: 216px; position: absolute" Text="Payment Value:"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 105px; top: 249px; position: absolute" Text="Payment Start Date:"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 104px; top: 282px; position: absolute" Text="Payment End Date:"></asp:Label>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 245px; top: 217px; position: absolute" Text="14.90"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 247px; top: 251px; position: absolute" Text="17/02/2021 14:26"></asp:Label>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 250px; top: 283px; position: absolute" Text="17/02/2021 14:31 / This payment has not been finalized."></asp:Label>
        <asp:Button ID="Button12" runat="server" style="z-index: 1; left: 406px; top: 360px; position: absolute" Text="Back to Customer" />
    </form>
</body>
</html>
