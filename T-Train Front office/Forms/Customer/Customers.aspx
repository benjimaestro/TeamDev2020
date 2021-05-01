<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="T_Train_Front_office.Forms.Customer.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 860px; top: 33px; position: absolute" Text="Logout" OnClick="btnLogout_Click" />
        <asp:Button ID="btnHomepage" runat="server" style="z-index: 1; left: 28px; top: 70px; position: absolute; right: 867px;" Text="Homepage" OnClick="Button1_Click" />
            <asp:Button ID="btnStaffDashboard" runat="server" style="z-index: 1; left: 28px; top: 33px; position: absolute; " Text="Staff Dashboard" OnClick="btnStaffDashboard_Click" />
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 392px; top: 638px; position: absolute" Text="All rights reserved (at) T-Train 2020"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 70px; top: 153px; position: absolute" Text="Find customers:"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 101px; top: 216px; position: absolute" Text="Customer's First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 273px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 101px; top: 252px; position: absolute" Text="Customer's Last Name:"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 273px; top: 252px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label25" runat="server" style="z-index: 1; left: 101px; top: 289px; position: absolute" Text="Customer's Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 273px; top: 289px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnFilterCustomers" runat="server" style="z-index: 1; left: 532px; top: 252px; position: absolute" Text="Search" OnClick="btnFilterCustomers_Click" />
        <p>
        <asp:Label ID="lblStaticResultsHeader" runat="server" Font-Size="X-Large" style="z-index: 1; left: 70px; top: 375px; position: absolute" Text="Customers Found:" Visible="False"></asp:Label>
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 628px; top: 467px; position: absolute" Text="Manage Customer" OnClick="btnCustomer_Click" Visible="False" />
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblHeaderWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 189px; top: 33px; position: absolute" Text="T-Train"></asp:Label>
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 68px; top: 446px; position: absolute; height: 173px; width: 419px" Visible="False"></asp:ListBox>
        </p>
        <p>
        <asp:Label ID="lblNoCustFound" runat="server" style="z-index: 1; left: 273px; top: 438px; position: absolute; height: 64px; width: 455px;" Text="There were no customers found that match the entered details. Please try again and make sure all details are correct." Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblErrorDetails" runat="server" style="z-index: 1; left: 445px; top: 289px; position: absolute" Text="You must enter some details first!" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Label ID="lblCustSelected" runat="server" style="z-index: 1; left: 590px; top: 536px; position: absolute" Text="You must select a customer first!" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
