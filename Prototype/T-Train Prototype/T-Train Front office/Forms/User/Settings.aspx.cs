using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.User
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("Default.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnTickets_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("../Ticket/MyTickets.aspx");
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("Settings.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //update 2fa
            Response.Redirect("Settings.aspx");
        }

        protected void btnPassword_Click(object sender, EventArgs e)
        {
            //update password
            Response.Redirect("Settings.aspx");
        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            //update details
            Response.Redirect("Settings.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete account
            Response.Redirect("Settings.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}