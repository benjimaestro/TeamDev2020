<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="T_Train_Front_office.Forms.User.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 372px; top: 455px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
        </p>
        <div>
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 371px; top: 113px; position: absolute" Text="Reset the password to your account"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 365px; top: 180px; position: absolute; right: 384px;" Text="Please enter a valid email address!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 375px; top: 226px; position: absolute; height: 19px; right: 550px;" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 449px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnResetPassword" runat="server" style="z-index: 1; left: 416px; top: 272px; position: absolute; height: 26px;" Text="Reset Password" OnClick="btnResetPassword_Click" />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 547px; top: 351px; position: absolute" Text="Login" />
        </p>
        <p>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 365px; top: 396px; position: absolute; right: 444px;" Text="Not yet registered?"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 365px; top: 351px; position: absolute; right: 407px;" Text="Clicked here on accident?"></asp:Label>
        </p>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 522px; top: 396px; position: absolute" Text="Register" OnClick="btnSignup2_Click" />
    </form>
</body>
</html>
