<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketType.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket_Type.TicketType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; " Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 719px; top: 25px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 876px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <p>
        <asp:Button ID="btnTicketTypes" runat="server" style="z-index: 1; left: 515px; top: 26px; position: absolute; right: 283px;" Text="Back to Ticket Types" OnClick="Button9_Click" />
        </p>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 196px; top: 22px; position: absolute" Text="T-Train"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 45px; top: 139px; position: absolute" Text="Add ticket type:/You are modifying this ticket type:"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 150px; top: 199px; position: absolute" Text="My Trainz Ltd. Standard"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 350px; top: 197px; position: absolute; right: 599px;" Text="12.90"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 431px; top: 199px; position: absolute" Text="Refundable"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 549px; top: 200px; position: absolute" Text="Public"></asp:Label>
        <asp:Label ID="Label15" runat="server" Font-Size="X-Large" style="z-index: 1; left: 45px; top: 276px; position: absolute" Text="Change the ticket type to:"></asp:Label>
        </p>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 147px; top: 329px; position: absolute" Text="Name:"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 149px; top: 363px; position: absolute" Text="Price:"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 496px; top: 329px; position: absolute" Text="Refundable" />
        <asp:CheckBox ID="CheckBox2" runat="server" style="z-index: 1; left: 496px; top: 363px; position: absolute" Text="Public" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 217px; top: 328px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 216px; top: 364px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 69px; top: 202px; position: absolute" Text="ID: 22"></asp:Label>
        <p>
            <asp:Button ID="btnTicketType" runat="server" style="z-index: 1; left: 404px; top: 416px; position: absolute" Text="Add ticket type/Save changes" OnClick="btnTicketType_Click" />
            <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 52px; top: 486px; position: absolute" Text="You can also:"></asp:Label>
            <asp:Button ID="btnDelTicketType" runat="server" style="z-index: 1; left: 163px; top: 484px; position: absolute" Text="Delete Ticket Type" OnClick="btnDelTicketType_Click" />
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 365px; top: 550px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
    </form>
</body>
</html>
