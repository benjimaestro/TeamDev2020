<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBooking.aspx.cs" Inherits="LaptopLoanProjectt.AddBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 70px; top: 22px; position: absolute" Text="Add a Laptop"></asp:Label>

        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 289px; top: 149px; position: absolute">
        </asp:DropDownList>
        <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 38px; top: 116px; position: absolute; height: 136px; width: 193px"></asp:Calendar>
        <p>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 284px; top: 329px; position: absolute" Text="Book" />
        </p>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 349px; top: 329px; position: absolute" Text="Back" />
    </form>
</body>
</html>
