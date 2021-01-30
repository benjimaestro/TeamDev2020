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

        void login()
        {
            clsUserCollection Users = new clsUserCollection();
            string EMail = txtUsername.Text;
            string Password = Users.GetHashPassword(txtPassword.Text);
            Int32 ID = Users.Login(EMail, Password);
            if (ID > 0)
            {
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}