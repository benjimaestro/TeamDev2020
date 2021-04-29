<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="LaptopLoanProjectt.UserLogIn" %>

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
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 9px; position: absolute; height: 24px; width: 139px;" Text="Laptop Loan System" BorderColor="#9933FF" BorderStyle="Double" ForeColor="#3333CC"></asp:Label>
            <asp:Label ID="lblUserRegistration" runat="server" style="z-index: 1; left: 452px; top: 55px; position: absolute" Text="User Registration Form"></asp:Label>
            <asp:Label ID="lblLaptopUserFirstName" runat="server" style="z-index: 1; left: 390px; top: 125px; position: absolute" Text="First Name:"></asp:Label>
            <asp:Label ID="lblLaptopUserLastName" runat="server" style="z-index: 1; left: 395px; top: 164px; position: absolute" Text="Last Name:"></asp:Label>
            <asp:Label ID="lblLaptopUserEmail" runat="server" style="z-index: 1; left: 382px; position: absolute; bottom: 449px; top: 207px" Text="Email Address:"></asp:Label>
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
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 550px; top: 424px; position: absolute" Text="Cancel"  />
        <asp:Label ID="lblFill" runat="server" ForeColor="Lime" style="z-index: 1; left: 419px; top: 76px; position: absolute" Text="Hello! Please fill and register now"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 468px; top: 125px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 470px; top: 162px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
