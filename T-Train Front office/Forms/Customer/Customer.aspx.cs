using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using T_Train_Classes;

namespace T_Train_Front_office.Forms.Customer
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    //get the customer id from the url string
                    int customerId = Convert.ToInt32(Request.Params["custId"]);
                    if (customerId > 0)
                    {
                        //fetch the details of the customer with id given
                        clsCustomer ACustomer = new clsCustomer();
                        bool customerFound = ACustomer.FindCustomer(customerId);

                        //id valid
                        if (customerFound)
                        {
                            //set value of the read-only fields to the details of the customer
                            txtAddress.Text = ACustomer.Address;
                            txtDOB.Text = ACustomer.DateOfBirth;
                            txtEmail.Text = ACustomer.EMail;
                            txtFirstName.Text = ACustomer.FirstName;
                            txtLastName.Text = ACustomer.LastName;

                            //get tickets of the user
                            clsTicketCollection UserTickets = new clsTicketCollection();
                            UserTickets.MyTickets = UserTickets.GetUserTickets(customerId);

                            //there are no tickets
                            if (UserTickets.Count == 0)
                            {
                                lblNoTicketsFound.Visible = true;
                            }
                            else
                            {
                                //show the controls
                                btnCancelTicket.Visible = true;
                                btnPayment.Visible = true;
                                lstTickets.Visible = true;

                                //for each ticket, add it into the list
                                for (int i = 0; i < UserTickets.Count; ++i)
                                {
                                    //get connection details for the ticket
                                    clsConnection ConnectionDetails = new clsConnection();
                                    bool found = ConnectionDetails.FindConnection(UserTickets.MyTickets[i].ConnectionId);

                                    //create a list item to show the ticket
                                    ListItem ATicketItem = new ListItem();
                                    ATicketItem.Value = Convert.ToString(UserTickets.MyTickets[i].TicketId);
                                    //assign the text to the list item
                                    if (found)
                                    {
                                        //assign details of a connection to the variables
                                        string startLocation = ConnectionDetails.ConnectionStartStation;
                                        string endLocation = ConnectionDetails.ConnectionEndStation;
                                        DateTime date = ConnectionDetails.ConnectionDate;
                                        //string time = ConnectionDetails.ConnectionTime;
                                        string active = ConnectionDetails.ConnectionActive ? "Active" : "Cancelled/Expired";

                                        ATicketItem.Text = startLocation + " - " + endLocation + " " + date + " " + active;
                                        //ATicketItem.Text = startLocation + " - " + endLocation + " " + date + " " + time + " " + active;
                                    }
                                    else
                                    {
                                        //connection invalid, add a list item with its id to let staff find out more details
                                        ATicketItem.Text = "Invalid connection ID: " + UserTickets.MyTickets[i].ConnectionId;
                                    }
                                    //add the list item to the list
                                    lstTickets.Items.Add(ATicketItem);
                                }
                            }
                        }
                    }
                }
                catch
                {
                    //incorrect customer id was passed, redirect to an error form
                    Response.Redirect("../StaffDashboard.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //redirect to filtered customer list
            Response.Redirect("../Customer/Customers.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            //redirect to cancel ticket form
            Response.Redirect("../Ticket/Cancel.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnCancelTicket_Click(object sender, EventArgs e)
        {
            //get the selected ticket's id
            string selectedValue = lstTickets.SelectedValue;
            //check if the selection was made
            if (selectedValue == "" || selectedValue == "0")
            {
                //if it was not, show an error
                lblTicketSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("../Ticket/Cancel.aspx?ticketId=" + lstTickets.SelectedValue);
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            //get the selected ticket's id
            string selectedValue = lstTickets.SelectedValue;
            //check if the selection was made
            if (selectedValue == "" || selectedValue == "0")
            {
                //if it was not, show an error
                lblTicketSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("../Payment/Payment.aspx?ticketId=" + lstTickets.SelectedValue);
        }

        protected void btnPayment2_Click(object sender, EventArgs e)
        {
            //redirect to a payment screen view
            Response.Redirect("../Payment/Payment.aspx");
        }

        protected void btnPayment3_Click(object sender, EventArgs e)
        {
            //redirect to a payment screen view
            Response.Redirect("../Payment/Payment.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}