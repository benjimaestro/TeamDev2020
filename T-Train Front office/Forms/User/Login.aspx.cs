using ClassLibrary;
using System;

namespace T_Train_Front_office.Forms.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string created = Request.Params["accCreated"];
                if(created == "1")
                {
                    lblAccCreated.Visible = true;
                }
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnSignup2_Click(object sender, EventArgs e)
        {
            //redirect to the new account screen
            Response.Redirect("Signup.aspx");
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            //redirect to the new account screen
            Response.Redirect("ForgotPassword.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //get the credentials from the form
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            //store login success
            bool loginDone = false;

            //prepare 2FA
            string codeTwoFactor = "";
            if (txtTwoFactor.Visible == true)
            {
                codeTwoFactor = txtTwoFactor.Text;
            }

            if(email != "" && (password != "" || txtTwoFactor.Visible == true))
            {
                clsCustomer ACustomer = new clsCustomer();
                bool customerFound = ACustomer.FindCustomerByEmail(email);

                if(customerFound)
                {
                    if(ACustomer.AccountPassword == ACustomer.GetHashPassword(password) || txtTwoFactor.Visible == true)
                    {
                        if(ACustomer.TwoFactorEnabled)
                        {
                            if(codeTwoFactor == ACustomer.TwoFactorCode && txtTwoFactor.Visible == true)
                            {
                                loginDone = true;
                            }
                            else if (txtTwoFactor.Visible == false)
                            {
                                lblTwoFactor.Visible = true;
                                txtTwoFactor.Visible = true;
                                txtEmail.Enabled = false;
                                txtPassword.Enabled = false;
                                txtPassword.Text = password;
                            }
                            else
                            {
                                lblError.Text = "Entered 2FA code is invalid.";
                            }
                        }
                        else
                        {
                            loginDone = true;
                        }

                        //check if login succesful
                        if(loginDone)
                        {
                            //check if account is pending deletion
                            if(ACustomer.DeletionStarted && ACustomer.DeletionStartDate.AddDays(14) < DateTime.Now)
                            {
                                //delete account
                                clsCustomerCollection CustomerManager = new clsCustomerCollection();
                                CustomerManager.ThisCustomer = ACustomer;
                                CustomerManager.CloseAccount();
                                //set inputs
                                lblAccCreated.Text = "Your account was succesfully deleted!<br>Thank you for using T-Train in the past.";
                                lblAccCreated.Visible = true;
                                txtEmail.Text = "";
                                txtPassword.Text = "";
                                txtTwoFactor.Text = "";
                                lblError.Visible = false;
                                txtTwoFactor.Enabled = false;
                            }
                            else
                            {
                                //user logged in
                                Session["customerId"] = ACustomer.CustomerId;
                                Session["customerIsStaff"] = ACustomer.IsStaff;
                                Session["customerLoggedIn"] = true;
                                //redirect user to homepage
                                Response.Redirect("../Default.aspx");
                            }
                        }
                    }
                    else
                    {
                        //incorrect password
                        //login for testing: admin@ttrain.com
                        //password for testing: testpassword1
                        lblError.Text = "Entered details are invalid.";
                    }
                }
                else
                {
                    //incorrect email
                    lblError.Text = "Entered details are invalid.";
                }
            }
            else
            {
                lblError.Text = "All fields are required!";
            }
        }
    }
}