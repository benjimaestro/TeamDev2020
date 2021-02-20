using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class TeacherDefault : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Sets UserID to the UserID session object, passed from the login page
            UserID = Convert.ToInt32(Session["UserID"]);
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            //Greet user with name retrieved with the ID
            lblTitle.Text = $"Hello, {Users.ThisUser.FirstName} {Users.ThisUser.SecondName}";
        }

        protected void btnViewTimetable_Click(object sender, EventArgs e)
        {
            //Redirect user to their Timetable
            Session["WeekNo"] = 1;
            Session["Mode"] = "Teacher";
            Session["UserID"] = UserID;
            Response.Redirect("Timetable.aspx");
        }

        protected void btnContact_Click(object sender, EventArgs e)
        {
            //Redirect user to their Contact messages
            Session["Mode"] = "Teacher";
            Session["UserID"] = UserID;
            Response.Redirect("Contact.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Redirect user to change their password
            Session["Mode"] = "Teacher";
            Session["UserID"] = UserID;
            Response.Redirect("Teacher.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Mode"] = "Guest";
            Response.Redirect("TeacherLogin.aspx");
        }
    }
}