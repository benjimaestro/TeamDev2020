<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connections.aspx.cs" Inherits="T_Train_Front_office.Forms.Connection.Connections" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" runat="server">
<head runat="server">
    <title></title>
</head>
<body runat="server">
    <form id="form2" runat="server">
        <p>
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 581px; top: 32px; position: absolute" Text="My Tickets" OnClick="btnTickets_Click" Font-Size="Large" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 393px; top: 671px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
            <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 742px; top: 29px; position: absolute; right: 64px" Text="Account Settings" OnClick="btnSettings_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 19px; top: 68px; position: absolute; right: 819px;" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        </p>
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 19px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 822px; top: 29px; position: absolute" Text="Register" OnClick="btnSignup_Click" Font-Size="X-Large" />
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 719px; top: 29px; position: absolute" Text="Login" OnClick="btnLogin_Click" Font-Size="X-Large" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 184px; top: 29px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find your connection:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 82px; top: 196px; position: absolute" Text="Departure station:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 126px; top: 233px; position: absolute" Text="From:"></asp:Label>
        <asp:DropDownList ID="ddlFrom" runat="server" style="z-index: 1; left: 185px; top: 233px; position: absolute; right: 694px;">
            <asp:ListItem>Leicester</asp:ListItem>
            <asp:ListItem>Birmingham</asp:ListItem>
            <asp:ListItem>Glasgow</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Cambridge</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" style="z-index: 1; left: 334px; top: 233px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 441px; top: 233px; position: absolute; right: 524px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="ddlTo" runat="server" style="z-index: 1; left: 481px; top: 233px; position: absolute">
            <asp:ListItem>Leicester</asp:ListItem>
            <asp:ListItem>Glasgow</asp:ListItem>
            <asp:ListItem>Birmingham</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Cambridge</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 82px; top: 278px; position: absolute" Text="Departure Date &amp; Time:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 109px; top: 318px; position: absolute; right: 814px;" Text="Date:"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 183px; top: 318px; position: absolute; margin-bottom: 5px; right: 645px;"></asp:TextBox>
        <asp:Label ID="lblConnSelected" runat="server" style="z-index: 1; left: 592px; top: 605px; position: absolute" Text="You must select a connection first!" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Button ID="btnFilterConnections" runat="server" style="z-index: 1; left: 732px; top: 288px; position: absolute" Text="Search Connections" OnClick="btnFilterConnections_Click" />
            <asp:Label ID="lblError" runat="server" Font-Size="Large" ForeColor="Red" style="z-index: 1; left: 397px; top: 179px; position: absolute"></asp:Label>
        <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 755px; top: 247px; position: absolute" Text="All Connections" OnClick="btnConnections_Click" />
        </div>
        <asp:Label ID="lblConsHeader" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 375px; position: absolute" Text="Connections Found:"></asp:Label>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 909px; top: 29px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
            <%  %>
        </p>
        <asp:Button ID="btnBookTicket" runat="server" OnClick="btnBookTicket_Click1" style="z-index: 1; left: 655px; top: 490px; position: absolute; right: 196px" Text="Book Ticket" Visible="False" />
        <asp:Button ID="btnManageConnection" runat="server" OnClick="btnManageConnection_Click" style="z-index: 1; left: 623px; top: 556px; position: absolute" Text="Manage Connection" Visible="False" />
        <p>
            &nbsp;</p>
        <asp:DropDownList ID="ddlTime" runat="server" style="z-index: 1; left: 498px; top: 318px; position: absolute">
        </asp:DropDownList>
        <p>
        <asp:Button ID="btnPick" runat="server" OnClick="btnPick_Click" style="z-index: 1; left: 348px; top: 318px; position: absolute; height: 26px" Text="Pick" />
        </p>
        <asp:Calendar ID="dtpDate" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" OnSelectionChanged="Calendar1_SelectionChanged" style="z-index: 1; left: 125px; top: 360px; position: absolute; height: 188px; width: 259px; z-index: 10" Width="330px" Visible="False">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <asp:ListBox ID="lstConnections" runat="server" style="z-index: 1; left: 154px; top: 460px; position: absolute; height: 182px; width: 381px" Visible="False"></asp:ListBox>
        <p>
        <asp:Label ID="lblNoConsFound" runat="server" style="z-index: 1; left: 248px; top: 471px; position: absolute; height: 64px; width: 455px;" Text="There were no connections found on this day from and to the selected place. Please try again with different criteria or check back soon, we add new connections everyday!" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 435px; top: 318px; position: absolute" Text="Time:"></asp:Label>
        </p>
    </form>
</body>
</html>
