<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogIn.aspx.cs" Inherits="LaptopLoanProjectt.UserLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            text-align: right;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
        <div>
        </div>
            <p>
                &nbsp;</p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 9px; position: absolute" Text="Laptop Loan System"></asp:Label>
            <asp:Label ID="lblUserRegistration" runat="server" style="z-index: 1; left: 452px; top: 55px; position: absolute" Text="User Registration Form"></asp:Label>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 479px; top: 128px; position: absolute"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 479px; top: 124px; position: absolute; margin-top: 38px"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:Label ID="lblLaptopUserFirstName" runat="server" style="z-index: 1; left: 390px; top: 125px; position: absolute" Text="First Name:"></asp:Label>
            <asp:Label ID="lblLaptopUserLastName" runat="server" style="z-index: 1; left: 395px; top: 164px; position: absolute" Text="Last Name:"></asp:Label>
            <asp:Label ID="lblLaptopUserEmail" runat="server" style="z-index: 1; left: 373px; position: absolute; bottom: 522px; top: 204px" Text="Email Address:"></asp:Label>
            <asp:Label ID="lblLaptopUserAddress" runat="server" style="z-index: 1; left: 418px; top: 246px; position: absolute" Text="Address:"></asp:Label>
            <asp:Label ID="lblLaptopUserPassword" runat="server" style="z-index: 1; left: 398px; top: 285px; position: absolute" Text="Password:"></asp:Label>
            <asp:Label ID="lblconfirmpassword" runat="server" style="z-index: 1; left: 352px; top: 325px; position: absolute" Text="Confirm Password:"></asp:Label>
            <asp:Label ID="lblLaptopUserTelephoneNumber" runat="server" style="z-index: 1; left: 300px; top: 372px; position: absolute" Text="TelephoneNumber:"></asp:Label>
        </div>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 484px; top: 204px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 476px; top: 244px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 478px; top: 286px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtConfirmPassword" runat="server" style="z-index: 1; left: 478px; top: 326px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephoneNumber" runat="server" style="z-index: 1; left: 424px; top: 372px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 458px; top: 424px; position: absolute; margin-top: 0px" Text="Register" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 550px; top: 424px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
