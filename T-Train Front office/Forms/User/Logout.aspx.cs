using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.User
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //reset and end the current session
            Session.Abandon();
            //check if this resulted from a password update
            try
            {
                int passwordChanged = Convert.ToInt32(Request.Params["passwordChanged"]);
                if(passwordChanged == 1)
                {
                    lblLogoutNotice.Text = "Your password was updated and you were logged out for security reasons. " +
                        "Please log in again.";
                }
            }
            catch
            {
                //considered as error
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}