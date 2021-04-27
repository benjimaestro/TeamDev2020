<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 193px; top: 29px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="lblLogoutNotice" runat="server" style="z-index: 1; left: 187px; top: 139px; position: absolute; width: 626px;" Text="You were logged out.&lt;br&gt;If you did not press the button to log out, most likely, your session expired.&lt;br&gt;If this is the case, please log in again.&lt;br&gt;If you are not yet registered, feel free to create a free account and enjoy fussle-free train ticket booking service!" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 375px; top: 293px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 729px; top: 29px; position: absolute; " Text="Login" OnClick="Button3_Click" Font-Size="X-Large" />
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 829px; top: 29px; position: absolute; right: -25px;" Text="Register" OnClick="Button2_Click" Font-Size="X-Large" />
        </div>
    </form>
</body>
</html>
