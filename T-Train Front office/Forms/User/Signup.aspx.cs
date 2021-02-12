using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            //create a new account
            Response.Redirect("Signup.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //redirect to the login page
            Response.Redirect("Login.aspx");
        }

        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            //redirect to the login page
            Response.Redirect("Login.aspx");
        }
    }
}