<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopStaffDashBoard.aspx.cs" Inherits="LaptopLoanProjectt.LaptopStaffDashBoard" %>

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
        <asp:Label ID="lblWelcomeL" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 519px; top: 59px; position: absolute" Text="Welcome to Laptop Loan"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" ForeColor="Blue" style="z-index: 1; left: 597px; top: 111px; position: absolute" Text="Welcome Back Admin!"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnMainPage" runat="server" style="z-index: 1; left: 66px; top: 83px; position: absolute" Text="MainPage" />
        </p>
        <asp:Button ID="btnSearchStudents" runat="server" style="z-index: 1; left: 609px; top: 192px; position: absolute; height: 33px; width: 148px" Text="Search Students" />
        <asp:Button ID="btnViewBookings" runat="server" style="z-index: 1; left: 609px; top: 244px; position: absolute; height: 28px; width: 144px; bottom: 385px" Text="View Bookings" />
        <asp:Button ID="btnFines" runat="server" style="z-index: 1; left: 608px; top: 295px; position: absolute; height: 29px; width: 144px" Text="Fines" />
        <asp:Button ID="btnClose" runat="server" style="z-index: 1; left: 486px; top: 411px; position: absolute" Text="Close" />
    </form>
</body>
</html>
