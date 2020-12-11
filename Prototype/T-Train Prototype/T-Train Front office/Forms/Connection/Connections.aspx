<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Connections.aspx.vb" Inherits="T_Train_Front_office.Connections" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="Button8" runat="server" style="z-index: 1; left: 714px; top: 26px; position: absolute" Text="My tickets" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 360px; top: 589px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
            <asp:Button ID="Button9" runat="server" style="z-index: 1; left: 546px; top: 26px; position: absolute; right: 289px" Text="Account Settings" />
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 391px; top: 26px; position: absolute" Text="Staff Dashboard" />
        </p>
        <div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 826px; top: 24px; position: absolute" Text="Signup" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 910px; top: 25px; position: absolute" Text="Login" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 129px; top: 21px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find your connection:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 82px; top: 196px; position: absolute" Text="Departure station:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 126px; top: 231px; position: absolute" Text="From:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 185px; top: 233px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" style="z-index: 1; left: 334px; top: 228px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 441px; top: 233px; position: absolute; right: 524px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 481px; top: 234px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 74px; top: 278px; position: absolute" Text="Departure Date &amp; Time:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 115px; top: 318px; position: absolute; right: 838px;" Text="Date:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 178px; top: 315px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 178px; top: 315px; position: absolute; margin-bottom: 5px; right: 654px;"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 435px; top: 317px; position: absolute" Text="Time:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 496px; top: 314px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 732px; top: 288px; position: absolute" Text="Search Connections" />
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 755px; top: 247px; position: absolute" Text="All connections" />
        </div>
        <asp:Label ID="Label9" runat="server" Font-Size="X-Large" style="z-index: 1; left: 36px; top: 375px; position: absolute" Text="Connections Found:"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 129px; top: 546px; position: absolute" Text="Leicester - Birmingham"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 351px; top: 548px; position: absolute" Text="12/06/2021"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 509px; top: 549px; position: absolute" Text="14:25"></asp:Label>
        <asp:Button ID="Button6" runat="server" style="z-index: 1; left: 597px; top: 546px; position: absolute" Text="Book Ticket" />
        <asp:Button ID="Button7" runat="server" style="z-index: 1; left: 745px; top: 546px; position: absolute" Text="Manage Connection" />
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 303px; top: 441px; position: absolute" Text="No connections matching the requirements were found."></asp:Label>
    </form>
</body>
</html>
