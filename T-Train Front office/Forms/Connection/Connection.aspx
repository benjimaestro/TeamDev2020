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
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 377px; top: 589px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="Button1_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 723px; top: 27px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 222px; top: 26px; position: absolute" Text="T-Train"></asp:Label>
        </p>
        <div>
        </div>
        <asp:Label ID="lblModifyHeader" runat="server" Font-Size="X-Large" style="z-index: 1; left: 45px; top: 139px; position: absolute" Text="You are modifying this connection:" Visible="False"></asp:Label>
        <p>
        <asp:Label ID="lblModDate" runat="server" style="z-index: 1; left: 350px; top: 197px; position: absolute" Text="12/06/2021" Visible="False"></asp:Label>
        <asp:Label ID="lblModTime" runat="server" style="z-index: 1; left: 530px; top: 199px; position: absolute; right: 620px;" Text="14:25" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblModLocation" runat="server" style="z-index: 1; left: 150px; top: 199px; position: absolute" Text="Leicester - Birmingham" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="lblModTickets" runat="server" style="z-index: 1; left: 665px; top: 200px; position: absolute" Text="37 tickets remaining" Visible="False"></asp:Label>
        <asp:Label ID="lblModAdded" runat="server" style="z-index: 1; left: 718px; top: 241px; position: absolute" Text="Connection added at: 14/05/2021" Visible="False"></asp:Label>
        <asp:Label ID="lblActionName" runat="server" Font-Size="X-Large" style="z-index: 1; left: 46px; top: 264px; position: absolute" Text="Connection:"></asp:Label>
        <p>
        <asp:Label ID="lblFrom" runat="server" style="z-index: 1; left: 113px; top: 339px; position: absolute" Text="From:"></asp:Label>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 176px; top: 338px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="lblModId" runat="server" style="z-index: 1; left: 63px; top: 202px; position: absolute" Text="ID: 16" Visible="False"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTo" runat="server" style="z-index: 1; left: 464px; top: 342px; position: absolute" Text="To:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 520px; top: 341px; position: absolute">
        </asp:DropDownList>
        <p>
        <asp:Label ID="lblConnector" runat="server" Font-Size="X-Large" style="z-index: 1; left: 343px; top: 339px; position: absolute" Text="&lt;=&gt;"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 116px; top: 383px; position: absolute" Text="Date:"></asp:Label>
            <asp:Label ID="lblTicketLimit" runat="server" style="z-index: 1; left: 734px; top: 344px; position: absolute" Text="Ticket limit:/Tickets remaining:"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 183px; top: 383px; position: absolute; margin-bottom: 5px"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblTime" runat="server" style="z-index: 1; left: 455px; top: 383px; position: absolute" Text="Time:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 770px; top: 376px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDelete" runat="server" Font-Size="Large" style="z-index: 1; left: 52px; top: 535px; position: absolute" Text="You can also:" Visible="False"></asp:Label>
            <asp:Button ID="btnDelConnection" runat="server" style="z-index: 1; left: 171px; top: 532px; position: absolute" Text="Delete Connection" OnClick="btnDelConnection_Click" Visible="False" />
        </p>
        <p>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 529px; top: 384px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnSaveConnection" runat="server" style="z-index: 1; left: 475px; top: 448px; position: absolute" Text="Add connection/Save changes" OnClick="Button5_Click" />
        </p>
    </form>
</body>
</html>
