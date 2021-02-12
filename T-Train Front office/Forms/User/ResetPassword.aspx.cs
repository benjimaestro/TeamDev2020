using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            //redirect to the new account screen
            Response.Redirect("Signup.aspx");
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            //validate email
            Response.Redirect("ResetPassword.aspx");
        }
    }
}