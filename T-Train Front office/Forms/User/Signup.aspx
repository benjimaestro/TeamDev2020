<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="T_Train_Front_office.Forms.User.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 363px; top: 465px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
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
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 82px; top: 180px; position: absolute; height: 19px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 214px; top: 180px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 82px; top: 220px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 214px; top: 220px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 444px; top: 348px; position: absolute" Text="Register" OnClick="btnSignup_Click" Font-Size="Large" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 309px; top: 409px; position: absolute" Text="Already registered?"></asp:Label>
            <asp:Button ID="btnLogin2" runat="server" style="z-index: 1; left: 466px; top: 409px; position: absolute" Text="Login" OnClick="btnLogin2_Click" />
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 425px; top: 260px; position: absolute" Text="Date of Birth:"></asp:Label>
        </p>
        <asp:Label ID="lblMissingData" runat="server" style="z-index: 1; left: 424px; top: 308px; position: absolute" Text="All fields are required!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:TextBox ID="txtRepeatPassword" runat="server" style="z-index: 1; left: 214px; top: 260px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 425px; top: 180px; position: absolute" Text="First Name:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 425px; top: 220px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 708px; top: 180px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 527px; top: 180px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 527px; top: 220px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 708px; top: 220px; position: absolute; height: 54px;" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 527px; top: 260px; position: absolute"></asp:TextBox>
        <p>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 82px; top: 260px; position: absolute" Text="Repeat Password:"></asp:Label>
        <asp:Label ID="lblPasswordMitmatch" runat="server" style="z-index: 1; left: 82px; top: 308px; position: absolute" Text="Given passwords are not identical!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Label ID="lblEmailExists" runat="server" style="z-index: 1; left: 32px; top: 113px; position: absolute; height: 60px; width: 340px; bottom: 324px;" Text="There already exists an account registered with this email. Press the Forgot Password button to try and recover your account!" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Button ID="btnResetPassword" runat="server" style="z-index: 1; left: 546px; top: 409px; position: absolute" Text="Forgot Password?" OnClick="btnResetPassword_Click" />
        <asp:Label ID="lblPasswordInsecure" runat="server" style="z-index: 1; left: 3px; top: 330px; position: absolute" Text="Password must contain at least 1 number and 1 special character." Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
