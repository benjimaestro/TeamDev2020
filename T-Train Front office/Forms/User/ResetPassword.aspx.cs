using ClassLibrary;
using System;

namespace T_Train_Front_office.Forms.User
{
    public partial class ResetPassword1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPassword_Click(object sender, EventArgs e)
        {
            //get the form inputs
            string resetCode = txtResetCode.Text;
            string newPassword = txtNewPass.Text;
            string newPasswordRepeat = txtNewPassRep.Text;

            //get the current user details
            int customerId = Convert.ToInt32(Session["customerId"]);
            clsCustomer ACustomer = new clsCustomer();
            bool customerFound = ACustomer.FindCustomer(customerId);

            //check the new password is secure enough
            bool passwordSecure = ACustomer.ValidatePassword(newPassword);
            if (!passwordSecure)
            {
                lblPasswordError.Text = "Password must be at least 8 characters long and<br>must contain a digit and a special character.";
            }
            else if (resetCode != Convert.ToString(Session["passChangeCode"]))
            {
                lblPasswordError.Text = "The entered code is invalid.";
            }
            else if (customerFound)
            {
                //compare the new password with the repeated new password
                if (newPassword == newPasswordRepeat)
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
                Response.Redirect("Logout.aspx");
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}