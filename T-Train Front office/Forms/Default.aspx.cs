using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace T_Train_Front_office.Forms
{
    public partial class Defaul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bool loggedIn = false;
                bool isStaff = false;
                if (Session["customerLoggedIn"] != null)
                {
                    if (Convert.ToBoolean(Session["customerLoggedIn"]) == true)
                    {
                        loggedIn = true;
                        lblLoggedIn.Visible = true;
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

                        //add the time to the dropdown list
                        ddlTime.Items.Add(hourToAdd + ":" + minutesToAdd);
                    }
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
                        Response.Redirect($"Connection/Connections.aspx?from={from}&to={to}&date={date}&time={time}");
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
            Response.Redirect("User/Logout.aspx");
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