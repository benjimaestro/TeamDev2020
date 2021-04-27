using ClassLibrary;
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
            //check if the user is logged in
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
                            btnStaffDashboard.Visible = true;
                        }
                    }
                }
            }

            //if they are not, redirect them to login
            if (!loggedIn)
            {
                Response.Redirect("../User/Login.aspx");
            }

            int customerId = Convert.ToInt32(Session["customerId"]);
            int activeTickets = 0;

            //get user tickets
            clsTicketCollection CustomerTickets = new clsTicketCollection();
            CustomerTickets.MyTickets = CustomerTickets.GetUserTickets(customerId);

            //for each ticket, add it into the list
            for (int i = 0; i < CustomerTickets.Count; ++i)
            {
                //first check if the ticket is active
                if (CustomerTickets.MyTickets[i].TicketActive == true)
                {
                    //get connection details for the ticket
                    clsConnection ConnectionDetails = new clsConnection();
                    bool found = ConnectionDetails.FindConnection(CustomerTickets.MyTickets[i].ConnectionId);

                    //check if the ticket is expired
                    bool expired = ConnectionDetails.ConnectionDate.AddDays(1) < DateTime.Now ? true : false;

                    //create a list item to show the ticket
                    ListItem ATicketItem = new ListItem();
                    ATicketItem.Value = Convert.ToString(CustomerTickets.MyTickets[i].TicketId);
                    //assign the text to the list item
                    if (found && !expired)
                    {
                        //assign details of a connection to the variables
                        string startLocation = ConnectionDetails.ConnectionStartStation;
                        string endLocation = ConnectionDetails.ConnectionEndStation;
                        string date = ConnectionDetails.ConnectionDate.ToString("dd/MM/yyyy");
                        string time = ConnectionDetails.ConnectionTime.ToString(@"hh\:mm");

                        ATicketItem.Text = "TICKET ACTIVE: " + startLocation + " - " + endLocation + " " + date + " " + time;

                        lstTickets.Items.Add(ATicketItem);
                        activeTickets++;
                    }
                    else
                    {
                        //connection invalid or ticket expired
                    }
                }
                else
                {
                    //ticket cancelled by staff
                }
            }

            //no active tickets were found
            if(activeTickets == 0)
            {
                //no tickets owned
                lblNoTickets.Visible = true;
                lblStaticFind.Visible = true;
                btnConnections.Visible = true;
                btnHomepage.Visible = true;
            }
            else
            {
                lstTickets.Visible = true;
                lblStaticYourTickets.Visible = true;
                lblAnother.Visible = true;
                btnConnections2.Visible = true;
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

        protected void btnConnections_Click(object sender, EventArgs e)
        {
            //redirect to all connections
            Response.Redirect("../Connection/Connections.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }
    }
}