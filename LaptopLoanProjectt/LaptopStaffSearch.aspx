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
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 142px; position: absolute" Text="Search Students"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 114px; top: 140px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnSearchStudent" runat="server" style="z-index: 1; left: 311px; top: 140px; position: absolute; width: 98px" Text="Search Student"  />
        
        <asp:Button ID="btnAddNewStudent" runat="server"  style="z-index: 1; left: 19px; top: 503px; position: absolute; height: 23px; width: 110px" Text="Add New Student" />
        <asp:Button ID="btnEdit" runat="server"  style="z-index: 1; left: 139px; top: 504px; position: absolute; width: 49px; height: 23px;" Text="Edit" />
        
        <p>
            <asp:Button ID="btnShowAll" runat="server"  style="z-index: 1; left: 429px; top: 139px; position: absolute" Text="Show All" />
        </p>
        <asp:ListBox ID="lstLaptopUsers" runat="server" OnSelectedIndexChanged="lstLaptopUsers_SelectedIndexChanged" style="z-index: 1; left: 20px; top: 193px; position: absolute; height: 297px; width: 557px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnBack" runat="server"  style="z-index: 1; left: 203px; top: 501px; position: absolute" Text="Back" />
        <p>
        
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 928px; top: 467px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
