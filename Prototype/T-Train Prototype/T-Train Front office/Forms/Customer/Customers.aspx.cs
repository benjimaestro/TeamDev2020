using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Customer
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnFilterCustomers_Click(object sender, EventArgs e)
        {
            //redirect to filtered customer list
            Response.Redirect("Customers.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //redirect to customer screen view
            Response.Redirect("Customer.aspx");
        }

        protected void btnCustomer2_Click(object sender, EventArgs e)
        {
            //redirect to customer screen view
            Response.Redirect("Customer.aspx");
        }

        protected void btnCustomer3_Click(object sender, EventArgs e)
        {
            //redirect to customer screen view
            Response.Redirect("Customer.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../Default.aspx");
        }
    }
}