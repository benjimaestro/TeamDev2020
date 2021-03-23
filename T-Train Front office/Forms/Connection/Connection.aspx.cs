using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Connection
{
    public partial class Connection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = "edit";

            switch(action)
            {
                case "edit":
                {
                    //Change the headers and buttons to show that we are editing
                    lblActionName.Text = "Change connection details:";
                    btnSaveConnection.Text = "Save changes";
                    lblTicketLimit.Text = "Tickets remaining:";

                    //Make all editing-only fields visible
                    lblModifyHeader.Visible = true;
                    lblModAdded.Visible = true;
                    lblModDate.Visible = true;
                    lblModId.Visible = true;
                    lblModLocation.Visible = true;
                    lblModTickets.Visible = true;
                    lblModTime.Visible = true;

                    //Make the delete label and button visible
                    lblDelete.Visible = true;
                    btnDelConnection.Visible = true;
                    break;
                }
                default:
                {
                    //By default a new connection is added
                    lblActionName.Text = "Add connection:";
                    btnSaveConnection.Text = "Add connection";
                    lblTicketLimit.Text = "Ticket limit:";
                    break;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //add a new connection or modify the existing one or delete an existing one
            Response.Redirect("../User/ActionSuccess.aspx");
        }

        protected void btnDelConnection_Click(object sender, EventArgs e)
        {
            //add a new connection or modify the existing one or delete an existing one
            Response.Redirect("../User/ActionSuccess.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }

        protected void btnPick_Click(object sender, EventArgs e)
        {
            dtpDate.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = dtpDate.SelectedDate;
            txtDate.Text = Convert.ToString(date).Substring(0, 10);
            dtpDate.Visible = false;
        }
    }
}