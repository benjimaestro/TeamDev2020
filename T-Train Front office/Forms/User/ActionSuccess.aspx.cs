using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.User
{
    public partial class ActionSuccess : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("../Ticket/MyTickets.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("Settings.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("../Ticket/MyTickets.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}