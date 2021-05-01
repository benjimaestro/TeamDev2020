<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="T_Train_Front_office.Forms.Customer.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Button ID="btnCustomers" runat="server" style="z-index: 1; left: 37px; top: 67px; position: absolute" Text="Back to Customers List" OnClick="Button11_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 37px; top: 29px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <div style="height: 22px">
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 189px; top: 29px; position: absolute; right: 654px;" Text="Homepage" OnClick="Button1_Click" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 380px; top: 839px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 321px; top: 29px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 124px; top: 251px; position: absolute; right: 747px;" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 403px; top: 208px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 215px; top: 208px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 215px; top: 251px; position: absolute; right: 660px;"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 528px; top: 208px; position: absolute; height: 64px; width: 172px;" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 215px; top: 162px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 403px; top: 163px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 528px; top: 163px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label19" runat="server" Font-Size="X-Large" style="z-index: 1; left: 446px; top: 567px; position: absolute; right: 443px;" Text="Payments" Font-Bold="True"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancelTicket" runat="server" style="z-index: 1; left: 532px; top: 376px; position: absolute" Text="Cancel Ticket" OnClick="btnCancelTicket_Click" Visible="False" />
        <p>
            <asp:Button ID="btnPayment" runat="server" style="z-index: 1; left: 735px; top: 644px; position: absolute" Text="View Payment" OnClick="btnPayment_Click" Visible="False" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 857px; top: 29px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 124px; top: 162px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 124px; top: 208px; position: absolute" Text="First Name:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblNoTicketsFound" runat="server" style="z-index: 1; left: 340px; top: 366px; position: absolute" Text="This customer has not purchased any tickets." Visible="False" Font-Bold="True"></asp:Label>
        <asp:ListBox ID="lstPayments" runat="server" style="z-index: 1; left: 58px; top: 622px; position: absolute; height: 182px; width: 591px" Visible="False"></asp:ListBox>
        <asp:Label ID="lblTicketSelected" runat="server" style="z-index: 1; left: 481px; top: 430px; position: absolute" Text="You have to select a ticket first." Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label20" runat="server" Font-Size="X-Large" style="z-index: 1; left: 401px; top: 107px; position: absolute" Text="Customer Details" Font-Bold="True"></asp:Label>
        </p>
        <asp:ListBox ID="lstTickets" runat="server" style="z-index: 1; left: 58px; top: 353px; position: absolute; height: 182px; width: 378px" Visible="False"></asp:ListBox>
        <p>
        <asp:Label ID="lblPaymentSelected" runat="server" style="z-index: 1; left: 678px; top: 696px; position: absolute" Text="You have to select a payment first." Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Label ID="Label21" runat="server" Font-Size="X-Large" style="z-index: 1; left: 453px; top: 303px; position: absolute" Text="Tickets" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblNoPaymentsFound" runat="server" style="z-index: 1; left: 345px; top: 636px; position: absolute" Text="This customer has not made any payments." Visible="False" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
