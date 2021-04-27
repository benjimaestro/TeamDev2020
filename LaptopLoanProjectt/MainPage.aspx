<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="LaptopLoanProjectt.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" = href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <div id="My login" class="Login">
            <asp:Label ID="lblLaptopLoanSystem" runat="server" style="z-index: 1; left: 548px; top: 34px; position: absolute" Text="Laptop Loan System"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnUserLaptopRegister" runat="server" OnClick="btnUserLaptopRegister_Click" style="z-index: 1; left: 542px; top: 189px; position: absolute; width: 248px" Text="User Register" />
        </p>
        <asp:Button ID="btnUserLogin" runat="server" OnClick="btnUserLogin_Click" style="z-index: 1; left: 538px; top: 261px; position: absolute; width: 251px" Text="User Log In" />
        <asp:Button ID="btnStaffLogin" runat="server" OnClick="btnStaffLogin_Click" style="z-index: 1; left: 538px; top: 340px; position: absolute; width: 245px" Text="Staff Log In" />
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 854px; top: 485px; position: absolute; height: 105px; width: 196px" Text="Laptop Loan System Equity Rd. 22, Leicester, LE3 OSB, Leicestershire, Great Britain, Email: user@laptoploan.com, Mobile: 0783574951"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 354px; top: 706px; position: absolute" Text="All rights reserved (at) LaptopLoan 2021 ©"></asp:Label>
        </p>
    </form>
</body>
</html>
