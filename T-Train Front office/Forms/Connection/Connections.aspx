<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connections.aspx.cs" Inherits="T_Train_Front_office.Forms.Connection.Connections" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 661px; top: 28px; position: absolute" Text="My tickets" OnClick="btnTickets_Click" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 360px; top: 589px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
            <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 493px; top: 29px; position: absolute; right: 342px" Text="Account Settings" OnClick="btnSettings_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 333px; top: 28px; position: absolute; right: 514px;" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        </p>
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 769px; top: 27px; position: absolute" Text="Signup" OnClick="btnSignup_Click" />
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 848px; top: 27px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 184px; top: 24px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find your connection:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 82px; top: 196px; position: absolute" Text="Departure station:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 126px; top: 231px; position: absolute" Text="From:"></asp:Label>
        <asp:DropDownList ID="ddlFrom" runat="server" style="z-index: 1; left: 185px; top: 233px; position: absolute; right: 694px;">
        </asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" style="z-index: 1; left: 334px; top: 228px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 441px; top: 233px; position: absolute; right: 524px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="ddlTo" runat="server" style="z-index: 1; left: 481px; top: 234px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 74px; top: 278px; position: absolute" Text="Departure Date &amp; Time:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 115px; top: 318px; position: absolute; right: 838px;" Text="Date:"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 178px; top: 315px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 178px; top: 315px; position: absolute; margin-bottom: 5px; right: 654px;"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 435px; top: 317px; position: absolute" Text="Time:"></asp:Label>
        <asp:TextBox ID="ddlTime" runat="server" style="z-index: 1; left: 496px; top: 314px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilterConnections" runat="server" style="z-index: 1; left: 732px; top: 288px; position: absolute" Text="Search Connections" OnClick="btnFilterConnections_Click" />
        <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 755px; top: 247px; position: absolute" Text="All connections" OnClick="btnConnections_Click" />
        </div>
        <asp:Label ID="lblConsHeader" runat="server" Font-Size="X-Large" style="z-index: 1; left: 36px; top: 375px; position: absolute" Text="Connections Found:"></asp:Label>
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 909px; top: 28px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <asp:Label ID="lblConsRoute" runat="server" style="z-index: 1; left: 102px; top: 453px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="lblConsTime" runat="server" style="z-index: 1; left: 420px; top: 455px; position: absolute" Text="14:25"></asp:Label>
        </p>
        <asp:Button ID="btnBookTicket" runat="server" OnClick="btnBookTicket_Click1" style="z-index: 1; left: 606px; top: 451px; position: absolute; right: 249px" Text="Book Ticket" />
        <asp:Button ID="btnManageConnection" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 745px; top: 450px; position: absolute" Text="Manage Connection" />
        <p>
        <asp:Label ID="lblConsDate" runat="server" style="z-index: 1; left: 302px; top: 454px; position: absolute; right: 586px;" Text="12/06/2021"></asp:Label>
        </p>
        <asp:Label ID="lblConsPublic" runat="server" style="z-index: 1; left: 514px; top: 455px; position: absolute" Text="Public"></asp:Label>
    </form>
</body>
</html>
