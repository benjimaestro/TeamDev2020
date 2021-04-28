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
            <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 542px; top: 351px; position: absolute; height: 27px; width: 53px;" Text="Login" OnClick="btnLogin_Click" />
        </p>
        <div>
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 379px; top: 113px; position: absolute" Text="Reset the password to your account"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 365px; top: 180px; position: absolute; right: 384px;" Text="Please enter a valid email address!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 395px; top: 226px; position: absolute; height: 19px; right: 550px;" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 469px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnResetPassword" runat="server" style="z-index: 1; left: 416px; top: 272px; position: absolute; height: 26px;" Text="Reset Password" OnClick="btnResetPassword_Click" />
        </p>
        <p>
            <asp:Button ID="btnSignup2" runat="server" style="z-index: 1; left: 523px; top: 396px; position: absolute; height: 25px; width: 73px; margin-top: 0px;" Text="Register" OnClick="btnSignup2_Click" />
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 365px; top: 396px; position: absolute; right: 496px;" Text="Not yet registered?"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 365px; top: 351px; position: absolute; right: 454px;" Text="Clicked here on accident?"></asp:Label>
        </p>
    </form>
</body>
</html>
