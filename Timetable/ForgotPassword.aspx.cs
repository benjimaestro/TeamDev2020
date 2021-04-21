using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        Int32 UserID;
        Int32 LoggedInUser;
        string Mode;
        string TempPW;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Convert session objects
            UserID = Convert.ToInt32(Session["UserID"]);
            LoggedInUser = Convert.ToInt32(Session["LoggedInID"]);
            Mode = Convert.ToString(Session["Mode"]);
            TempPW = Convert.ToString(Session["TempPW"]);
        }

        string edit()
        {
            //Function to validate a User's info, and if it is valid then add it to DB
            String Error = "";
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);

            //Check if password confirmation matches
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                Error = Error + "Passwords do not match</br>";
            }
            //Check if code matches what the system has
            if (TempPW != txtEMailCode.Text)
            {
                Error = Error + "Incorrect EMail code</br>";
            }

            Error = Error + Users.ThisUser.Validate("placeholder@email.com", "abcde", "abcde", txtPassword.Text, "Any");
            if (Error == "")
            {
                Users.ThisUser.ID = UserID;
                Users.ThisUser.Password = Users.ThisUser.GetHashPassword(txtPassword.Text);
                Users.Edit();
                Session["UserID"] = Users.ThisUser.ID;
                return Error;
            }
            else
            {
                lblError.Text = Error;//Display errors, but intentionally!
                return Error;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Run when btnRegister is clicked
            //If UserID is -1, run for new User being added
            //Otherwise, edit User of provided ID
            string Error = edit();
            if (Error == "")
            {
                Response.Redirect("TeacherLogin.aspx");
            }

            else { lblError.Text = Error; }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Returns user to the appropriate page based on the Mode
            Response.Redirect("TeacherLogin.aspx");
        }
    }
}