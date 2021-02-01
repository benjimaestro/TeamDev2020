<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Timetable.aspx.cs" Inherits="Timetable.Timetable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" CssClass="auto-style7"></asp:Label>
        <br/>
        <br/>
        <br/>
        <asp:Button ID="btnNextWeek" runat="server" CssClass="auto-style5" Text="Next Week &gt;&gt;&gt;" />
        <asp:Label ID="lblWeekNo" runat="server" CssClass="auto-style6"></asp:Label>
        <br/>
        <asp:Button ID="btnPrevWeek" runat="server" CssClass="auto-style4" Text="&lt;&lt;&lt; Previous Week" />
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
                top: 123px;
                left: 913px;
                z-index: 1;
                width: 95px;
            }
            .auto-style4 {
                position: absolute;
                top: 56px;
                left: 10px;
                z-index: 1;
                width: 130px;
            }
            .auto-style5 {
                position: absolute;
                top: 56px;
                left: 492px;
                z-index: 1;
                width: 130px;
            }
            .auto-style6 {
                position: absolute;
                top: 59px;
                left: 258px;
                z-index: 1;
                text-align: center;
            }
            .auto-style7 {
                z-index: 1;
                left: 10px;
                top: 14px;
                position: absolute;
                height: 42px;
                width: 310px;
            }
            .auto-style8 {
                position: absolute;
                top: 128px;
                left: 1017px;
                z-index: 1;
            }
            .auto-style9 {
                position: absolute;
                top: 160px;
                left: 914px;
                z-index: 1;
                width: 95px;
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
            <td class="tg-0lax"> 
                <asp:Button ID="btnUnbook" runat="server" CssClass="auto-style9" Text="Unbook Room" />
                <asp:Button ID="btn1P1" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn1P2" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn1P3" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> 
                <asp:Label ID="lblError" runat="server" CssClass="auto-style8" ForeColor="Red"></asp:Label>
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn1P4" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn1P5" runat="server" Text="Room A1" Height="68px" Width="78px" /> 
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
            <td class="tg-0lax"> <asp:Button ID="btn2P1" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn2P2" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn2P3" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn2P4" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn2P5" runat="server" Text="Room A1" Height="68px" Width="78px" /> 
                <asp:Button ID="btnSave" runat="server" CssClass="auto-style3" Text="Save" />
              </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Wed<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn3P1" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn3P" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn3P3" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn3P4" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn3P5" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Thurs<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn4P1" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn4P2" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn4P3" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn4P4" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn4P5" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Fri</td>
            <td class="tg-0lax"> <asp:Button ID="btn5P1" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn5P2" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn5P3" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn5P4" runat="server" Text="Room A1" Height="68px" Width="79px" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn5P5" runat="server" Text="Room A1" Height="68px" Width="78px" /> </td>
          </tr>
        </tbody>
        </table>
    </form>
</body>
</html>
