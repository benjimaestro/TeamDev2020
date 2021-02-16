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
        <asp:Button ID="btnNextWeek" runat="server" CssClass="auto-style5" Text="Next Week &gt;&gt;&gt;" OnClick="btnNextWeek_Click" />
        <asp:Label ID="lblWeekNo" runat="server" CssClass="auto-style6"></asp:Label>
        <br/>
        <asp:Button ID="btnPrevWeek" runat="server" CssClass="auto-style4" Text="&lt;&lt;&lt; Previous Week" OnClick="btnPrevWeek_Click" />
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
                width: 394px;
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
                top: 123px;
                left: 914px;
                z-index: 1;
                width: 95px;
            }
            .auto-style10 {
                position: absolute;
                top: 519px;
                left: 10px;
                z-index: 1;
            }
            .auto-style11 {
                width: 1160px;
                height: 1px;
                position: absolute;
                top: 494px;
                left: 10px;
                z-index: 1;
                background-color: black;
                color: black;
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
                <asp:Button ID="btnUnbook" runat="server" CssClass="auto-style9" Text="Unbook Room" OnClick="btnUnbook_Click" />
                <asp:Button ID="btn1P1" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn1P2" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn1P3" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> 
                <asp:Label ID="lblError" runat="server" CssClass="auto-style8" ForeColor="Red"></asp:Label>
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn1P4" runat="server" Text="Room A1" Height="68px" Width="79px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn1P5" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> 
                <asp:DropDownList ID="ddlRooms" runat="server" AutoPostBack="true" CssClass="auto-style1" OnSelectedIndexChanged="ddlRooms_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Label ID="lblRooms" runat="server" CssClass="auto-style2" Text="Select period to modify room booking"></asp:Label>
              </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Tues<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn2P1" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn2P2" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn2P3" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn2P4" runat="server" Text="Room A1" Height="68px" Width="79px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn2P5" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> 
              </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Wed<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn3P1" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn3P2" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn3P3" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn3P4" runat="server" Text="Room A1" Height="68px" Width="79px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn3P5" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Thurs<br />
                <br />
              </td>
            <td class="tg-0lax"> <asp:Button ID="btn4P1" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn4P2" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn4P3" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn4P4" runat="server" Text="Room A1" Height="68px" Width="79px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn4P5" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
          </tr>
          <tr>
            <td class="tg-m9r4">
                <br />
                Fri</td>
            <td class="tg-0lax"> <asp:Button ID="btn5P1" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn5P2" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn5P3" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> &nbsp;</td>
            <td class="tg-0lax"> <asp:Button ID="btn5P4" runat="server" Text="Room A1" Height="68px" Width="79px" OnClick="TimetableButton_Click" /> </td>
            <td class="tg-0lax"> <asp:Button ID="btn5P5" runat="server" Text="Room A1" Height="68px" Width="78px" OnClick="TimetableButton_Click" /> </td>
          </tr>
        </tbody>
        </table>
        <hr class="auto-style11" />
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style10" OnClick="btnBack_Click" Text="Back" />
    </form>
</body>
</html>
