using ClassLibrary;
using System;
using System.Web;

namespace T_Train_Front_office.Forms.Ticket
{
    public partial class BookTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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
                            }
                        }
                    }
                }

                //if they are not, redirect them to login
                if (!loggedIn)
                {
                    Response.Redirect("../User/Login.aspx");
                }

                try
                {
                    int connectionId = Convert.ToInt32(Request.Params["connId"]);
                    if (connectionId > 0)
                    {
                        //fetch the details of the connection with id given
                        clsConnection AConnection = new clsConnection();
                        bool connectionFound = AConnection.FindConnection(connectionId);

                        //fetch the price
                        clsTicketType ATicketType = new clsTicketType();
                        bool ticketTypeFound = ATicketType.FindTicketType(AConnection.TicketTypeId);

                        if(connectionFound && ticketTypeFound)
                        {
                            lblConnLoc.Text = "🚇 " + HttpUtility.HtmlAttributeEncode(AConnection.ConnectionStartStation) + " - " + HttpUtility.HtmlAttributeEncode(AConnection.ConnectionEndStation);
                            lblConnDate.Text = "📆 " + AConnection.ConnectionDate.ToString("dd/MM/yyyy");
                            lblConnTime.Text = "⌚ " + AConnection.ConnectionTime.ToString(@"hh\:mm");
                            lblConnPrice.Text = "£" + Convert.ToString(ATicketType.TicketTypePrice);
                        }
                        else
                        {
                            //correct id passed but connection or ticket type not found
                            throw new System.Exception();
                        }
                    }
                    else
                    {
                        //negative or incorrect numeral id passed
                        throw new System.Exception();
                    }
                }
                catch
                {
                    //no connection id or it is incorrect - redirect back to connections
                    //and show an error message
                    //log the error and notify staff
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
            Response.Redirect("MyTickets.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect to all connections screen
            Response.Redirect("../Connection/Connections.aspx");
        }

        protected void btnPayment_Click1(object sender, EventArgs e)
        {
            //get connection id and user id
            int connectionId = Convert.ToInt32(Request.Params["connId"]);
            int customerId = Convert.ToInt32(Session["customerId"]);

            //fetch the details of the connection with id given
            clsConnection AConnection = new clsConnection();
            bool connectionFound = AConnection.FindConnection(connectionId);

            //fetch the price
            clsTicketType ATicketType = new clsTicketType();
            bool ticketTypeFound = ATicketType.FindTicketType(AConnection.TicketTypeId);

            //fetch customer tickets
            clsTicketCollection TicketManager = new clsTicketCollection();
            TicketManager.MyTickets = TicketManager.GetUserTickets(customerId);

            //fetch customer data to make sure they are not deleting their account
            clsCustomer ACustomer = new clsCustomer();
            bool customerFound = ACustomer.FindCustomer(customerId);

            //make sure the customer has not purchased this ticket before
            bool ticketFound = false;
            foreach(clsTicket Ticket in TicketManager.MyTickets)
            {
                if(Ticket.ConnectionId == connectionId)
                {
                    ticketFound = true;
                }
            }

            if(connectionFound && ticketTypeFound && customerFound && !ticketFound && !ACustomer.DeletionStarted)
            {
                //check in real-time whether the last ticket wasn't sold out
                if(AConnection.ConnectionTicketLimit > 0)
                {
                    //create a ticket
                    clsTicket NewTicket = new clsTicket
                    {
                        ConnectionId = connectionId,
                        CustomerId = customerId,
                        TicketActive = true
                    };

                    //create a payment
                    clsPayment NewPayment = new clsPayment
                    {
                        CustomerId = customerId,
                        PaymentValue = ATicketType.TicketTypePrice,
                        PaymentStartDate = DateTime.Now,
                        PaymentEndDate = DateTime.Now.AddMinutes(1)
                    };

                    //reduce remaining tickets by 1
                    AConnection.MarkTicketPurchase();

                    //assign the ticket to the user
                    TicketManager.ThisTicket = NewTicket;
                    TicketManager.AddTicket();

                    //upload the payment
                    clsPaymentCollection PaymentManager = new clsPaymentCollection
                    {
                        ThisPayment = NewPayment
                    };
                    PaymentManager.AddPayment();

                    //redirect to action success
                    Response.Redirect("../User/ActionSuccess.aspx?origin=payment&action=success");
                }
                else
                {
                    //sadly no more tickets remain for this connection
                    Response.Redirect("../User/ActionSuccess.aspx?origin=payment&action=failure");
                }
            }
            else
            {
                //something was wrong with the ticket or customer is deleting account
                Response.Redirect("../User/ActionSuccess.aspx?origin=payment&action=failure");
            }
        }
    }
}