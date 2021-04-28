using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (!IsPostBack)
            {
                //check if the user is logged in and if they are staff
                bool isStaff = false;
                bool loggedIn = false;
                if (Session["customerLoggedIn"] != null)
                {
                    if (Convert.ToBoolean(Session["customerLoggedIn"]) == true)
                    {
                        loggedIn = true;
                        if (Session["customerIsStaff"] != null)
                        {
                            if (Convert.ToBoolean(Session["customerIsStaff"]) == true)
                            {
                                isStaff = true;
                            }
                        }
                    }
                }

                btnStaffDashboard.Visible = isStaff;
                btnTickets.Visible = loggedIn;
                btnSettings.Visible = loggedIn;
                btnLogin.Visible = !loggedIn;
                btnSignup.Visible = !loggedIn;
                btnLogout.Visible = loggedIn;

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

                        //create a list item
                        ListItem timeItem = new ListItem
                        {
                            Text = hourToAdd + ":" + minutesToAdd,
                            Value = hourToAdd + ":" + minutesToAdd
                        };

                        //add the time to the dropdown list
                        ddlTime.Items.Add(timeItem);
                    }
                }

                //declare search parameters
                string from;
                string to;
                DateTime date;
                string time;
                clsConnection AConnection = new clsConnection();
                bool valid;

                try
                {
                    //get the search parameters from the url
                    from = Request.Params["from"];
                    to = Request.Params["to"];
                    date = Convert.ToDateTime(Request.Params["date"]);
                    time = Request.Params["time"];

                    //next assign the parameters
                    AConnection.ConnectionActive = true;
                    AConnection.ConnectionStartStation = from;
                    AConnection.ConnectionEndStation = to;
                    AConnection.ConnectionDate = date;
                    AConnection.ConnectionTime = TimeSpan.Parse(time);

                    //next validate the parameters
                    string error = AConnection.ValidateConnection(date, from, to, 0);

                    //check if the parameters are valid
                    valid = (error == "");
                }
                catch
                {
                    valid = false;
                }

                //declare a class to store connections found
                clsConnectionCollection Connections = new clsConnectionCollection();

                //if search parameters are valid, filter connections
                if (valid)
                {
                    //filter connections with the parameters specified
                    Connections.MyConnections = Connections.FilterConnections(AConnection);
                    //fill the filtering boxes with parameters entered
                    ddlFrom.SelectedValue = AConnection.ConnectionStartStation;
                    ddlTo.SelectedValue = AConnection.ConnectionEndStation;
                    txtDate.Text = AConnection.ConnectionDate.ToString("dd/MM/yyyy");
                    ddlTime.SelectedValue = AConnection.ConnectionTime.ToString(@"hh\:mm");
                }
                else
                {
                    //some parameters were invalid so instead we display all public connections
                    //by default we will also display all public connections
                    Connections.MyConnections = Connections.ListConnections();
                }

                int activeConnections = 0;
                //there are no connections
                if (Connections.Count == 0)
                {
                    lblNoConsFound.Visible = true;
                }
                else
                {
                    //show the default controls
                    lstConnections.Visible = true;
                    btnBookTicket.Visible = true;

                    //only staff can manage connections
                    if(isStaff)
                    {
                        btnManageConnection.Visible = true;
                    }

                    //for each connection, add it into the list
                    for (int i = 0; i < Connections.Count; ++i)
                    {
                        //only add connections with purchasable tickets
                        //staff can see all connections
                        if(Connections.MyConnections[i].ConnectionTicketLimit > 0 || isStaff)
                        {
                            //only add public connections
                            //staff can see private as well
                            if(Connections.MyConnections[i].ConnectionActive == true || isStaff)
                            {
                                ListItem AConnectionItem = new ListItem
                                {
                                    Text = Connections.MyConnections[i].ConnectionStartStation
                                    + " - " + Connections.MyConnections[i].ConnectionEndStation
                                    + " || " + Connections.MyConnections[i].ConnectionDate.ToString("dd/MM/yyyy")
                                    + " || " + Connections.MyConnections[i].ConnectionTime.ToString(@"hh\:mm"),
                                    Value = Convert.ToString(Connections.MyConnections[i].ConnectionId)
                                };
                                lstConnections.Items.Add(AConnectionItem);

                                activeConnections++;
                            }
                        }
                    }
                }

                if(activeConnections == 0)
                {
                    //there are connections but they are either sold out or you already have a ticket for them
                    lblNoConsFound.Visible = true;
                    lstConnections.Visible = false;
                    btnBookTicket.Visible = false;
                    btnManageConnection.Visible = false;
                }
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

                //next validate the parameters
                clsConnection aConnection = new clsConnection();
                string error = aConnection.ValidateConnection(date, from, to, 0);

                //if they are valid, filter connections
                if (error == "")
                {
                    if(from == to)
                    {
                        //display an error message on screen
                        lblError.Text = "Start and end location cannot be the same.";
                    }
                    else
                    {
                        //redirect to a filtered list of connections
                        Response.Redirect($"Connections.aspx?from={from}&to={to}&date={date}&time={time}");
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                //if invalid, display an error message on screen
                lblError.Text = "Entered data is invalid, please try again.";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }

        protected void btnBookTicket_Click1(object sender, EventArgs e)
        {
            //get the selected connection's id
            string selectedValue = lstConnections.SelectedValue;
            //check if the selection was made
            if (selectedValue == "")
            {
                //if it was not, show an error
                lblConnSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("../Ticket/BookTicket.aspx?connId=" + lstConnections.SelectedValue);
        }

        protected void btnManageConnection_Click(object sender, EventArgs e)
        {
            //get the selected connection's id
            string selectedValue = lstConnections.SelectedValue;
            //check if the selection was made
            if (selectedValue == "")
            {
                //if it was not, show an error
                lblConnSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("Connection.aspx?connId=" + lstConnections.SelectedValue);
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