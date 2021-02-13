﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffDashboard.aspx.cs" Inherits="T_Train_Front_office.Forms.StaffDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="Button1_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 608px; top: 22px; position: absolute" Text="My tickets" OnClick="btnTickets_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 712px; top: 21px; position: absolute; height: 26px;" Text="Account Settings" OnClick="btnSettings_Click" />
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 237px; top: 19px; position: absolute" Text="T-Train"></asp:Label>
        </p>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 81px; top: 143px; position: absolute" Text="Connections"></asp:Label>
        <p>
            <asp:Label ID="Label26" runat="server" Font-Size="X-Large" style="z-index: 1; left: 334px; top: 87px; position: absolute" Text="Welcome to the staff dashboard"></asp:Label>
        </p>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 98px; top: 182px; position: absolute" Text="Find Connection by ID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 265px; top: 182px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFindConnection" runat="server" style="z-index: 1; left: 446px; top: 181px; position: absolute" Text="Find Connection" OnClick="btnFindConnection_Click" />
        <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 115px; top: 222px; position: absolute" Text="All Connections" OnClick="btnConnections_Click" />
        <asp:Button ID="btnAddConnection" runat="server" style="z-index: 1; left: 278px; top: 223px; position: absolute" Text="Add Connection" OnClick="btnAddConnection_Click" />
        <asp:Label ID="Label20" runat="server" Font-Size="Large" style="z-index: 1; left: 78px; top: 299px; position: absolute" Text="Ticket Types"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 97px; top: 347px; position: absolute" Text="Find Ticket Type by ID:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 266px; top: 347px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnFindTicketType" runat="server" style="z-index: 1; left: 451px; top: 345px; position: absolute" Text="Find Ticket Type" OnClick="btnFindTicketType_Click" />
            <asp:Button ID="btnTicketTypes" runat="server" style="z-index: 1; left: 111px; top: 384px; position: absolute" Text="All Ticket Types" OnClick="btnTicketTypes_Click" />
            <asp:Button ID="btnAddTicketType" runat="server" style="z-index: 1; left: 278px; top: 385px; position: absolute" Text="Add Ticket Type" OnClick="btnAddTicketType_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 876px; top: 22px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        </p>
        <asp:Label ID="Label22" runat="server" Font-Size="Large" style="z-index: 1; left: 85px; top: 455px; position: absolute" Text="Customers"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 99px; top: 529px; position: absolute" Text="Customer's Last Name:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 272px; top: 496px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilterCustomers" runat="server" style="z-index: 1; left: 462px; top: 525px; position: absolute" Text="Search Customers" OnClick="btnFilterCustomers_Click" />
        <p>
            <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 99px; top: 494px; position: absolute" Text="Customer's First Name:"></asp:Label>
            <asp:Label ID="Label25" runat="server" style="z-index: 1; left: 99px; top: 561px; position: absolute" Text="Customer's Date of Birth:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 273px; top: 528px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 278px; top: 561px; position: absolute"></asp:TextBox>
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 368px; top: 633px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
    </form>
</body>
</html>