<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserFines.aspx.cs" Inherits="LaptopLoanProjectt.UserFines" %>

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
        <asp:Label ID="lblFines" runat="server" Font-Size="XX-Large" Text="View Fines" CssClass="auto-style17"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderStyle="Double" ForeColor="Blue" style="z-index: 1; left: 602px; top: 30px; position: absolute; height: 37px; width: 180px; margin-top: 10px" Text="Welcome Back User!"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 31px; top: 149px; position: absolute; height: 249px; width: 286px"></asp:ListBox>
        <asp:Button ID="btnPay" runat="server" style="z-index: 1; left: 31px; top: 418px; position: absolute; width: 42px; margin-top: 0px" Text="Pay" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 268px; top: 416px; position: absolute" Text="Back" />
    </form>
</body>
</html>
