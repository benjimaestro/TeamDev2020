﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 350px; top: 450px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        </p>
        <div>
        </div>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to T-Train"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 399px; top: 112px; position: absolute" Text="Create your account now"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 32px; top: 29px; position: absolute; right: 834px;" Text="Homepage" OnClick="btnHomepage_Click" />
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 156px; top: 181px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 217px; top: 180px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 126px; top: 219px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 218px; top: 221px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 421px; top: 333px; position: absolute" Text="Register" OnClick="btnSignup_Click" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 351px; top: 402px; position: absolute" Text="Already registered?"></asp:Label>
            <asp:Button ID="btnLogin2" runat="server" style="z-index: 1; left: 484px; top: 398px; position: absolute" Text="Login" OnClick="btnLogin2_Click" />
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 729px; top: 189px; position: absolute" Text="Date of Birth:"></asp:Label>
        </p>
        <asp:Label ID="lblMissingData" runat="server" style="z-index: 1; left: 712px; top: 272px; position: absolute" Text="All fields are required!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:TextBox ID="txtRepeatPassword" runat="server" style="z-index: 1; left: 214px; top: 265px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 437px; top: 184px; position: absolute" Text="First Name:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 440px; top: 222px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 442px; top: 267px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 528px; top: 184px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 530px; top: 223px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 525px; top: 270px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 736px; top: 220px; position: absolute"></asp:TextBox>
        <p>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 82px; top: 267px; position: absolute" Text="Repeat Password:"></asp:Label>
        <asp:Label ID="lblPasswordMitmatch" runat="server" style="z-index: 1; left: 98px; top: 308px; position: absolute" Text="Given passwords are not identical!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Label ID="lblEmailExists" runat="server" style="z-index: 1; left: 34px; top: 113px; position: absolute; height: 60px; width: 340px; bottom: 324px;" Text="There already exists an account registered with this email. Press the Forgot Password button to try and recover your account!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Button ID="btnResetPassword" runat="server" style="z-index: 1; left: 551px; top: 400px; position: absolute" Text="Forgot password?" OnClick="btnResetPassword_Click" />
        </p>
    </form>
</body>
</html>
