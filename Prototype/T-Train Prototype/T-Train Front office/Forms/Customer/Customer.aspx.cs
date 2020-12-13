using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Customer
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            //redirect to cancel ticket form
            Response.Redirect("../Ticket/Cancel.aspx");
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            //redirect to a payment screen view
            Response.Redirect("../Payment/Payment.aspx");
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