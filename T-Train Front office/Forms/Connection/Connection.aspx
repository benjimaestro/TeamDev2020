<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connection.aspx.cs" Inherits="T_Train_Front_office.Forms.Connection.Connection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 876px; top: 27px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 359px; top: 698px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="Button1_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 723px; top: 27px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 222px; top: 26px; position: absolute" Text="T-Train"></asp:Label>
        </p>
        <div>
        </div>
        <asp:Label ID="lblModifyHeader" runat="server" Font-Size="X-Large" style="z-index: 1; left: 45px; top: 139px; position: absolute" Text="You are modifying this connection:" Visible="False"></asp:Label>
        <p>
        <asp:Label ID="lblModDate" runat="server" style="z-index: 1; left: 350px; top: 197px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="lblModPublic" runat="server" style="z-index: 1; left: 548px; top: 199px; position: absolute; " Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblModLocation" runat="server" style="z-index: 1; left: 171px; top: 196px; position: absolute" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="lblModTickets" runat="server" style="z-index: 1; left: 779px; top: 200px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="lblModAdded" runat="server" style="z-index: 1; left: 718px; top: 241px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="lblActionName" runat="server" Font-Size="X-Large" style="z-index: 1; left: 45px; top: 281px; position: absolute" Text="Connection:"></asp:Label>
        <p>
        <asp:Label ID="lblModTime" runat="server" style="z-index: 1; left: 448px; top: 199px; position: absolute; right: 445px; width: 86px;" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="lblModId" runat="server" style="z-index: 1; left: 77px; top: 197px; position: absolute" Visible="False"></asp:Label>
            <asp:Label ID="lblTicketLimit0" runat="server" style="z-index: 1; left: 748px; top: 387px; position: absolute; height: 76px;" Text="Ticket limit:/Tickets remaining:"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblStaticId" runat="server" style="z-index: 1; left: 49px; top: 198px; position: absolute; width: 44px;" Visible="False">ID:</asp:Label>
        </p>
        <p>
            <asp:Label ID="lblStaticModLimit" runat="server" style="z-index: 1; left: 657px; top: 198px; position: absolute; height: 25px;" Text="Tickets remaining:" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtTicketLimit" runat="server" style="z-index: 1; left: 777px; top: 421px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDelete" runat="server" Font-Size="Large" style="z-index: 1; left: 65px; top: 644px; position: absolute" Text="You can also:" Visible="False"></asp:Label>
            <asp:Button ID="btnDelConnection" runat="server" style="z-index: 1; left: 190px; top: 643px; position: absolute" Text="Delete Connection" OnClick="btnDelConnection_Click" Visible="False" />
        </p>
        <p>
            <asp:Button ID="btnSaveConnection" runat="server" style="z-index: 1; left: 411px; top: 544px; position: absolute" Text="Add connection/Save changes" OnClick="Button5_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 129px; top: 385px; position: absolute; " Text="From:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 473px; top: 385px; position: absolute; right: 467px;" Text="To:"></asp:Label>
        <asp:DropDownList ID="ddlFrom" runat="server" style="z-index: 1; left: 212px; top: 385px; position: absolute; ">
            <asp:ListItem>Leicester</asp:ListItem>
            <asp:ListItem>Birmingham</asp:ListItem>
            <asp:ListItem>Glasgow</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Cambridge</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 133px; top: 497px; position: absolute" Text="Date:"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 200px; top: 495px; position: absolute; margin-bottom: 5px; right: 628px;"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 501px; top: 496px; position: absolute" Text="Time:"></asp:Label>
        <asp:Label ID="Label6" runat="server" Font-Size="X-Large" style="z-index: 1; left: 366px; top: 379px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 87px; top: 441px; position: absolute" Text="Departure Date &amp; Time:"></asp:Label>
        <asp:Calendar ID="dtpDate" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" OnSelectionChanged="Calendar1_SelectionChanged" style="z-index: 1; left: 148px; top: 540px; position: absolute; height: 188px; width: 259px" Width="330px" Visible="False">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <asp:Button ID="btnPick" runat="server" OnClick="btnPick_Click" style="z-index: 1; left: 368px; top: 493px; position: absolute; height: 26px" Text="Pick" />
        <asp:DropDownList ID="ddlTime" runat="server" style="z-index: 1; left: 571px; top: 494px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 88px; top: 343px; position: absolute" Text="Departure station:"></asp:Label>
        <asp:DropDownList ID="ddlTo" runat="server" style="z-index: 1; left: 544px; top: 384px; position: absolute">
            <asp:ListItem>Leicester</asp:ListItem>
            <asp:ListItem>Birmingham</asp:ListItem>
            <asp:ListItem>Glasgow</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Cambridge</asp:ListItem>
        </asp:DropDownList>
        </p>
        <asp:CheckBox ID="chkConnActive" runat="server" style="z-index: 1; left: 755px; top: 487px; position: absolute" Text="Active Immediately?" />
    </form>
</body>
</html>
