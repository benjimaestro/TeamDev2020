using ClassLibrary;
using System;

namespace T_Train_Front_office.Forms.User
{
    public partial class Settings : System.Web.UI.Page
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

                //get the customer id from the session object
                int customerId = Convert.ToInt32(Session["customerId"]);
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
                        txtEmail.Text = ACustomer.Email;
                        txtFirstName.Text = ACustomer.FirstName;
                        txtLastName.Text = ACustomer.LastName;
                    }
                }
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("Default.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnTickets_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("../Ticket/MyTickets.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //update 2fa
            Response.Redirect("Settings.aspx");
        }

        protected void btnPassword_Click(object sender, EventArgs e)
        {
            //get the form inputs
            string currentPassword = txtPassword.Text;
            string newPassword = txtNewPass.Text;
            string newPasswordRepeat = txtNewPassRep.Text;

            //get the current user password
            int customerId = Convert.ToInt32(Session["customerId"]);
            clsCustomer ACustomer = new clsCustomer();
            bool customerFound = ACustomer.FindCustomer(customerId);
            
            if(currentPassword.Length < 8 || newPassword.Length < 8 || newPasswordRepeat.Length < 8)
            {
                lblPasswordError.Text = "Password must be at least 8 characters long.";
            }
            else if(customerFound)
            {
                //compare the entered current password with the actual password
                if (ACustomer.GetHashPassword(currentPassword) == ACustomer.AccountPassword)
                {
                    //compare the new password with the repeated new password
                    if(newPassword == newPasswordRepeat)
                    {
                        //hash the new password
                        newPassword = ACustomer.GetHashPassword(newPassword);
                        //update user password
                        ACustomer.UpdatePassword(newPassword);
                        //log the user off
                        Response.Redirect("Logout.aspx?passwordChanged=1");
                    }
                    else
                    {
                        lblPasswordError.Text = "Entered passwords aren't matching!";
                    }
                }
                else
                {
                    lblPasswordError.Text = "Entered password for your account is incorrect!";
                }
            }
            else
            {
                Response.Redirect("Logout.aspx");
            }
        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            //get current customer data
            clsCustomer NewCustomerDetails = new clsCustomer();
            NewCustomerDetails.CustomerId = Convert.ToInt32(Session["customerId"]);
            bool customerFound = NewCustomerDetails.FindCustomer(NewCustomerDetails.CustomerId);
            
            if(customerFound)
            {
                //replace the current details with the new details
                NewCustomerDetails.Address = txtAddress.Text;
                NewCustomerDetails.DateOfBirth = txtDOB.Text;
                NewCustomerDetails.FirstName = txtFirstName.Text;
                NewCustomerDetails.LastName = txtLastName.Text;

                //save changes
                clsCustomerCollection CustomerManager = new clsCustomerCollection();
                CustomerManager.ThisCustomer = NewCustomerDetails;
                CustomerManager.ChangeDetails();

                //show success label
                lblDetailsChanged.Visible = true;
            }
            else
            {
                //session expired, redirect logout
                Response.Redirect("Logout.aspx");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete account
            Response.Redirect("Settings.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("Logout.aspx");
        }
    }
}