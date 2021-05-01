<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopUserViewBookings.aspx.cs" Inherits="LaptopLoanProjectt.LaptopUserViewBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style17 {
            z-index: 1;
            left: 11px;
            top: 63px;
            position: absolute;
            height: 42px;
            width: 488px;
            bottom: 552px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderStyle="Double" ForeColor="Blue" style="z-index: 1; left: 602px; top: 29px; position: absolute; height: 37px; width: 180px; margin-top: 10px" Text="Welcome Back User!"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="View Bookings" CssClass="auto-style17"></asp:Label>
        </p>
        <asp:ListBox ID="lstBookings" runat="server" style="z-index: 1; left: 18px; top: 196px; position: absolute; height: 263px; width: 380px"></asp:ListBox>
        <asp:Button ID="btnAddNewBooking" runat="server" style="z-index: 1; left: 21px; top: 480px; position: absolute; width: 117px" Text="Add New Booking" />
        <asp:Button ID="btnDeleteBooking" runat="server" ForeColor="Red" style="z-index: 1; left: 284px; top: 480px; position: absolute; width: 110px" Text="Delete Booking" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 355px; top: 532px; position: absolute" Text="Back" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 447px; top: 231px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 144px; top: 480px; position: absolute; width: 96px" Text="Edit" />
    </form>
</body>
</html>
