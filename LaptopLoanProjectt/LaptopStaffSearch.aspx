<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaptopStaffSearch.aspx.cs" Inherits="LaptopLoanProjectt.LaptopStaffSearch" %>

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
            <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderStyle="Double" ForeColor="Blue" style="z-index: 1; left: 550px; top: 31px; position: absolute; height: 37px; width: 180px; margin-top: 10px" Text="Welcome Back Admin!"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblFines" runat="server" Font-Size="XX-Large" Text="Search Students" CssClass="auto-style17"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 18px; top: 219px; position: absolute; height: 268px; width: 298px"></asp:ListBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 11px; top: 141px; position: absolute" Text="Search Students"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 114px; top: 140px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 311px; top: 140px; position: absolute; width: 98px" Text="Search Student" />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 425px; top: 139px; position: absolute; height: 27px" Text="Show All" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 331px; top: 239px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 19px; top: 503px; position: absolute; height: 23px; width: 110px" Text="Add New Student" />
        <asp:Button ID="Button4" runat="server" ForeColor="Red" style="z-index: 1; left: 202px; top: 503px; position: absolute; width: 101px" Text="Delete Student" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 163px; top: 563px; position: absolute" Text="Back" />
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 139px; top: 504px; position: absolute; width: 49px; height: 23px;" Text="Edit" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
