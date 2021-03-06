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
            bool loggedIn = true;
            bool isStaff = false;

            btnStaffDashboard.Visible = isStaff;
            btnTickets.Visible = loggedIn;
            btnSettings.Visible = loggedIn;
            btnLogin.Visible = !loggedIn;
            btnSignup.Visible = !loggedIn;
            btnLogout.Visible = loggedIn;

            //Fill the time dropdown list
            for(int hour = 0; hour < 24; ++hour)
            {
                for(int minutes = 0; minutes < 60; minutes += 15)
                {
                    //format the hour
                    string hourToAdd = Convert.ToString(hour);
                    hourToAdd = hourToAdd.Length == 1 ? ("0" + hourToAdd) : hourToAdd;

                    //format the minutes
                    string minutesToAdd = Convert.ToString(minutes);
                    minutesToAdd = minutesToAdd.Length == 1 ? "00" : minutesToAdd;

                    //add the time to the dropdown list
                    ddlTime.Items.Add(hourToAdd + ":" + minutesToAdd);
                }
            }
            

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

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = dtpDate.SelectedDate;
            txtDate.Text = Convert.ToString(date).Substring(0, 10);
            dtpDate.Visible = false;
        }

        protected void btnPick_Click(object sender, EventArgs e)
        {
            dtpDate.Visible = true;
        }
    }
}