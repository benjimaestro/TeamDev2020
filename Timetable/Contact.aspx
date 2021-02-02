<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Timetable.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 676px;
            left: 10px;
            z-index: 1;
        }
        .auto-style2 {
            z-index: 1;
            left: 10px;
            top: 34px;
            position: absolute;
            height: 42px;
            width: 1173px;
        }
        .auto-style3 {
            position: absolute;
            top: 86px;
            left: 530px;
            z-index: 1;
        }
        .auto-style4 {
            z-index: 1;
            left: 10px;
            top: 600px;
            position: absolute;
            width: 500px;
            height: 60px;
            resize: none;
        }
        .auto-style5 {
            z-index: 1;
            left: 520px;
            top: 600px;
            position: absolute;
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Text="Contact (user)" CssClass="auto-style2"></asp:Label>
        <br/>
        <br/>
        <asp:TextBox ID="txtMessages" runat="server" style="resize:none; z-index: 1; left: 10px; top: 85px; position: absolute; width: 500px; height: 500px" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtSendMessage" runat="server" CssClass="auto-style4" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="btnSend" runat="server" Text="Send to <user>" OnClick="btnSend_Click" CssClass="auto-style5" />
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style1" OnClick="btnBack_Click" Text="Back" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style3" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
