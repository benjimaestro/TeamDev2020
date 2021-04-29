<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="T_Train_Front_office.Forms.User.ResetPassword1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 314px; top: 59px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 316px; top: 110px; position: absolute" Text="Fill the form below to reset your password."></asp:Label>
        </div>
        <p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 336px; top: 168px; position: absolute; right: 526px;" Text="Reset code:"></asp:Label>
        <asp:TextBox ID="txtResetCode" runat="server" style="z-index: 1; left: 450px; top: 168px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 321px; top: 293px; position: absolute" Text="New Password:"></asp:Label>
        <asp:TextBox ID="txtNewPass" runat="server" style="z-index: 1; left: 456px; top: 293px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 275px; top: 345px; position: absolute" Text="Repeat New Password:"></asp:Label>
        <asp:TextBox ID="txtNewPassRep" runat="server" style="z-index: 1; left: 456px; top: 345px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblPasswordError" runat="server" Font-Size="Large" style="z-index: 1; left: 49px; top: 134px; position: absolute" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnPassword" runat="server" style="z-index: 1; left: 388px; top: 399px; position: absolute" Text="Reset Password" OnClick="btnPassword_Click" />
        <asp:Label ID="Label25" runat="server" style="z-index: 1; left: 270px; top: 210px; position: absolute; right: 320px; height: 59px;" Text="You will have received a special code to your email&lt;br&gt;address. Type that code into the box above to&lt;br&gt;confirm the account belongs to you." Font-Bold="True"></asp:Label>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 347px; top: 450px; position: absolute; right: 362px;" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
            </p>
    </form>
</body>
</html>
