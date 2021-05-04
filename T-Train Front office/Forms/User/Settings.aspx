<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 31px; top: 59px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" Visible="False" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 741px; top: 21px; position: absolute; " Text="My Tickets" OnClick="btnTickets_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 187px; top: 21px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 368px; top: 1393px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
            <asp:Label ID="Label26" runat="server" style="z-index: 1; left: 321px; top: 939px; position: absolute" Text="Two-Factor Authentication is currently:"></asp:Label>
        
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 362px; top: 115px; position: absolute" Text="Change your account settings here" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 413px; top: 216px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 467px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 335px; top: 380px; position: absolute; right: 533px;" Text="Current Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 522px; top: 380px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 374px; top: 647px; position: absolute" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 484px; top: 647px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 374px; top: 687px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblDetailsChanged" runat="server" Font-Size="Large" style="z-index: 1; left: 57px; top: 709px; position: absolute" Text="Your details were updated!" ForeColor="#009933" Visible="False"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 484px; top: 687px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 374px; top: 767px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 484px; top: 727px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 374px; top: 727px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtNewPassRep" runat="server" style="z-index: 1; left: 522px; top: 482px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 335px; top: 482px; position: absolute" Text="Repeat New Password:"></asp:Label>
        <asp:TextBox ID="txtNewPass" runat="server" style="z-index: 1; left: 522px; top: 432px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnPassword" runat="server" style="z-index: 1; left: 406px; top: 534px; position: absolute" Text="Update Password" OnClick="btnPassword_Click" />
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 159px; top: 266px; position: absolute" Text="You cannot change your email address. If you wish to use a different email, please register a new account." Font-Bold="True"></asp:Label>
        <asp:Label ID="Label21" runat="server" Font-Size="Large" style="z-index: 1; left: 431px; top: 164px; position: absolute" Text="Email address" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label22" runat="server" Font-Size="Large" style="z-index: 1; left: 387px; top: 877px; position: absolute" Text="Two-Factor Authentication" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label23" runat="server" Font-Size="Large" style="z-index: 1; left: 451px; top: 326px; position: absolute" Text="Password" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 335px; top: 432px; position: absolute" Text="New Password:"></asp:Label>
        <asp:Button ID="btnDeleteAccount" runat="server" style="z-index: 1; left: 419px; top: 1316px; position: absolute" Text="Delete Account" OnClick="btnDeleteAccount_Click" />
        <p>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 484px; top: 767px; position: absolute; height: 47px;" TextMode="MultiLine"></asp:TextBox>
        </p>
        <asp:Button ID="btnDetails" runat="server" style="z-index: 1; left: 431px; top: 835px; position: absolute" Text="Save Details" OnClick="btnDetails_Click" />
        <asp:CheckBox ID="chkTwoFactor" runat="server" style="z-index: 1; left: 575px; top: 939px; position: absolute" Text="Disabled" Enabled="False" />
        <asp:Button ID="btnTwoFactor" runat="server" style="z-index: 1; left: 415px; top: 1015px; position: absolute" Text="Enable/Disable 2FA" OnClick="Button6_Click" />
        <asp:Label ID="Label27" runat="server" Font-Size="Large" style="z-index: 1; left: 424px; top: 1063px; position: absolute" Text="Delete Account" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label28" runat="server" style="z-index: 1; left: 144px; top: 1112px; position: absolute; width: 702px; margin-bottom: 4px" Text="If you wish to delete your account, enter your password below and press the button. You will have 2 weeks to cancel the operation. If you wish to do so, simply press the button again. After exactly 2 weeks have passed you must attempt to login into your account - this way you give final confirmation and you will receive a success message. Your account can still be recovered before this final confirmation."></asp:Label>
        <asp:Label ID="Label29" runat="server" style="z-index: 1; left: 342px; top: 1276px; position: absolute" Text="Current password:"></asp:Label>
        <asp:TextBox ID="txtDelete" runat="server" style="z-index: 1; left: 485px; top: 1276px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 857px; top: 21px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <p>
            <asp:Label ID="Label30" runat="server" Font-Size="Large" style="z-index: 1; left: 422px; top: 601px; position: absolute" Text="Personal Details" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPasswordError" runat="server" Font-Size="Large" style="z-index: 1; left: 700px; top: 380px; position: absolute" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblTwoFactor" runat="server" style="z-index: 1; left: 380px; top: 978px; position: absolute" Text="2FA Code:"></asp:Label>
            <asp:TextBox ID="txtTwoFactorCode" runat="server" style="z-index: 1; left: 469px; top: 978px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label31" runat="server" style="z-index: 1; left: 106px; top: 905px; position: absolute" Text="2FA adds an extra piece of security: an 8 digit long code. Once enabled, you will be required to enter the code as you login."></asp:Label>
            <asp:Label ID="lblCodeLength" runat="server" ForeColor="Red" style="z-index: 1; left: 41px; top: 990px; position: absolute" Text="The 2FA Code must be exactly 8 digits long." Visible="False"></asp:Label>
            <asp:Label ID="lblCodeDigits" runat="server" ForeColor="Red" style="z-index: 1; left: 41px; top: 957px; position: absolute" Text="The 2FA Code must only use digits." Visible="False"></asp:Label>
            <asp:Label ID="lblTwoFactorDone" runat="server" Font-Size="Large" style="z-index: 1; left: 86px; top: 1027px; position: absolute" Text="2FA was updated!" ForeColor="#009933" Visible="False"></asp:Label>
        </p>
            <asp:Label ID="lblDeletionError" runat="server" Font-Size="Large" style="z-index: 1; left: 69px; top: 1327px; position: absolute" ForeColor="Red"></asp:Label>
            <p>
                &nbsp;</p>
            <p>
            <asp:Label ID="lblDeletionSuccess" runat="server" Font-Size="Large" style="z-index: 1; left: 59px; top: 1291px; position: absolute" ForeColor="#009933" Visible="False"></asp:Label>
            </p>
            <p>
        <asp:Label ID="lblDeletionStatus" runat="server" style="z-index: 1; left: 403px; top: 1233px; position: absolute" Text="Deletion Status: Off"></asp:Label>
            </p>
    </form>
</body>
</html>
