<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopUserBooking.aspx.cs" Inherits="LaptopLoanProjectt.LaptopUserBooking" %>

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
            <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderStyle="Double" ForeColor="Blue" style="z-index: 1; left: 579px; top: 33px; position: absolute; height: 55px; width: 195px; margin-top: 10px" Text="Welcome Back User!"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblFines" runat="server" Font-Size="XX-Large" Text="Make A Booking" CssClass="auto-style17"></asp:Label>
        </p>
        <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 43px; top: 194px; position: absolute; height: 188px; width: 259px; margin-top: 0px"></asp:Calendar>
    </form>
</body>
</html>
