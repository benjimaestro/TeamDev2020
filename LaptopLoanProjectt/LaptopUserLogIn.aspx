<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopUserLogIn.aspx.cs" Inherits="LaptopLoanProjectt.LaptopUserLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Label ID="lblWelcomeL" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 353px; top: 68px; position: absolute" Text="Welcome to Laptop Loan"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 480px; top: 115px; position: absolute" Text="Please LogIn"></asp:Label>
        <asp:Label ID="lblLaptopUserEmail" runat="server" style="z-index: 1; left: 120px; top: 205px; position: absolute" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 168px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 164px; top: 275px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLaptopUserPassWord" runat="server" style="z-index: 1; left: 86px; top: 277px; position: absolute" Text="PassWord:"></asp:Label>
        <asp:Button ID="btnMainPage" runat="server" style="z-index: 1; left: 62px; top: 41px; position: absolute" Text="MainPage" OnClick="btnMainPage_Click" />
        <asp:Button ID="btnLogIn" runat="server" style="z-index: 1; left: 167px; top: 319px; position: absolute; width: 59px;" Text="LogIn" />
        <p>
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 242px; top: 319px; position: absolute; height: 26px;" Text="Cancel"  />
        <asp:Label ID="lblAccCreated" runat="server" style="z-index: 1; left: 325px; top: 143px; position: absolute" Text="Your account is now active! Fill the form to login." Font-Bold="True" Font-Size="Large" ForeColor="#00CC00" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 145px; top: 359px; position: absolute; width: 166px" Text="Forgot Password?" />
        <p>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 570px; top: 444px; position: absolute; height: 105px; width: 196px" Text="Laptop Loan System Equity Rd. 22, Leicester, LE3 OSB, Leicestershire, Great Britain, Email: user@laptoploan.com, Mobile: 0783574951"></asp:Label>
        </p>
    </form>
</body>
</html>
