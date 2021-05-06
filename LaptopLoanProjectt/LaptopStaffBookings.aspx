<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopStaffBookings.aspx.cs" Inherits="LaptopLoanProjectt.LaptopStaffBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style17 {
            z-index: 1;
            left: 5px;
            top: 14px;
            position: absolute;
            height: 42px;
            width: 488px;
            bottom: 601px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderStyle="Double" ForeColor="Blue" style="z-index: 1; left: 578px; top: 27px; position: absolute; height: 37px; width: 180px; margin-top: 10px" Text="Welcome Back Admin!"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblFines" runat="server" Font-Size="XX-Large" Text="View Bookings" CssClass="auto-style17"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 407px; top: 245px; position: absolute; height: 318px; width: 405px"></asp:ListBox>
        <asp:Button ID="btnShowAll" runat="server" style="z-index: 1; left: 754px; top: 212px; position: absolute" Text="Show All" />
        <asp:Label ID="Label2" runat="server" ForeColor="Red" style="z-index: 1; left: 827px; top: 264px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 597px; top: 573px; position: absolute; width: 63px" Text="Edit" />
        <asp:Button ID="Button3" runat="server" ForeColor="Red" style="z-index: 1; left: 686px; top: 563px; position: absolute" Text="Delete " />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1192px; top: 582px; position: absolute" Text="Back" OnClick="Button4_Click" />
        <p>
            <asp:Button ID="btnAddNewBooking" runat="server" style="z-index: 1; left: 412px; top: 573px; position: absolute; width: 128px" Text="Add New Booking" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 354px; top: 706px; position: absolute" Text="All rights reserved (at) LaptopLoan 2021 ©"></asp:Label>
        </p>
    </form>
</body>
</html>
