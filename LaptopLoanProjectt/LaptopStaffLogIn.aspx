<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopStaffLogIn.aspx.cs" Inherits="LaptopLoanProjectt.LaptopStaffLogIn" %>

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
        <asp:Button ID="btnMainPage" runat="server" style="z-index: 1; left: 62px; top: 41px; position: absolute" Text="MainPage" OnClick="btnMainPage_Click" />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 150px; top: 169px; position: absolute" Text="Staff ID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 210px; top: 168px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 210px; top: 234px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 138px; top: 234px; position: absolute" Text="Password:"></asp:Label>
        <asp:Button ID="btnLaptopLoanStaffLogIn" runat="server" OnClick="btnLaptopLoanStaffLogIn_Click" style="z-index: 1; left: 214px; top: 313px; position: absolute; right: 1036px" Text="Log In" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 282px; top: 313px; position: absolute" Text="Cancel" />
        <p>
        <asp:Label ID="lblFill" runat="server" ForeColor="Lime" style="z-index: 1; left: 411px; top: 120px; position: absolute" Text="Hello! Please fill and Log In now"></asp:Label>
        </p>
    </form>
</body>
</html>
