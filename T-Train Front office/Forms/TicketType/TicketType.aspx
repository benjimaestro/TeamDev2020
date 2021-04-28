<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketType.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket_Type.TicketType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 181px; top: 27px; position: absolute; " Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 28px; top: 27px; position: absolute; right: 823px;" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 856px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <p>
        <asp:Button ID="btnTicketTypes" runat="server" style="z-index: 1; left: 28px; top: 66px; position: absolute; right: 692px;" Text="Back to Ticket Types" OnClick="Button9_Click" />
        </p>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 324px; top: 27px; position: absolute" Text="T-Train"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblActionName" runat="server" Font-Size="X-Large" style="z-index: 1; left: 28px; top: 139px; position: absolute" Text="Add ticket type:"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 150px; top: 202px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 350px; top: 202px; position: absolute; right: 572px;" Visible="False"></asp:Label>
        <asp:Label ID="lblRefundable" runat="server" style="z-index: 1; left: 431px; top: 202px; position: absolute; right: 454px;" Visible="False"></asp:Label>
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 549px; top: 202px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="lblStaticEditing" runat="server" Font-Size="X-Large" style="z-index: 1; left: 28px; top: 276px; position: absolute" Text="Change the ticket type to:" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 147px; top: 329px; position: absolute; width: 42px;" Text="Name:"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 498px; top: 424px; position: absolute" Text="Entered data was invalid!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:CheckBox ID="chkRefundable" runat="server" style="z-index: 1; left: 496px; top: 329px; position: absolute" Text="Refundable" />
        <asp:CheckBox ID="chkPublic" runat="server" style="z-index: 1; left: 496px; top: 363px; position: absolute" Text="Public" />
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 216px; top: 363px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaticId" runat="server" style="z-index: 1; left: 69px; top: 202px; position: absolute" Text="ID:" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="btnSaveChanges" runat="server" style="z-index: 1; left: 307px; top: 424px; position: absolute; height: 26px;" Text="Add Ticket Type" OnClick="btnTicketType_Click" />
            <asp:Label ID="lblDelete" runat="server" Font-Size="Large" style="z-index: 1; left: 28px; top: 496px; position: absolute" Text="You can also:" Visible="False"></asp:Label>
            <asp:Button ID="btnDelTicketType" runat="server" style="z-index: 1; left: 163px; top: 496px; position: absolute" Text="Delete Ticket Type" OnClick="btnDelTicketType_Click" Visible="False" />
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 365px; top: 550px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="lblId" runat="server" style="z-index: 1; left: 95px; top: 202px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 147px; top: 363px; position: absolute" Text="Price:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 216px; top: 329px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
