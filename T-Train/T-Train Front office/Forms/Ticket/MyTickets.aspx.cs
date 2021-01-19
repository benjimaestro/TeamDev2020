using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Ticket
{
    public partial class MyTickets : System.Web.UI.Page
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
            Response.Redirect("User/Settings.aspx");
        }

        protected void btnFilterFirst_Click(object sender, EventArgs e)
        {
            //redirect to my tickets with a filter
            Response.Redirect("MyTickets.aspx");
        }

        protected void btnFilterLast_Click(object sender, EventArgs e)
        {
            //redirect to my tickets with a filter
            Response.Redirect("MyTickets.aspx");
        }

        protected void btnFilterTickets_Click(object sender, EventArgs e)
        {
            //redirect to my tickets with a filter
            Response.Redirect("MyTickets.aspx");
        }

        protected void btnHomepage2_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnConnections_Click(object sender, EventArgs e)
        {
            //redirect to all connections
            Response.Redirect("../Connection/Connections.aspx");
        }

        protected void btnReissue_Click(object sender, EventArgs e)
        {
            //redirect to the reissue action
            Response.Redirect("../User/ActionSuccess.aspx");
        }

        protected void btnReissue2_Click(object sender, EventArgs e)
        {
            //redirect to the reissue action
            Response.Redirect("../User/ActionSuccess.aspx");
        }

        protected void btnRefund_Click(object sender, EventArgs e)
        {
            //redirect to the refund page
            Response.Redirect("Refund.aspx");
        }

        protected void btnHomepage3_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnConnections2_Click(object sender, EventArgs e)
        {
            //redirect to all connections
            Response.Redirect("../Connection/Connections.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}