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

            if(email != "" && password != "")
            {
                clsCustomer ACustomer = new clsCustomer();
                bool customerFound = ACustomer.FindCustomerByEmail(email);

                if(customerFound)
                {
                    if(ACustomer.AccountPassword == ACustomer.GetHashPassword(password))
                    {
                        //user logged in
                        Session["customerId"] = ACustomer.CustomerId;
                        Session["customerIsStaff"] = ACustomer.IsStaff;
                        Session["customerLoggedIn"] = true;
                        //redirect user to homepage
                        Response.Redirect("../Default.aspx");
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