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
            <asp:Button ID="btnUserRegister" runat="server" OnClick="btnUserRegister_Click1" style="z-index: 1; left: 538px; top: 176px; position: absolute" Text="User Register" />
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnUserLogin" runat="server" OnClick="btnUserLogin_Click" style="z-index: 1; left: 538px; top: 261px; position: absolute; width: 251px" Text="User Log In" />
        <asp:Button ID="btnStaffLogin" runat="server" OnClick="btnStaffLogin_Click" style="z-index: 1; left: 538px; top: 340px; position: absolute; width: 245px" Text="Staff Log In" />
    </form>
</body>
</html>
