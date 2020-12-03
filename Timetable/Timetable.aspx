<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Timetable.aspx.cs" Inherits="Timetable.Timetable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 42px; width: 310px" Text="(Add/edit) Timetable"></asp:Label>
        <br/>
        <br/>
        <style type="text/css">
        .tg  {border-collapse:collapse;border-spacing:0;}
        .tg td{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
          overflow:hidden;word-break:normal;}
        .tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
          font-weight:normal;overflow:hidden;word-break:normal;}
        .tg .tg-m9r4{background-color:#ffffc7;text-align:left;vertical-align:top}
        .tg .tg-0lax{text-align:left;vertical-align:top}
            .auto-style1 {
                position: absolute;
                top: 125px;
                left: 700px;
                z-index: 1;
                width: 206px;
            }
            .auto-style2 {
                position: absolute;
                top: 97px;
                left: 698px;
                z-index: 1;
                width: 251px;
            }
            .auto-style3 {
                position: absolute;
                top: 158px;
                left: 701px;
                z-index: 1;
                width: 205px;
            }
            </style>
        <table class="tg">
        <thead>
          <tr>
            <th class="tg-m9r4"></th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; P1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Break&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; P2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; P3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lunch&nbsp;&nbsp;&nbsp;&nbsp; </th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; P4&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th>
            <th class="tg-m9r4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; P5&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td class="tg-m9r4">
                <br />
                Mon<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="Button1" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button2" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button3" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button5" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button6" runat="server" Text="Room A1" Height="68px" Width="78px" /> 
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1">
                </asp:DropDownList>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Available rooms for (day) (period)"></asp:Label>
              </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Tues<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="Button8" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button10" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button11" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button13" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button14" runat="server" Text="Room A1" Height="68px" Width="78px" /> 
                <asp:Button ID="btnSave" runat="server" CssClass="auto-style3" Text="Save" />
              </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Wed<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="Button15" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button17" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button18" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button20" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button21" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Thurs<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="Button22" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button24" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button25" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button27" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button28" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Fri</td>
            <td class="tg-0lax"> <asp:Button ID="Button29" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button31" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button32" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="Button34" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="Button35" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
          </tr>
        </tbody>
        </table>
    </form>
</body>
</html>
