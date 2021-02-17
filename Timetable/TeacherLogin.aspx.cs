using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class TeacherLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Run when btnLogin is clicked
            clsUserCollection Users = new clsUserCollection();
            string EMail = txtUsername.Text;
            string Password = Users.GetHashPassword(txtPassword.Text);

            //Run login function, check if EMail and password match records
            Int32 ID = Users.Login(EMail, Password);
            if (ID > 0)
            {
                //If user's account is marked as an Admin account, set Mode to admin
                //and redirect to AdminDefault
                //Otherwise, set Mode to teacher and redirect to TeacherDefault
                Session["UserID"] = ID;
                if (Users.ThisUser.Admin == true)
                {
                    Session["Mode"] = "Admin";
                    Response.Redirect("AdminDefault.aspx");
                }
                else
                {
                    Session["Mode"] = "Teacher";
                    Response.Redirect("TeacherDefault.aspx");
                }
            }
            else
            {
                if (ID == -1) { lblError.Text = "Account does not exist"; }
                else { lblError.Text = "Incorrect password"; }
            }
        }
    }
}