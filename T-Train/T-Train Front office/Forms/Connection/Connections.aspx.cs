using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Connection
{
    public partial class Connections : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("../User/Settings.aspx");
        }

        protected void btnTickets_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("../Ticket/MyTickets.aspx");
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            //redirect to the new account screen
            Response.Redirect("../User/Signup.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //redirect to the login screen
            Response.Redirect("../User/Login.aspx");
        }

        protected void btnConnections_Click(object sender, EventArgs e)
        {
            //redirect to all connections screen
            Response.Redirect("Connections.aspx");
        }

        protected void btnFilterConnections_Click(object sender, EventArgs e)
        {
            //redirect to a filtered list of connections
            Response.Redirect("Connections.aspx");
        }

        protected void btnBookTicket_Click(object sender, EventArgs e)
        {
            //redirect to a booking screen
            Response.Redirect("../Ticket/Ticket.aspx");
        }

        protected void btnFindConnection_Click(object sender, EventArgs e)
        {
            //redirect to a particular connection
            Response.Redirect("Connection.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }

        protected void btnBookTicket_Click1(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/ActionSuccess.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to a particular connection
            Response.Redirect("Connection.aspx");
        }
    }
}