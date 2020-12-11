<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Refund.aspx.vb" Inherits="T_Train_Front_office.Refund" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 535px; top: 26px; position: absolute" Text="Staff Dashboard" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 695px; top: 25px; position: absolute; right: 197px;" Text="My tickets" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 810px; top: 27px; position: absolute" Text="Account settings" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 362px; top: 447px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 217px; top: 323px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 444px; top: 325px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 623px; top: 325px; position: absolute" Text="14:25"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 352px; top: 158px; position: absolute; height: 113px; width: 283px" Text="Are you sure that you want to refund the ticket? It may take up to 2 weeks for the refund to be processed. During this time you will be unable to book the same ticket again."></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 134px; top: 271px; position: absolute" Text="Ticket to be refunded:"></asp:Label>
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 282px; top: 380px; position: absolute" Text="Confirm refund (!)" />
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 559px; top: 381px; position: absolute" Text="Cancel" />
        <asp:Label ID="Label21" runat="server" Font-Size="X-Large" style="z-index: 1; left: 365px; top: 113px; position: absolute" Text="Ticket refund procedure"></asp:Label>
    </form>
</body>
</html>
