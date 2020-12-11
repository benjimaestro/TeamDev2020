<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MyTickets.aspx.vb" Inherits="T_Train_Front_office.MyTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="Button15" runat="server" style="z-index: 1; left: 540px; top: 26px; position: absolute" Text="Staff Dashboard" />
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 371px; top: 659px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 695px; top: 25px; position: absolute; " Text="My tickets" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 810px; top: 27px; position: absolute" Text="Account settings" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Size="Large" style="z-index: 1; left: 95px; top: 129px; position: absolute" Text="Filter tickets:"></asp:Label>
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 91px; top: 189px; position: absolute; right: 780px" Text="Coming first" />
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 243px; top: 191px; position: absolute" Text="Coming last" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 152px; top: 161px; position: absolute" Text="By date of departure:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 482px; top: 159px; position: absolute" Text="By station:"></asp:Label>
        <p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 430px; top: 188px; position: absolute; right: 494px;" Text="From:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 487px; top: 187px; position: absolute; right: 421px; bottom: 288px;">
        </asp:DropDownList>
        </p>
        <p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 432px; top: 221px; position: absolute; right: 508px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 486px; top: 225px; position: absolute">
        </asp:DropDownList>
            <asp:Button ID="Button10" runat="server" style="z-index: 1; left: 693px; top: 531px; position: absolute" Text="Reissue" />
        </p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 88px; top: 237px; position: absolute" Text="Only departing at:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 221px; top: 237px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" style="z-index: 1; left: 682px; top: 205px; position: absolute" Text="Apply Filter" />
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 211px; top: 304px; position: absolute" Text="You have not purchased any tickets yet."></asp:Label>
        <asp:Button ID="Button7" runat="server" style="z-index: 1; left: 535px; top: 599px; position: absolute" Text="Homepage" />
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 265px; top: 339px; position: absolute" Text="Find connections:"></asp:Label>
        <asp:Button ID="Button8" runat="server" style="z-index: 1; left: 659px; top: 598px; position: absolute" Text="All connections" />
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
        <asp:Button ID="Button11" runat="server" style="z-index: 1; left: 647px; top: 439px; position: absolute; right: 269px" Text="Reissue" />
        <p>
            <asp:Button ID="Button12" runat="server" style="z-index: 1; left: 749px; top: 440px; position: absolute" Text="Refund" />
        </p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 300px; top: 601px; position: absolute" Text="Need more? Find connections:"></asp:Label>
        <p>
            <asp:Button ID="Button13" runat="server" style="z-index: 1; left: 400px; top: 339px; position: absolute" Text="Homepage" />
            <asp:Button ID="Button14" runat="server" style="z-index: 1; left: 518px; top: 340px; position: absolute" Text="All connections" />
        </p>
    </form>
</body>
</html>
