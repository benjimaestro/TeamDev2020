<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudent.aspx.cs" Inherits="LaptopLoanProjectt.DeleteStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 17px; top: 15px; position: absolute" Text="(Are You Sure You Want To Delete?)"></asp:Label>

        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 29px; top: 74px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 117px; top: 74px; position: absolute" Text="No" />
    </form>
</body>
</html>
