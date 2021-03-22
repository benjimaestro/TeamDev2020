using ClassLibrary;
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
            bool loggedIn = true;
            bool isStaff = false;

            btnStaffDashboard.Visible = isStaff;
            btnTickets.Visible = loggedIn;
            btnSettings.Visible = loggedIn;
            btnLogin.Visible = !loggedIn;
            btnSignup.Visible = !loggedIn;
            btnLogout.Visible = loggedIn;

            bool filteringActive = true;

            if (filteringActive)
            {
                lblConsDate.Visible = true;
                lblConsHeader.Visible = true;
                lblConsPublic.Visible = true;
                lblConsRoute.Visible = true;
                lblConsTime.Visible = true;
                btnBookTicket.Visible = true;
                btnManageConnection.Visible = true;
            }

            //Fill the time dropdown list
            for (int hour = 0; hour < 24; ++hour)
            {
                for (int minutes = 0; minutes < 60; minutes += 15)
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

            //if all search parameters exist and are valid, perform the search
            try
            {
                //get the search parameters from the url
                string from = Request.Params["from"];
                string to = Request.Params["to"];
                DateTime date = Convert.ToDateTime(Request.Params["date"]);
                string time = Request.Params["time"];

                //next assign the parameters
                clsConnection aConnection = new clsConnection();
                aConnection.ConnectionStartStation = from;
                aConnection.ConnectionEndStation = to;
                aConnection.ConnectionDate = date;

                //next validate the parameters
                string error = aConnection.ValidateConnection(date, from, to, 0);

                //check if the parameters are valid
                bool valid = (error == "");

                //if they are valid, filter connections
                if (valid)
                {
                    //filter connections with the parameters specified
                    clsConnectionCollection filteredConnections = new clsConnectionCollection();
                    //filteredConnections.MyConnections = filteredConnections.filterConnections(aConnection);
                    
                    //now for each connection, construct an appropriate section

                }
            }
            catch
            {
                //some parameters were invalid, no search performed
                //TODO: display error message
            }
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
            //first specify the filtering parameters
            try
            {
                //first get the parameters from text
                string from = ddlFrom.Text;
                string to = ddlTo.Text;
                DateTime date = Convert.ToDateTime(txtDate.Text);
                string time = ddlTime.Text;

                //next assign the parameters
                clsConnection aConnection = new clsConnection();
                aConnection.ConnectionStartStation = from;
                aConnection.ConnectionEndStation = to;
                aConnection.ConnectionDate = date;

                //next validate the parameters
                string error = aConnection.ValidateConnection(date, from, to, 0);

                //check if the parameters are valid
                bool valid = (error == "");

                //if they are valid, filter connections
                if (valid)
                {
                    //redirect to a filtered list of connections
                    Response.Redirect($"Connection/Connections.aspx?from={from}&to={to}&date={date}&time={time}");
                }
                else
                {
                    //if invalid, display an error message on screen
                    lblError.Text = "Entered data is invalid, please try again.";
                }
            }
            catch
            {
                //if invalid, display an error message on screen
                lblError.Text = "Entered data is invalid, please try again.";
            }
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
            Response.Redirect("../Ticket/BookTicket.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to a particular connection
            Response.Redirect("Connection.aspx");
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