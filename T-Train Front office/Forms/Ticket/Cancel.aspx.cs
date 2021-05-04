using ClassLibrary;
using System;
using System.Web;

namespace T_Train_Front_office.Forms.Ticket
{
    public partial class Cancel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                try
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
                    //only staff is allowed to cancel tickets
                    if (!isStaff)
                    {
                        Response.Redirect("../User/Logout.aspx");
                    }

                    //get the ticket id from the url string
                    int ticketId = Convert.ToInt32(Request.Params["ticketId"]);
                    if (ticketId > 0)
                    {
                        //fetch the details of the ticket with id given
                        clsTicket ATicket = new clsTicket();
                        bool ticketFound = ATicket.FindTicket(ticketId);

                        //id valid
                        if (ticketFound)
                        {
                            //fetch the details of the customer with id given
                            clsCustomer ACustomer = new clsCustomer();
                            bool customerFound = ACustomer.FindCustomer(ATicket.CustomerId);

                            //fetch the details of the connection with id given
                            clsConnection AConnection = new clsConnection();
                            bool connectionFound = AConnection.FindConnection(ATicket.ConnectionId);

                            //fill the data regarding the customer
                            if(customerFound)
                            {
                                lblCustomerName.Text = HttpUtility.HtmlAttributeEncode(ACustomer.FirstName + " " + ACustomer.LastName);
                                //customer exists so we can go back to them
                                btnCustomer.Visible = true;
                            }
                            else
                            {
                                lblCustNotFound.Visible = true;
                            }
                            
                            //fill the data regarding the connection
                            if(connectionFound)
                            {
                                lblConnLocation.Text = "🚇 " + HttpUtility.HtmlAttributeEncode(AConnection.ConnectionStartStation + " - " + AConnection.ConnectionEndStation);
                                lblConnDate.Text = "📆 " + AConnection.ConnectionDate.ToString("dd/MM/yyyy");
                                lblConnTime.Text = "⌚ " + AConnection.ConnectionTime.ToString(@"hh\:mm");
                            }
                            else
                            {
                                lblConnNotFound.Visible = true;
                            }

                            //ticket purchase date
                            lblPurchasedAt.Text = "Ticket purchase date: " + ATicket.PurchasedAt.ToString("dd/MM/yyyy");
                            //the ticket exists so it can be cancelled
                            btnCancelTicket.Visible = true;
                        }
                        else
                        {
                            //valid id was passed but the ticket with this id was not found
                            lblTicketNotFound.Visible = true;
                        }
                    }
                    else
                    {
                        //invalid numerical id was passed as a ticket id
                        lblTicketNotFound.Visible = true;
                    }
                }
                catch
                {
                    //incorrect ticket id was passed, redirect to an error form
                    Response.Redirect("../StaffDashboard.aspx");
                }
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnCustomer2_Click(object sender, EventArgs e)
        {
            //get the ticket id from the url string
            int ticketId = Convert.ToInt32(Request.Params["ticketId"]);
            //fetch the details of the ticket with id given
            clsTicket ATicket = new clsTicket();
            bool ticketFound = ATicket.FindTicket(ticketId);
            //redirect to customer screen view
            Response.Redirect("../Customer/Customer.aspx?custId="+ATicket.CustomerId);
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnCancelTicket_Click(object sender, EventArgs e)
        {
            //get the ticket id from the url string
            int ticketId = Convert.ToInt32(Request.Params["ticketId"]);
            //find the ticket to cancel
            clsTicket TicketToCancel = new clsTicket();
            TicketToCancel.FindTicket(ticketId);
            //cancel the ticket
            clsTicketCollection TicketManager = new clsTicketCollection();
            TicketManager.ThisTicket = TicketToCancel;
            TicketManager.DeleteTicket();
            //redirect to action confirmation
            Response.Redirect("../User/ActionSuccess.aspx?origin=ticket&action=cancelled");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }
    }
}