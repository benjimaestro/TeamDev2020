<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewStudent.aspx.cs" Inherits="LaptopLoanProjectt.AddNewStudent" %>

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
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 17px; top: 15px; position: absolute" Text="(Add/Edit) Student"></asp:Label>

        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 476px; top: 291px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtConfirmPassword" runat="server" style="z-index: 1; left: 476px; top: 334px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephoneNumber" runat="server" style="z-index: 1; left: 476px; top: 377px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnEnter" runat="server" style="z-index: 1; left: 469px; top: 486px; position: absolute; margin-top: 0px; width: 59px;" Text="Enter" />
        <asp:Label ID="lblFill" runat="server" ForeColor="Lime" style="z-index: 1; left: 435px; top: 105px; position: absolute" Text="Hello! Please fill and register now"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 476px; top: 162px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 476px; top: 205px; position: absolute"></asp:TextBox>
        <p>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 477px; top: 250px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblLaptopUserFirstName" runat="server" style="z-index: 1; left: 392px; top: 165px; position: absolute" Text="First Name:"></asp:Label>
            <asp:Label ID="lblLaptopUserLastName" runat="server" style="z-index: 1; left: 389px; top: 207px; position: absolute" Text="Last Name:"></asp:Label>
            <asp:Label ID="lblLaptopUserEmail" runat="server" style="z-index: 1; left: 379px; position: absolute; bottom: 381px; top: 248px; margin-bottom: 19px;" Text="Email Address:"></asp:Label>
            <asp:Label ID="lblLaptopUserAddress" runat="server" style="z-index: 1; left: 410px; top: 292px; position: absolute" Text="Address:"></asp:Label>
            <asp:Label ID="lblLaptopUserPassword" runat="server" style="z-index: 1; left: 402px; top: 335px; position: absolute" Text="Password:"></asp:Label>
            <asp:Label ID="lblconfirmpassword" runat="server" style="z-index: 1; left: 352px; top: 378px; position: absolute" Text="Confirm Password:"></asp:Label>
            <asp:Label ID="lblLaptopUserTelephoneNumber" runat="server" style="z-index: 1; left: 353px; top: 431px; position: absolute" Text="TelephoneNumber:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 479px; top: 429px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 541px; top: 485px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
