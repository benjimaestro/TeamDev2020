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
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 193px; top: 23px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="lblLogoutNotice" runat="server" style="z-index: 1; left: 158px; top: 147px; position: absolute; width: 626px;" Text="Something went wrong and you were logged out. Most likely, your session expired. Please log in again. If you are not yet registered, feel free to create a free account and enjoy fussle-free train ticket booking service!" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 390px; top: 368px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 744px; top: 30px; position: absolute; " Text="Login" OnClick="Button3_Click" Font-Size="X-Large" />
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 837px; top: 31px; position: absolute; right: 288px;" Text="Register" OnClick="Button2_Click" Font-Size="X-Large" />
        </div>
    </form>
</body>
</html>
