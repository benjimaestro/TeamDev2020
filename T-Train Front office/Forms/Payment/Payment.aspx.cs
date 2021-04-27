using ClassLibrary;
using System;

namespace T_Train_Front_office.Forms.Payment
{
    public partial class Payment : System.Web.UI.Page
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
                //only staff is allowed to see payments
                if (!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }

                try
                {
                    //get the payment id from the url string
                    int paymentId = Convert.ToInt32(Request.Params["paymentId"]);
                    if (paymentId > 0)
                    {
                        //fetch the details of the payment with id given
                        clsPayment APayment = new clsPayment();
                        bool paymentFound = APayment.FindPayment(paymentId);
                        if (APayment.CustomerId > 0) btnCustomer.Visible = true;

                        //id valid
                        if (paymentFound)
                        {
                            //set value of the read-only fields to the details of the customer
                            lblPaymentValue.Text = "£" + Convert.ToString(APayment.PaymentValue);
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
                        //incorrect payment id was passed, show error
                        lblErrorNotFound.Visible = true;
                    }
                }
                catch
                {
                    //incorrect payment id was passed, show error
                    lblErrorNotFound.Visible = true;
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
            //get the payment id from the url string
            int paymentId = Convert.ToInt32(Request.Params["paymentId"]);
            //fetch the details of the payment to get customer id
            clsPayment APayment = new clsPayment();
            _ = APayment.FindPayment(paymentId);
            //fetch the details of the customer who bought this ticket
            clsCustomer ACustomer = new clsCustomer();
            _ = ACustomer.FindCustomer(APayment.CustomerId);
            //redirect to customer screen view
            Response.Redirect("../Customer/Customer.aspx?custId="+ ACustomer.CustomerId);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }
    }
}