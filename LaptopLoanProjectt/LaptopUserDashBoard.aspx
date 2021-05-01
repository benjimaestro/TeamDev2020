<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopUserDashBoard.aspx.cs" Inherits="LaptopLoanProjectt.LaptopUserDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblWelcomeL" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 519px; top: 59px; position: absolute" Text="Welcome to Laptop Loan"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnMainPage" runat="server" style="z-index: 1; left: 66px; top: 83px; position: absolute" Text="MainPage" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnBookALaptop" runat="server" style="z-index: 1; left: 594px; top: 201px; position: absolute; width: 130px; height: 29px" Text="Book A Laptop" />
        <asp:Button ID="btnViewMyBookings" runat="server" OnClick="btnViewMyBookings_Click" style="z-index: 1; left: 595px; top: 253px; position: absolute; width: 128px; height: 27px" Text="View My Bookings" />
        <asp:Button ID="btnFines" runat="server" style="z-index: 1; left: 594px; top: 299px; position: absolute; width: 127px; height: 29px" Text="Fines" />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 423px; top: 400px; position: absolute" Text="Log Out" />
        <asp:Label ID="Label1" runat="server" ForeColor="Blue" style="z-index: 1; left: 600px; top: 132px; position: absolute" Text="Welcome Back User!"></asp:Label>
    </form>
</body>
</html>
