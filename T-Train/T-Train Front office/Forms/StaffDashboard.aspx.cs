using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms
{
    public partial class StaffDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("Default.aspx");
        }

        protected void btnTickets_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("Ticket/MyTickets.aspx");
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("User/Settings.aspx");
        }

        protected void btnFindConnection_Click(object sender, EventArgs e)
        {
            //redirect to a particular connection
            Response.Redirect("Connection/Connection.aspx");
        }

        protected void btnConnections_Click(object sender, EventArgs e)
        {
            //redirect to all connections screen
            Response.Redirect("Connection/Connections.aspx");
        }

        protected void btnAddConnection_Click(object sender, EventArgs e)
        {
            //redirect to add new connection screen
            Response.Redirect("Connection/Connection.aspx");
        }

        protected void btnFindTicketType_Click(object sender, EventArgs e)
        {
            //redirect to a particular ticket type
            Response.Redirect("TicketType/TicketType.aspx");
        }

        protected void btnTicketTypes_Click(object sender, EventArgs e)
        {
            //redirect to all ticket types screen
            Response.Redirect("TicketType/TicketTypes.aspx");
        }

        protected void btnAddTicketType_Click(object sender, EventArgs e)
        {
            //redirect to add new ticket type
            Response.Redirect("TicketType/TicketType.aspx");
        }

        protected void btnFilterCustomers_Click(object sender, EventArgs e)
        {
            //redirect to filtered customer list
            Response.Redirect("Customer/Customers.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}