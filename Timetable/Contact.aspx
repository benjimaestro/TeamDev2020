<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Timetable.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 294px" Text="Contact (user)"></asp:Label>
        <br/>
        <br/>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 10px; top: 85px; position: absolute; width: 500px; height: 500px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 10px; top: 600px; position: absolute; width: 500px;"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 520px; top: 600px; position: absolute" Text="Send to <user>" />
    </form>
</body>
</html>
