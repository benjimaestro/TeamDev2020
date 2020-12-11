<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cancel.aspx.vb" Inherits="T_Train_Front_office.Cancel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" />
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 785px; top: 22px; position: absolute" Text="Staff Dashboard" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 600px; top: 23px; position: absolute; right: 226px;" Text="Back to Customer" />
        </p>
        <div>
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 243px; top: 16px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 362px; top: 447px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 160px; top: 174px; position: absolute" Text="Ticket to be cancelled:"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 217px; top: 264px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 440px; top: 267px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 618px; top: 267px; position: absolute" Text="14:25"></asp:Label>
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 470px; top: 333px; position: absolute" Text="Back to Customer" />
        <asp:Label ID="Label21" runat="server" Font-Size="X-Large" style="z-index: 1; left: 365px; top: 113px; position: absolute" Text="Cancel ticket procedure"></asp:Label>
        </p>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 216px; top: 235px; position: absolute" Text="Kent Smith"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 458px; top: 235px; position: absolute" Text="Purchased at: 14/05/2021 17:18"></asp:Label>
        <p>
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 284px; top: 335px; position: absolute" Text="Cancel ticket (!)" />
        </p>
    </form>
</body>
</html>
