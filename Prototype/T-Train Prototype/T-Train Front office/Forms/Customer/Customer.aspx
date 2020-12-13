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
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 352px; top: 509px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 205px; top: 22px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 437px; top: 184px; position: absolute" Text="First Name:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 440px; top: 222px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 726px; top: 183px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 528px; top: 184px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 530px; top: 223px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 722px; top: 219px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 156px; top: 181px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 217px; top: 180px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 119px; top: 226px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 212px; top: 226px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label19" runat="server" Font-Size="Large" style="z-index: 1; left: 434px; top: 304px; position: absolute" Text="Tickets"></asp:Label>
        <p>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 135px; top: 397px; position: absolute" Text="London - Nottingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 305px; top: 357px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 409px; top: 399px; position: absolute" Text="17:40"></asp:Label>
        </p>
        <asp:Button ID="btnCancelTicket" runat="server" style="z-index: 1; left: 594px; top: 353px; position: absolute" Text="Cancel Ticket" OnClick="btnCancelTicket_Click" />
        <p>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 135px; top: 356px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 304px; top: 399px; position: absolute" Text="14/02/2021"></asp:Label>
            <asp:Button ID="btnCancelTicket2" runat="server" style="z-index: 1; left: 593px; top: 393px; position: absolute" Text="Cancel Ticket" OnClick="Button14_Click" />
            <asp:Button ID="btnPayment" runat="server" style="z-index: 1; left: 760px; top: 354px; position: absolute" Text="View Payment" OnClick="btnPayment_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 892px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <p>
            <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 484px; top: 356px; position: absolute" Text="Active"></asp:Label>
            <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 484px; top: 399px; position: absolute" Text="Active"></asp:Label>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 407px; top: 356px; position: absolute; height: 18px;" Text="14:25"></asp:Label>
            <asp:Label ID="Label25" runat="server" style="z-index: 1; left: 135px; top: 442px; position: absolute" Text="London - Bedford"></asp:Label>
        </p>
        <asp:Label ID="Label26" runat="server" style="z-index: 1; left: 304px; top: 441px; position: absolute" Text="17/01/2021"></asp:Label>
        <asp:Label ID="Label27" runat="server" style="z-index: 1; left: 407px; top: 442px; position: absolute; right: 543px" Text="07:15"></asp:Label>
        <asp:Label ID="Label28" runat="server" style="z-index: 1; left: 479px; top: 444px; position: absolute" Text="Cancelled"></asp:Label>
        <p>
        <asp:Button ID="btnPayment3" runat="server" style="z-index: 1; left: 678px; top: 441px; position: absolute" Text="View Payment" OnClick="btnPayment3_Click" />
        </p>
        <asp:Button ID="btnPayment2" runat="server" style="z-index: 1; left: 763px; top: 395px; position: absolute; width: 125px" Text="View Payment" />
    </form>
</body>
</html>
