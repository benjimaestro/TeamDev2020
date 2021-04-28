<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form2 {
            height: 1397px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 31px; top: 59px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" Visible="False" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 741px; top: 21px; position: absolute; " Text="My Tickets" OnClick="btnTickets_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 187px; top: 21px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 370px; top: 1339px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
            <asp:Label ID="Label26" runat="server" style="z-index: 1; left: 321px; top: 939px; position: absolute" Text="Two-Factor Authentication is currently:"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 362px; top: 115px; position: absolute" Text="Change your account settings here" Font-Bold="True" Font-Size="Large"></asp:Label>
        <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 413px; top: 216px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 467px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 335px; top: 380px; position: absolute; right: 533px;" Text="Current Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 522px; top: 380px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 374px; top: 647px; position: absolute" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 484px; top: 647px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 374px; top: 687px; position: absolute" Text="Last Name:"></asp:Label>
            <asp:Label ID="lblDetailsChanged" runat="server" Font-Size="Large" style="z-index: 1; left: 57px; top: 709px; position: absolute" Text="Your details were updated!" ForeColor="#009933" Visible="False"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 484px; top: 687px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 374px; top: 767px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 484px; top: 727px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 374px; top: 727px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtNewPassRep" runat="server" style="z-index: 1; left: 522px; top: 482px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 335px; top: 482px; position: absolute" Text="Repeat New Password:"></asp:Label>
        <asp:TextBox ID="txtNewPass" runat="server" style="z-index: 1; left: 522px; top: 432px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnPassword" runat="server" style="z-index: 1; left: 406px; top: 534px; position: absolute" Text="Update Password" OnClick="btnPassword_Click" />
        </p>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 159px; top: 266px; position: absolute" Text="You cannot change your email address. If you wish to use a different email, please register a new account." Font-Bold="True"></asp:Label>
        <asp:Label ID="Label21" runat="server" Font-Size="Large" style="z-index: 1; left: 431px; top: 164px; position: absolute" Text="Email address" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label22" runat="server" Font-Size="Large" style="z-index: 1; left: 387px; top: 877px; position: absolute" Text="Two-Factor Authentication" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label23" runat="server" Font-Size="Large" style="z-index: 1; left: 451px; top: 326px; position: absolute" Text="Password" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 335px; top: 432px; position: absolute" Text="New Password:"></asp:Label>
        <asp:Button ID="btnDeleteAccount" runat="server" style="z-index: 1; left: 419px; top: 1275px; position: absolute" Text="Delete Account" OnClick="Button6_Click" />
        <p>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 484px; top: 767px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnDetails" runat="server" style="z-index: 1; left: 431px; top: 811px; position: absolute" Text="Save Details" OnClick="btnDetails_Click" />
        <asp:CheckBox ID="chkTwoFactor" runat="server" style="z-index: 1; left: 575px; top: 939px; position: absolute" Text="Disabled" Enabled="False" />
        <asp:Button ID="btnTwoFactor" runat="server" style="z-index: 1; left: 395px; top: 1015px; position: absolute" Text="Enable/Disable 2FA" OnClick="Button6_Click" />
        <asp:Label ID="Label27" runat="server" Font-Size="Large" style="z-index: 1; left: 424px; top: 1063px; position: absolute" Text="Delete Account" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label28" runat="server" style="z-index: 1; left: 144px; top: 1105px; position: absolute; width: 702px; margin-bottom: 4px" Text="This decision cannot be reverted. Make absolutely sure you wish to proceed. Every time T-Train introduces changes to the Terms of Service, you will be offered this option first. Deleted accounts are not recoverable. Your account will never expire and your details will never be sold. Please proceed only if you do not agree with the current Terms of Service. Once initiated, the procedure will take 14 days to finish and it will be stopped if you press the button here again. You may not book new tickets while your account is pending deletion."></asp:Label>
        <asp:Label ID="Label29" runat="server" style="z-index: 1; left: 345px; top: 1227px; position: absolute" Text="Current password:"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 485px; top: 1227px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 857px; top: 21px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <p>
            <asp:Label ID="Label30" runat="server" Font-Size="Large" style="z-index: 1; left: 422px; top: 601px; position: absolute" Text="Personal Details" Font-Bold="True"></asp:Label>
        </p>
        <p style="height: 1188px">
            <asp:Label ID="lblPasswordError" runat="server" Font-Size="Large" style="z-index: 1; left: 56px; top: 430px; position: absolute" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblTwoFactor" runat="server" style="z-index: 1; left: 380px; top: 978px; position: absolute" Text="2FA Code:"></asp:Label>
            <asp:TextBox ID="txtTwoFactorCode" runat="server" style="z-index: 1; left: 469px; top: 978px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label31" runat="server" style="z-index: 1; left: 106px; top: 905px; position: absolute" Text="2FA adds an extra piece of security: an 8 digit long code. Once enabled, you will be required to enter the code as you log in."></asp:Label>
            <asp:Label ID="lblCodeLength" runat="server" ForeColor="Red" style="z-index: 1; left: 41px; top: 990px; position: absolute" Text="The 2FA Code must be exactly 8 digits long." Visible="False"></asp:Label>
            <asp:Label ID="lblCodeDigits" runat="server" ForeColor="Red" style="z-index: 1; left: 41px; top: 957px; position: absolute" Text="The 2FA Code must only use digits." Visible="False"></asp:Label>
            <asp:Label ID="lblTwoFactorDone" runat="server" Font-Size="Large" style="z-index: 1; left: 86px; top: 1027px; position: absolute" Text="2FA was updated!" ForeColor="#009933" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
