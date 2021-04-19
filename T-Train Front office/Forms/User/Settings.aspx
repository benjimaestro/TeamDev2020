<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 464px; top: 21px; position: absolute" Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 31px; top: 21px; position: absolute; right: 835px;" Text="Homepage" OnClick="btnHomepage_Click" />
            <asp:Button ID="btnTickets" runat="server" style="z-index: 1; left: 618px; top: 21px; position: absolute; " Text="My tickets" OnClick="btnTickets_Click" />
        <asp:Button ID="btnSettings" runat="server" style="z-index: 1; left: 728px; top: 20px; position: absolute" Text="Account settings" OnClick="btnSettings_Click" />
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 187px; top: 15px; position: absolute" Text="T-Train"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 370px; top: 1368px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
            <asp:Label ID="Label26" runat="server" style="z-index: 1; left: 262px; top: 958px; position: absolute" Text="Two-Factor Authentication is currently:"></asp:Label>
        </div>
        <asp:Label ID="Label19" runat="server" style="z-index: 1; left: 381px; top: 115px; position: absolute" Text="Change your account settings here" Font-Bold="True"></asp:Label>
        <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 413px; top: 216px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 467px; top: 217px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 365px; top: 380px; position: absolute; right: 490px;" Text="Current Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 522px; top: 381px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 387px; top: 647px; position: absolute" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 484px; top: 648px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 384px; top: 687px; position: absolute" Text="Last Name:"></asp:Label>
            <asp:Label ID="lblDetailsChanged" runat="server" Font-Size="Large" style="z-index: 1; left: 57px; top: 709px; position: absolute" Text="Your details were updated!" ForeColor="#009933" Visible="False"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 489px; top: 688px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 389px; top: 789px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 489px; top: 739px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 374px; top: 737px; position: absolute" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtNewPassRep" runat="server" style="z-index: 1; left: 522px; top: 483px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 335px; top: 482px; position: absolute" Text="Repeat New Password:"></asp:Label>
        <asp:TextBox ID="txtNewPass" runat="server" style="z-index: 1; left: 524px; top: 427px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnPassword" runat="server" style="z-index: 1; left: 406px; top: 534px; position: absolute" Text="Update Password" OnClick="btnPassword_Click" />
        </p>
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 159px; top: 258px; position: absolute" Text="You cannot change your email address. If you wish to use a different email, please register a new account." Font-Bold="True"></asp:Label>
        <asp:Label ID="Label21" runat="server" Font-Size="Large" style="z-index: 1; left: 431px; top: 164px; position: absolute" Text="Email address"></asp:Label>
        <asp:Label ID="Label22" runat="server" Font-Size="Large" style="z-index: 1; left: 378px; top: 906px; position: absolute" Text="Two-Factor Authentication"></asp:Label>
        <asp:Label ID="Label23" runat="server" Font-Size="Large" style="z-index: 1; left: 453px; top: 326px; position: absolute" Text="Password" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 380px; top: 432px; position: absolute" Text="New Password:"></asp:Label>
        <asp:Button ID="btnDeleteAccount" runat="server" style="z-index: 1; left: 419px; top: 1275px; position: absolute" Text="Delete Account" OnClick="Button6_Click" />
        <p>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 482px; top: 789px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnDetails" runat="server" style="z-index: 1; left: 431px; top: 839px; position: absolute" Text="Save Details" OnClick="btnDetails_Click" />
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 532px; top: 957px; position: absolute" Text="Disabled" />
        <asp:CheckBox ID="CheckBox2" runat="server" Checked="True" style="z-index: 1; left: 652px; top: 956px; position: absolute" Text="Enabled" />
        <asp:Button ID="btnTwoFactor" runat="server" style="z-index: 1; left: 395px; top: 1009px; position: absolute" Text="Enable/Disable 2FA" OnClick="Button6_Click" />
        <asp:Label ID="Label27" runat="server" Font-Size="Large" style="z-index: 1; left: 416px; top: 1085px; position: absolute" Text="Delete Account"></asp:Label>
        <asp:Label ID="Label28" runat="server" style="z-index: 1; left: 144px; top: 1123px; position: absolute; width: 702px; margin-bottom: 4px" Text="This decision cannot be reverted. Make absolutely sure you wish to proceed. Every time T-Train introduces changes to the Terms of Service, you will be offered this option first. Deleted accounts are not recoverable. Your account will never expire and your details will never be sold. Please proceed only if you do not agree with the current Terms of Service. Once initiated, the procedure will take 14 days to finish and it will be stopped if you press the button here again. You may not book new tickets while your account is pending deletion."></asp:Label>
        <asp:Label ID="Label29" runat="server" style="z-index: 1; left: 349px; top: 1234px; position: absolute" Text="Current password:"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 485px; top: 1232px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 892px; top: 21px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <p>
            <asp:Label ID="Label30" runat="server" Font-Size="Large" style="z-index: 1; left: 422px; top: 601px; position: absolute" Text="Personal Details"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPasswordError" runat="server" Font-Size="Large" style="z-index: 1; left: 56px; top: 430px; position: absolute" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
