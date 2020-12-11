<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="T_Train_Front_office.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 348px; top: 455px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" />
            <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 856px; top: 36px; position: absolute" Text="Signup" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 489px; top: 396px; position: absolute" Text="Signup" />
        </p>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 392px; top: 118px; position: absolute" Text="Login to your account now"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 395px; top: 226px; position: absolute; height: 19px; right: 529px;" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 469px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 381px; top: 266px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 468px; top: 267px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 449px; top: 316px; position: absolute" Text="Login" />
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 403px; top: 353px; position: absolute" Text="Lost password?" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 351px; top: 402px; position: absolute; right: 493px;" Text="Not yet registered?"></asp:Label>
    </form>
</body>
</html>
