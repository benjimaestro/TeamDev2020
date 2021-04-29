using ClassLibrary;
using System;
using System.Linq;

namespace T_Train_Front_office.Forms.User
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            //Class to store the customer data
            clsCustomer NewCustomer = new clsCustomer();
            string passwordText = txtPassword.Text;
            
            if(passwordText != txtRepeatPassword.Text)
            {
                lblPasswordMitmatch.Visible = true;
            }
            else
            {
                lblPasswordMitmatch.Visible = false;
            }

            //check if password meets the security requirements
            bool passwordSecure = NewCustomer.ValidatePassword(passwordText);
            if (!passwordSecure)
            {
                lblPasswordInsecure.Visible = true;
            }
            else lblPasswordInsecure.Visible = false;

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtDateOfBirth.Text == "" || !passwordSecure
                || txtEmail.Text == "" || txtPassword.Text == "" || txtRepeatPassword.Text == "" || txtPassword.Text != txtRepeatPassword.Text)
            {
                lblMissingData.Visible = true;
            }
            else
            {
                //save the new account data from the form
                NewCustomer.FirstName = txtFirstName.Text;
                NewCustomer.LastName = txtLastName.Text;
                NewCustomer.Address = txtAddress.Text;
                NewCustomer.DateOfBirth = txtDateOfBirth.Text;
                NewCustomer.Email = txtEmail.Text;
                string hashedPassword = NewCustomer.GetHashPassword(txtPassword.Text);
                NewCustomer.AccountPassword = hashedPassword;

                //check whether the account already exists
                bool accountExists = NewCustomer.FindCustomerByEmail(NewCustomer.Email);

                if(accountExists)
                {
                    //display error: account already exists
                    lblEmailExists.Visible = true;
                    lblMissingData.Visible = false;
                    lblPasswordMitmatch.Visible = false;
                }
                else
                {
                    //create a new account
                    clsCustomerCollection AccountManager = new clsCustomerCollection();
                    AccountManager.ThisCustomer = NewCustomer;
                    AccountManager.CreateAccount();

                    //redirect to login screen with success message
                    Response.Redirect("Login.aspx?accCreated=1");
                }
            }
        }

        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            //redirect to the login page
            Response.Redirect("Login.aspx");
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            //redirect to forgot password form
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}