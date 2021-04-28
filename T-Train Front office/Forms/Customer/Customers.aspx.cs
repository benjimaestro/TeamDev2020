using ClassLibrary;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Customer
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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
                //only staff is allowed to filter customers
                if (!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }
            }
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
            clsCustomer Customer = new clsCustomer();
            try
            {
                string firstname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                string dob = txtDOB.Text;
                lblCustSelected.Visible = false;

                if (firstname == "" && lastname == "" && dob == "")
                {
                    lblErrorDetails.Visible = true;
                    btnCustomer.Visible = false;
                    lstCustomers.Visible = false;
                    lblNoCustFound.Visible = false;
                    lblStaticResultsHeader.Visible = false;
                }
                else
                {
                    lblErrorDetails.Visible = false;
                    Customer.FirstName = firstname;
                    Customer.LastName = lastname;
                    Customer.DateOfBirth = dob;

                    clsCustomerCollection Customers = new clsCustomerCollection();
                    Customers.MyCustomers = Customers.FilterCustomers(Customer);

                    lblStaticResultsHeader.Visible = true;
                    lstCustomers.Items.Clear();
                    //there are no customers
                    if (Customers.Count == 0)
                    {
                        lblNoCustFound.Visible = true;
                        btnCustomer.Visible = false;
                        lstCustomers.Visible = false;
                    }
                    else
                    {
                        //show the controls
                        btnCustomer.Visible = true;
                        lstCustomers.Visible = true;
                        lblNoCustFound.Visible = false;

                        //for each customer, add them into the list
                        for (int i = 0; i < Customers.Count; ++i)
                        {
                            ListItem ACustomerItem = new ListItem
                            {
                                Text = Customers.MyCustomers[i].FirstName
                                + " " + Customers.MyCustomers[i].LastName
                                + " - " + Customers.MyCustomers[i].DateOfBirth
                                + " - " + Customers.MyCustomers[i].Email,
                                Value = Convert.ToString(Customers.MyCustomers[i].CustomerId)
                            };
                            lstCustomers.Items.Add(ACustomerItem);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //get the selected customer's id
            string selectedValue = lstCustomers.SelectedValue;
            //check if the selection was made
            if (selectedValue == "")
            {
                //if it was not, show an error
                lblCustSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("Customer.aspx?custId=" + lstCustomers.SelectedValue);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }
    }
}