<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TicketTypes.aspx.vb" Inherits="T_Train_Front_office.TicketTypes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 106px; top: 260px; position: absolute; right: 847px;" Text="Price:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 178px; top: 262px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 185px; top: 25px; position: absolute" Text="Welcome to T-Train"></asp:Label>
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 723px; top: 25px; position: absolute" Text="Staff Dashboard" />
        </div>
        <asp:Button ID="Button11" runat="server" style="z-index: 1; left: 902px; top: 26px; position: absolute" Text="Logout" />
        <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find ticket types:"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 103px; top: 221px; position: absolute; right: 850px;" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 179px; top: 222px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 103px; top: 297px; position: absolute" Text="Only refundable" />
        <asp:Button ID="Button12" runat="server" style="z-index: 1; left: 242px; top: 295px; position: absolute" Text="Search" />
        <p>
        <asp:Label ID="Label9" runat="server" Font-Size="X-Large" style="z-index: 1; left: 16px; top: 338px; position: absolute" Text="Ticket Types Found:"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 105px; top: 387px; position: absolute" Text="No ticket types matching the requirements were found."></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 58px; top: 473px; position: absolute" Text="EzTrain - Summer Ticket 2020"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 316px; top: 475px; position: absolute" Text="14.90"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 416px; top: 475px; position: absolute" Text="Non-Refundable"></asp:Label>
        <asp:Button ID="Button7" runat="server" style="z-index: 1; left: 680px; top: 505px; position: absolute" Text="Manage Ticket Type" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 360px; top: 589px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 317px; top: 508px; position: absolute" Text="12.75"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 416px; top: 508px; position: absolute; right: 534px;" Text="Refundable"></asp:Label>
        </p>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 71px; top: 509px; position: absolute" Text="Super Trains! Standard 2021"></asp:Label>
        <p>
        <asp:Button ID="Button13" runat="server" style="z-index: 1; left: 680px; top: 471px; position: absolute" Text="Manage Ticket Type" />
        </p>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 572px; top: 476px; position: absolute" Text="Public"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 572px; top: 511px; position: absolute" Text="Private"></asp:Label>
    </form>
</body>
</html>
