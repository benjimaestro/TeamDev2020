<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="StaffDashboard.aspx.vb" Inherits="T_Train_Front_office.StaffDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" />
            <asp:Button ID="Button7" runat="server" style="z-index: 1; left: 655px; top: 24px; position: absolute" Text="My tickets" />
        <asp:Button ID="Button8" runat="server" style="z-index: 1; left: 759px; top: 25px; position: absolute" Text="Account Settings" />
        </div>
        <asp:Button ID="Button9" runat="server" style="z-index: 1; left: 499px; top: 25px; position: absolute" Text="Staff Dashboard" />
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        </p>
        <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 81px; top: 143px; position: absolute" Text="Connections"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 98px; top: 182px; position: absolute" Text="Find Connection by ID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 265px; top: 182px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 407px; top: 180px; position: absolute" Text="Find Connection" />
        <asp:Button ID="Button11" runat="server" style="z-index: 1; left: 115px; top: 222px; position: absolute" Text="All Connections" />
        <asp:Button ID="Button12" runat="server" style="z-index: 1; left: 278px; top: 223px; position: absolute" Text="Add Connection" />
        <asp:Label ID="Label20" runat="server" Font-Size="Large" style="z-index: 1; left: 78px; top: 299px; position: absolute" Text="Ticket Types"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 97px; top: 347px; position: absolute" Text="Find Ticket Type by ID:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 266px; top: 347px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="Button13" runat="server" style="z-index: 1; left: 410px; top: 345px; position: absolute" Text="Find Ticket Type" />
            <asp:Button ID="Button14" runat="server" style="z-index: 1; left: 111px; top: 384px; position: absolute" Text="All Ticket Types" />
            <asp:Button ID="Button15" runat="server" style="z-index: 1; left: 278px; top: 385px; position: absolute" Text="Add Ticket Type" />
        </p>
        <asp:Label ID="Label22" runat="server" Font-Size="Large" style="z-index: 1; left: 85px; top: 455px; position: absolute" Text="Customers"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 99px; top: 529px; position: absolute" Text="Customer's Last Name:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 272px; top: 496px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button16" runat="server" style="z-index: 1; left: 428px; top: 525px; position: absolute" Text="Search Customers" />
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
