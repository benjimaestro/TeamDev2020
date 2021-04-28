<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketTypes.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket_Type.TicketTypes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 85px; top: 262px; position: absolute; right: 824px;" Text="Max Price:"></asp:Label>
        <asp:TextBox ID="txtTypePrice" runat="server" style="z-index: 1; left: 178px; top: 262px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 38px; top: 68px; position: absolute; right: 805px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 202px; top: 30px; position: absolute" Text="T-Train"></asp:Label>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 38px; top: 30px; position: absolute" Text="Staff Dashboard" OnClick="Button10_Click" />
        </div>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 840px; top: 30px; position: absolute" Text="Logout" OnClick="Button11_Click" />
        <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 38px; top: 158px; position: absolute" Text="Find ticket types:"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 85px; top: 222px; position: absolute; right: 851px;" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtTypeName" runat="server" style="z-index: 1; left: 178px; top: 222px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkOnlyRefundable" runat="server" style="z-index: 1; left: 103px; top: 297px; position: absolute" Text="Only refundable" />
        <asp:Button ID="btnTicketTypes" runat="server" style="z-index: 1; left: 242px; top: 297px; position: absolute" Text="Search" OnClick="Button12_Click" />
        <p>
        <asp:Label ID="lblStaticHeader" runat="server" Font-Size="X-Large" style="z-index: 1; left: 38px; top: 358px; position: absolute" Text="Ticket Types Found:" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 377px; top: 243px; position: absolute" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 374px; top: 634px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <asp:Label ID="lblStaticNoneFound" runat="server" style="z-index: 1; left: 105px; top: 407px; position: absolute" Text="No ticket types matching the requirements were found." Visible="False"></asp:Label>
        <p>
        <asp:Button ID="btnManageType" runat="server" style="z-index: 1; left: 576px; top: 461px; position: absolute" Text="Manage Ticket Type" OnClick="Button13_Click" Visible="False" />
        </p>
        <p>
        <asp:Label ID="lblTypeSelected" runat="server" style="z-index: 1; left: 544px; top: 508px; position: absolute" Text="You must select a ticket type first!" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Button ID="btnAllTypes" runat="server" style="z-index: 1; left: 317px; top: 297px; position: absolute" Text="Show All" OnClick="btnAllTypes_Click" />
        </p>
        <asp:ListBox ID="lstTicketTypes" runat="server" style="z-index: 1; left: 86px; top: 431px; position: absolute; height: 182px; width: 395px" Visible="False"></asp:ListBox>
    </form>
</body>
</html>
