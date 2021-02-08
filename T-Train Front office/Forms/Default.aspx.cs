using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms
{
    public partial class Defaul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("StaffDashboard.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("Ticket/MyTickets.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("User/Settings.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //redirect to the login screen
            Response.Redirect("User/Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect to the new account screen
            Response.Redirect("User/Signup.aspx");
        }

        protected void btnConnections_Click(object sender, EventArgs e)
        {
            //redirect to all connections screen
            Response.Redirect("Connection/Connections.aspx");
        }

        protected void btnFilterConnections_Click(object sender, EventArgs e)
        {
            //redirect to a filtered list of connections
            Response.Redirect("Connection/Connections.aspx");
        }
    }
}