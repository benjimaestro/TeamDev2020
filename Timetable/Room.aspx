<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="Timetable.Room" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 17px; top: 15px; position: absolute" Text="(Add/Edit) Room"></asp:Label>

        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 9px; top: 50px; position: absolute" Text="Room block"></asp:Label>
        <asp:DropDownList ID="ddlBlock" runat="server" style="z-index: 1; left: 10px; top: 80px; position: absolute; height: 16px; width: 130px;"></asp:DropDownList>

        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Room number"></asp:Label>
        <asp:TextBox ID="txtRoomNo" runat="server" style="z-index: 1; left: 10px; top: 140px; position: absolute"></asp:TextBox>

        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 170px; position: absolute" Text="Subject taught in room"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute; height: 13px; width: 130px;"></asp:DropDownList>

        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 10px; top: 230px; position: absolute; right: 1322px;" Text="Save" OnClick="btnRegister_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 64px; top: 230px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 254px; top: 82px; position: absolute; height: 195px; width: 700px" Font-Bold="True" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
