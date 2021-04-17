using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Payment
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    //get the ticket id from the url string
                    int ticketId = Convert.ToInt32(Request.Params["ticketId"]);
                    if (ticketId > 0)
                    {
                        //fetch the details of the payment with ticket id given
                        clsPayment APayment = new clsPayment();
                        bool paymentFound = APayment.FindPaymentByTickedId(ticketId);
                        if (APayment.CustomerId > 0) btnCustomer.Visible = true;

                        //id valid
                        if (paymentFound)
                        {
                            //set value of the read-only fields to the details of the customer
                            lblPaymentValue.Text = Convert.ToString(APayment.PaymentValue);
                            lblPaymentStartDate.Text = APayment.PaymentStartDate.ToString("dd/MM/yyyy HH:mm:ss");
                            string paymentED = APayment.PaymentEndDate == DateTime.MinValue ? "This payment has not been finalized." : APayment.PaymentEndDate.ToString("dd/MM/yyyy HH:mm:ss");
                            lblPaymentEndDate.Text = paymentED;
                        }
                        else
                        {
                            //payment not found
                            lblErrorNotFound.Visible = true;
                            lblED.Visible = false;
                            lblPSD.Visible = false;
                            lblPV.Visible = false;
                        }
                    }
                    else
                    {
                        //incorrect customer id was passed, redirect to an error form
                        Response.Redirect("../StaffDashboard.aspx");
                    }
                }
                catch
                {
                    //incorrect customer id was passed, redirect to an error form
                    Response.Redirect("../StaffDashboard.aspx");
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

        protected void btnCustomer2_Click(object sender, EventArgs e)
        {
            //get the ticket id from the url string
            int ticketId = Convert.ToInt32(Request.Params["ticketId"]);
            //fetch the details of the customer who bought this ticket
            clsTicket ATicket = new clsTicket();
            bool ticketFound = ATicket.FindTicket(ticketId);
            //redirect to customer screen view
            Response.Redirect("../Customer/Customer.aspx?custId="+ATicket.CustomerId);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}