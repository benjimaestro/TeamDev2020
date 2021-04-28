<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T_Train_Front_office.Forms.Defaul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 837px; top: 31px; position: absolute; right: 288px;" Text="Register" OnClick="Button2_Click" Font-Size="X-Large" />
        </div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 381px; top: 70px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="lblHeaderSubtitle" runat="server" Font-Size="Large" style="z-index: 1; left: 437px; top: 122px; position: absolute" Text="Book tickets now!"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 158px; position: absolute" Text="Find your connection:"></asp:Label>
        <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 19px; top: 31px; position: absolute" Text="Staff Dashboard" OnClick="Button9_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 911px; top: 31px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <asp:Label ID="lblError" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Red" style="z-index: 1; left: 315px; top: 187px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 618px; top: 31px; position: absolute; " Text="My tickets" OnClick="Button7_Click"/>
        </p>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 744px; top: 31px; position: absolute; " Text="Login" OnClick="Button3_Click" Font-Size="X-Large" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 126px; top: 231px; position: absolute; " Text="From:"></asp:Label>
        <asp:DropDownList ID="ddlFrom" runat="server" style="z-index: 1; left: 185px; top: 231px; position: absolute; right: 698px;">
            <asp:ListItem>Leicester</asp:ListItem>
            <asp:ListItem>Birmingham</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Glasgow</asp:ListItem>
            <asp:ListItem>Cambridge</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 441px; top: 231px; position: absolute; right: 717px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="ddlTo" runat="server" style="z-index: 1; left: 481px; top: 231px; position: absolute">
            <asp:ListItem>Leicester</asp:ListItem>
            <asp:ListItem>Birmingham</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Cambridge</asp:ListItem>
            <asp:ListItem>Glasgow</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 115px; top: 318px; position: absolute" Text="Date:"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 183px; top: 318px; position: absolute; margin-bottom: 5px; right: 645px;"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 435px; top: 318px; position: absolute" Text="Time:"></asp:Label>
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" style="z-index: 1; left: 334px; top: 231px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 74px; top: 278px; position: absolute" Text="Departure Date &amp; Time:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 74px; top: 196px; position: absolute; bottom: 177px; height: 20px;" Text="Departure station:"></asp:Label>
        <asp:Button ID="btnFilterConnections" runat="server" style="z-index: 1; left: 732px; top: 288px; position: absolute" Text="Search Connections" OnClick="btnFilterConnections_Click" />
        <asp:Button ID="btnConnections" runat="server" style="z-index: 1; left: 755px; top: 247px; position: absolute" Text="All Connections" OnClick="btnConnections_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 751px; top: 31px; position: absolute" Text="Account Settings" OnClick="Button8_Click" />
        <asp:Calendar ID="dtpDate" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" OnSelectionChanged="Calendar1_SelectionChanged" style="z-index: 1; left: 121px; top: 357px; position: absolute; height: 188px; width: 259px" Width="330px" Visible="False">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <asp:Button ID="btnPick" runat="server" OnClick="btnPick_Click" style="z-index: 1; left: 348px; top: 318px; position: absolute; height: 26px" Text="Pick" />
        <asp:DropDownList ID="ddlTime" runat="server" style="z-index: 1; left: 493px; top: 318px; position: absolute">
        </asp:DropDownList>
    <p>
        &nbsp;</p>
        <p>
        <asp:Label ID="lblLoggedIn" runat="server" Font-Size="Large" style="z-index: 1; left: 325px; top: 31px; position: absolute" Text="You are now logged in!" ForeColor="#009933" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 395px; top: 394px; position: absolute; height: 105px; width: 196px" Text="T-Train London Rd. 15, Leicester, LE6 8OB, Leicestershire, Great Britain, Email: customer@ttrain.com, Mobile: +44 07491749173"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 372px; top: 509px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
    </form>
    </body>
</html>
