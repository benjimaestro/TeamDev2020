<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Timetable.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 240px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 64px;
            top: 240px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 10px;
            top: 50px;
            position: absolute;
            height: 18px;
            bottom: 620px;
        }
        .auto-style5 {
            z-index: 1;
            left: 10px;
            top: 77px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 10px;
            top: 109px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 10px;
            top: 132px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 9px;
            top: 173px;
            position: absolute;
            width: 272px;
        }
        .auto-style9 {
            z-index: 1;
            left: 10px;
            top: 202px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 244px;
            top: 74px;
            position: absolute;
            height: 195px;
            width: 672px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 17px; top: 15px; position: absolute" Text="Forgot Password"></asp:Label>

        <asp:Label ID="Label2" runat="server" Text="User's Password" CssClass="auto-style4"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" MaxLength="50" TextMode="Password" EnableTheming="True" CssClass="auto-style5"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Confirm User's Password" CssClass="auto-style6"></asp:Label>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" MaxLength="50" TextMode="Password" CssClass="auto-style7"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="EMail Code (Check your EMails)" CssClass="auto-style8"></asp:Label>
        <asp:TextBox ID="txtEMailCode" runat="server" MaxLength="50" CssClass="auto-style9"></asp:TextBox>
        <asp:Button ID="btnRegister" runat="server" Text="Apply" OnClick="btnRegister_Click" CssClass="auto-style1" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="auto-style2" />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" CssClass="auto-style10"></asp:Label>
    </form>
</body>
</html>
