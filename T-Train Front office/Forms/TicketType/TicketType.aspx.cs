using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Ticket_Type
{
    public partial class TicketType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //redirect to ticket types
            Response.Redirect("TicketTypes.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }

        protected void btnTicketType_Click(object sender, EventArgs e)
        {
            //redirect to make changes
            Response.Redirect("../User/ActionSuccess.aspx");
        }

        protected void btnDelTicketType_Click(object sender, EventArgs e)
        {
            //redirect to delete
            Response.Redirect("../User/ActionSuccess.aspx");
        }
    }
}