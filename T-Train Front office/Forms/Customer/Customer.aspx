<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="T_Train_Front_office.Forms.Customer.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Button ID="btnCustomers" runat="server" style="z-index: 1; left: 510px; top: 24px; position: absolute" Text="Back to Customers List" OnClick="Button11_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 735px; top: 26px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <div style="height: 22px">
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="Button1_Click" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 351px; top: 881px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 205px; top: 22px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 437px; top: 184px; position: absolute" Text="First Name:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 440px; top: 222px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 726px; top: 183px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 528px; top: 184px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 530px; top: 223px; position: absolute; right: 524px;"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 722px; top: 219px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 156px; top: 181px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 217px; top: 180px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 119px; top: 226px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 212px; top: 226px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label19" runat="server" Font-Size="Large" style="z-index: 1; left: 429px; top: 567px; position: absolute; right: 437px;" Text="Payments"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancelTicket" runat="server" style="z-index: 1; left: 532px; top: 376px; position: absolute" Text="Cancel Ticket" OnClick="btnCancelTicket_Click" Visible="False" />
        <p>
            <asp:Button ID="btnPayment" runat="server" style="z-index: 1; left: 526px; top: 662px; position: absolute" Text="View Payment" OnClick="btnPayment_Click" Visible="False" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 892px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblNoTicketsFound" runat="server" style="z-index: 1; left: 330px; top: 365px; position: absolute" Text="This customer has not purchased any tickets." Visible="False" Font-Bold="True"></asp:Label>
        <asp:ListBox ID="lstPayments" runat="server" style="z-index: 1; left: 58px; top: 622px; position: absolute; height: 182px; width: 345px" Visible="False"></asp:ListBox>
        <asp:Label ID="lblTicketSelected" runat="server" style="z-index: 1; left: 469px; top: 426px; position: absolute" Text="You have to select a ticket first." Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label20" runat="server" Font-Size="Large" style="z-index: 1; left: 434px; top: 304px; position: absolute" Text="Tickets"></asp:Label>
        </p>
        <asp:ListBox ID="lstTickets0" runat="server" style="z-index: 1; left: 58px; top: 353px; position: absolute; height: 182px; width: 345px" Visible="False"></asp:ListBox>
        <p>
        <asp:Label ID="lblPaymentSelected" runat="server" style="z-index: 1; left: 457px; top: 705px; position: absolute" Text="You have to select a payment first." Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblNoTicketsFound0" runat="server" style="z-index: 1; left: 324px; top: 651px; position: absolute" Text="This customer has not made any payments." Visible="False" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
