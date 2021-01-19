<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T_Train_Front_office.Forms.Defaul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 381px; top: 70px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="lblHeaderSubtitle" runat="server" Font-Size="Large" style="z-index: 1; left: 428px; top: 122px; position: absolute" Text="Book your tickets now!"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find your connection:"></asp:Label>
        <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 370px; top: 26px; position: absolute" Text="Staff Dashboard" OnClick="Button9_Click" />
        <p>
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 520px; top: 27px; position: absolute; right: 552px;" Text="My tickets" OnClick="Button7_Click" />
        </p>
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 859px; top: 27px; position: absolute" Text="Signup" OnClick="Button2_Click" />
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 798px; top: 27px; position: absolute; " Text="Login" OnClick="Button3_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 126px; top: 231px; position: absolute; right: 798px;" Text="From:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 185px; top: 233px; position: absolute; right: 698px;">
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 441px; top: 233px; position: absolute; right: 499px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 481px; top: 234px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 115px; top: 318px; position: absolute" Text="Date:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 178px; top: 315px; position: absolute; margin-bottom: 5px; right: 654px;"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 435px; top: 317px; position: absolute" Text="Time:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 496px; top: 314px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" style="z-index: 1; left: 334px; top: 228px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 74px; top: 278px; position: absolute" Text="Departure Date &amp; Time:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 82px; top: 196px; position: absolute" Text="Departure station:"></asp:Label>
        <asp:Button ID="btnFilterConnections" runat="server" style="z-index: 1; left: 732px; top: 288px; position: absolute" Text="Search Connections" OnClick="btnFilterConnections_Click" />
        <asp:Label ID="Label9" runat="server" Font-Size="X-Large" style="z-index: 1; left: 359px; top: 377px; position: absolute" Text="Explore more of T-Train:"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 92px; top: 435px; position: absolute" Text="Articles:"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 467px; top: 439px; position: absolute" Text="News:"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 763px; top: 438px; position: absolute" Text="Announcements:"></asp:Label>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 96px; top: 575px; position: absolute" Text="Contact Form"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 97px; top: 607px; position: absolute" Text="About T-Train"></asp:Label>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 97px; top: 645px; position: absolute" Text="Terms of Service"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 583px; top: 568px; position: absolute; height: 105px; width: 196px" Text="T-Train London Rd. 15, Leicester, LE6 8OB, Leicestershire, Great Britain, Email: customer@ttrain.com, Mobile: +44 07491749173"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 354px; top: 706px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 755px; top: 247px; position: absolute" Text="All connections" OnClick="btnConnections_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 629px; top: 27px; position: absolute" Text="Account Settings" OnClick="Button8_Click" />
    </form>
</body>
</html>
