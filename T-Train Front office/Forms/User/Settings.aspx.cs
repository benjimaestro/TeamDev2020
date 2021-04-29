using ClassLibrary;
using System;
using System.Linq;

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
                        chkTwoFactor.Checked = ACustomer.TwoFactorEnabled;
                        chkTwoFactor.Text = ACustomer.TwoFactorEnabled ? "Enabled" : "Disabled";
                        btnTwoFactor.Text = ACustomer.TwoFactorEnabled ? "Disable 2FA" : "Enable 2FA";
                        btnTwoFactor.Enabled = !isStaff; //staff can't disable their 2FA
                        txtTwoFactorCode.Enabled = !isStaff; //staff can't disable their 2FA
                        lblDeletionStatus.Text = ACustomer.DeletionStarted ? $"Deletion status: Pending ({ACustomer.DeletionStartDate})" : "No pending deletion.";
                        btnDeleteAccount.Text = ACustomer.DeletionStarted ? "Stop Deletion" : "Delete Account";
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
            //get the code from the textbox
            string codeTwoFactor = txtTwoFactorCode.Text;
            //validate the code
            if(codeTwoFactor.Length == 8)
            {
                lblCodeLength.Visible = false;
                if(codeTwoFactor.All(char.IsDigit))
                {
                    lblCodeDigits.Visible = false;
                    //fetch the details of the customer with id given
                    clsCustomer ACustomer = new clsCustomer();
                    bool customerFound = ACustomer.FindCustomer(Convert.ToInt32(Session["customerId"]));
                    ACustomer.TwoFactorCode = codeTwoFactor;
                    //check the user exists
                    if (!customerFound) Response.Redirect("Logout.aspx");
                    //update the 2FA settings for the user
                    ACustomer.ToggleTwoFactorAuthentication();
                    //also update it within the class
                    ACustomer.TwoFactorEnabled = !ACustomer.TwoFactorEnabled;
                    //show a success message
                    lblTwoFactorDone.Visible = true;
                    //switch the button text and checkboxes
                    chkTwoFactor.Checked = ACustomer.TwoFactorEnabled;
                    chkTwoFactor.Text = ACustomer.TwoFactorEnabled ? "Enabled" : "Disabled";
                    btnTwoFactor.Text = ACustomer.TwoFactorEnabled ? "Disable 2FA" : "Enable 2FA";
                    txtTwoFactorCode.Text = "";
                }
                else
                {
                    //code must be made of only digits
                    lblCodeDigits.Visible = true;
                    lblTwoFactorDone.Visible = false;
                }
            }
            else
            {
                //code must be 8 characters long
                lblCodeLength.Visible = true;
                lblTwoFactorDone.Visible = false;
            }
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

            //check the new password is secure enough
            bool passwordSecure = ACustomer.ValidatePassword(newPassword);
            if (!passwordSecure)
            {
                lblPasswordError.Text = "Password must be at least 8 characters long and<br>must contain a digit and a special character.";
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

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            //get the form inputs
            string currentPassword = txtDelete.Text;
    
            //get the current user password
            int customerId = Convert.ToInt32(Session["customerId"]);
            clsCustomer ACustomer = new clsCustomer();
            bool customerFound = ACustomer.FindCustomer(customerId);

            if (ACustomer.AccountPassword == ACustomer.GetHashPassword(currentPassword))
            {
                DateTime deletionStartDate = DateTime.Now;
                lblDeletionError.Visible = false;
                //update it within the class
                ACustomer.DeletionStartDate = deletionStartDate;
                //invoke the method
                ACustomer.ToggleDeletion();
                //update it within the class
                ACustomer.DeletionStarted = !ACustomer.DeletionStarted;
                //show a success message
                lblDeletionSuccess.Visible = true;
                lblDeletionSuccess.Text = !ACustomer.DeletionStarted ? "Account deletion stopped!" : "Account deletion started!";
                //switch the button text and checkboxes
                lblDeletionStatus.Text = ACustomer.DeletionStarted ? $"Deletion status: Pending ({deletionStartDate})" : "No pending deletion.";
                btnDeleteAccount.Text = ACustomer.DeletionStarted ? "Stop Deletion" : "Delete Account";
                txtDelete.Text = "";
            }
            else if (customerFound)
            {
                lblDeletionError.Text = "Entered password for your account is incorrect!";
                lblDeletionSuccess.Visible = false;
            }
            else
            {
                //customer not found
                Response.Redirect("Logout.aspx");
            }
        }
    }
}