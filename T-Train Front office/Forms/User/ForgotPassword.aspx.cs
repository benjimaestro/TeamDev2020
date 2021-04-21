using ClassLibrary;
using System;

namespace T_Train_Front_office.Forms.User
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //redirect to the login screen
            Response.Redirect("Login.aspx");
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                clsCustomer ACustomer = new clsCustomer();
                bool customerFound = ACustomer.FindCustomerByEmail(txtEmail.Text);
                if (customerFound)
                {
                    Session["passChangeCode"] = ACustomer.SendResetEmail("TTrain");
                    Session["customerId"] = ACustomer.CustomerId;
                    Response.Redirect("ResetPassword.aspx");
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }

        protected void btnSignup2_Click(object sender, EventArgs e)
        {
            //redirect to the new account screen
            Response.Redirect("Signup.aspx");
        }
    }
}