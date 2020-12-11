<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="T_Train_Front_office._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="lblHeaderSubtitle" runat="server" Font-Size="Large" style="z-index: 1; left: 396px; top: 111px; position: absolute" Text="Book your tickets now!"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find your connection:"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" />
        <asp:Button ID="Button9" runat="server" style="z-index: 1; left: 370px; top: 26px; position: absolute" Text="Staff Dashboard" />
        <p>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 517px; top: 25px; position: absolute" Text="Signup" />
            <asp:Button ID="Button7" runat="server" style="z-index: 1; left: 655px; top: 24px; position: absolute" Text="My tickets" />
        </p>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 592px; top: 24px; position: absolute; right: 346px;" Text="Login" />
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
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 732px; top: 288px; position: absolute" Text="Search Connections" />
        <asp:Label ID="Label9" runat="server" Font-Size="X-Large" style="z-index: 1; left: 359px; top: 377px; position: absolute" Text="Explore more of T-Train:"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 92px; top: 435px; position: absolute" Text="Articles:"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 467px; top: 439px; position: absolute" Text="News:"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 763px; top: 438px; position: absolute" Text="Announcements:"></asp:Label>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 96px; top: 575px; position: absolute" Text="Contact Form"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 97px; top: 607px; position: absolute" Text="About T-Train"></asp:Label>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 97px; top: 645px; position: absolute" Text="Terms of Service"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 583px; top: 568px; position: absolute; height: 105px; width: 196px" Text="T-Train London Rd. 15, Leicester, LE6 8OB, Leicestershire, Great Britain, Email: customer@ttrain.com, Mobile: +44 07491749173"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 354px; top: 706px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 755px; top: 247px; position: absolute" Text="All connections" />
        <asp:Button ID="Button8" runat="server" style="z-index: 1; left: 759px; top: 25px; position: absolute" Text="Account Settings" />
    </form>
</body>
</html>
