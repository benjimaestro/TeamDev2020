using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Ticket_Type
{
    public partial class TicketTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            //redirect to ticket types with a filter
            Response.Redirect("TicketTypes.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            //redirect to a ticket type
            Response.Redirect("TicketType.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //redirect to a ticket type
            Response.Redirect("TicketType.aspx");
        }
    }
}