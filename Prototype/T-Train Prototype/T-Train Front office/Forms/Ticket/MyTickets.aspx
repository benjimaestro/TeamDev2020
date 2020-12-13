<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTickets.aspx.cs" Inherits="T_Train_Front_office.Forms.Ticket.MyTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 508px; top: 25px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 371px; top: 659px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 660px; top: 24px; position: absolute" Text="Account settings" OnClick="btnSettings_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 188px; top: 17px; position: absolute" Text="T-Train"></asp:Label>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Size="Large" style="z-index: 1; left: 95px; top: 129px; position: absolute" Text="Filter tickets:"></asp:Label>
        <asp:Button ID="btnFilterFirst" runat="server" style="z-index: 1; left: 91px; top: 189px; position: absolute; right: 780px" Text="Coming first" OnClick="btnFilterFirst_Click" />
        <asp:Button ID="btnFilterLast" runat="server" style="z-index: 1; left: 243px; top: 191px; position: absolute" Text="Coming last" OnClick="btnFilterLast_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 152px; top: 161px; position: absolute" Text="By date of departure:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 482px; top: 159px; position: absolute" Text="By station:"></asp:Label>
        <p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 430px; top: 188px; position: absolute; right: 494px;" Text="From:"></asp:Label>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 824px; top: 24px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 432px; top: 221px; position: absolute; right: 508px;" Text="To:"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" style="z-index: 1; left: 493px; top: 185px; position: absolute; height: 20px; width: 102px">
            </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 486px; top: 221px; position: absolute; height: 16px; width: 105px;">
        </asp:DropDownList>
            <asp:Button ID="btnReissue2" runat="server" style="z-index: 1; left: 693px; top: 531px; position: absolute" Text="Reissue" OnClick="btnReissue2_Click" />
        </p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 88px; top: 237px; position: absolute" Text="Only departing at:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 221px; top: 237px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilterTickets" runat="server" style="z-index: 1; left: 682px; top: 205px; position: absolute" Text="Apply Filter" OnClick="btnFilterTickets_Click" />
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 211px; top: 304px; position: absolute" Text="You have not purchased any tickets yet."></asp:Label>
        <asp:Button ID="btnHomepage3" runat="server" style="z-index: 1; left: 535px; top: 599px; position: absolute" Text="Homepage" OnClick="btnHomepage3_Click" />
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 265px; top: 339px; position: absolute" Text="Find connections:"></asp:Label>
        <asp:Button ID="btnConnections2" runat="server" style="z-index: 1; left: 659px; top: 598px; position: absolute" Text="All connections" OnClick="btnConnections2_Click" />
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 81px; top: 401px; position: absolute" Text="TICKET ACTIVE:"></asp:Label>
        <p>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 120px; top: 536px; position: absolute" Text="London - Nottingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 356px; top: 443px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 514px; top: 537px; position: absolute" Text="17:40"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 85px; top: 497px; position: absolute" Text="TICKET ACTIVE:"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 124px; top: 441px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 353px; top: 538px; position: absolute; right: 560px;" Text="04/02/2021"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 513px; top: 441px; position: absolute" Text="14:25"></asp:Label>
        </p>
        <asp:Button ID="btnReissue" runat="server" style="z-index: 1; left: 647px; top: 439px; position: absolute; right: 269px" Text="Reissue" OnClick="btnReissue_Click" />
        <p>
            <asp:Button ID="btnRefund" runat="server" style="z-index: 1; left: 749px; top: 440px; position: absolute" Text="Refund" OnClick="btnRefund_Click" />
        </p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 300px; top: 601px; position: absolute" Text="Need more? Find connections:"></asp:Label>
        <p>
            <asp:Button ID="btnHomepage2" runat="server" style="z-index: 1; left: 400px; top: 339px; position: absolute" Text="Homepage" OnClick="btnHomepage2_Click" />
            <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 518px; top: 340px; position: absolute" Text="All connections" OnClick="btnConnections_Click" />
        </p>
    </form>
</body>
</html>
