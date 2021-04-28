using ClassLibrary;
using System;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Customer
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //check if the user is a staff member
                bool isStaff = false;
                if (Session["customerLoggedIn"] != null)
                {
                    if (Convert.ToBoolean(Session["customerLoggedIn"]) == true)
                    {
                        if (Session["customerIsStaff"] != null)
                        {
                            if (Convert.ToBoolean(Session["customerIsStaff"]) == true)
                            {
                                isStaff = true;
                            }
                        }
                    }
                }

                //if they are not staff, redirect them to logout
                //only staff is allowed to see customers
                if (!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }

                try
                {
                    //get the customer id from the url string
                    int customerId = Convert.ToInt32(Request.Params["custId"]);
                    if (customerId > 0)
                    {
                        //fetch the details of the customer with id given
                        clsCustomer ACustomer = new clsCustomer();
                        bool customerFound = ACustomer.FindCustomer(customerId);
                        int activeTickets = 0;

                        //id valid
                        if (customerFound)
                        {
                            //set value of the read-only fields to the details of the customer
                            txtAddress.Text = ACustomer.Address;
                            txtDOB.Text = ACustomer.DateOfBirth;
                            txtEmail.Text = ACustomer.Email;
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
                                        string date = ConnectionDetails.ConnectionDate.ToString("dd/MM/yyyy");
                                        string time = ConnectionDetails.ConnectionTime.ToString(@"hh\:mm");
                                        string active = ConnectionDetails.ConnectionActive ? "Active" : "Expired";

                                        ATicketItem.Text = $"TICKET {active}: {startLocation} - {endLocation} {date} {time}";
                                        activeTickets++;
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

                            if (activeTickets == 0)
                            {
                                //no tickets owned
                                lblNoTicketsFound.Visible = true;
                                btnCancelTicket.Visible = false;
                                lstTickets.Visible = false;
                                lblTicketSelected.Visible = false;
                            }
                            else
                            {
                                lblNoTicketsFound.Visible = false;
                                btnCancelTicket.Visible = true;
                                lstTickets.Visible = true;
                            }

                            //get payments of the user
                            clsPaymentCollection UserPayments = new clsPaymentCollection();
                            UserPayments.MyPayments = UserPayments.GetUserPayments(customerId);

                            //there are no payments
                            if (UserPayments.Count == 0)
                            {
                                lblNoPaymentsFound.Visible = true;
                            }
                            else
                            {
                                //show the controls
                                btnPayment.Visible = true;
                                lstPayments.Visible = true;

                                //for each payment, add it into the list
                                for (int i = 0; i < UserPayments.Count; ++i)
                                {
                                    //create a list item to show the payment
                                    ListItem APaymentItem = new ListItem();
                                    APaymentItem.Value = Convert.ToString(UserPayments.MyPayments[i].PaymentId);

                                    //assign details of a payment to the variables
                                    string paymentId = Convert.ToString(UserPayments.MyPayments[i].PaymentId);
                                    string paymentValue = Convert.ToString(UserPayments.MyPayments[i].PaymentValue);
                                    string paymentStartDate = UserPayments.MyPayments[i].PaymentStartDate.ToString("dd/MM/yyyy HH:mm:ss");
                                    string paymentEndDate = UserPayments.MyPayments[i].PaymentEndDate.ToString("dd/MM/yyyy HH:mm:ss");

                                    //assign the text to the list item
                                    APaymentItem.Text = $"PayID: {paymentId} || Start: {paymentStartDate} || End: {paymentEndDate} || Value: {paymentValue}";
                                    
                                    //add the list item to the list
                                    lstPayments.Items.Add(APaymentItem);
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
            string selectedValue = lstPayments.SelectedValue;
            //check if the selection was made
            if (selectedValue == "" || selectedValue == "0")
            {
                //if it was not, show an error
                lblPaymentSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("../Payment/Payment.aspx?paymentId=" + lstPayments.SelectedValue);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }
    }
}