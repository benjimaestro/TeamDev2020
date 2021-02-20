using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class AdminDefault : System.Web.UI.Page
    {
        Int32 UserID = 0;
        Int32 LoggedInID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Sets UserID to the UserID session object, passed from the login page
            UserID = Convert.ToInt32(Session["UserID"]);
            LoggedInID = Convert.ToInt32(Session["LoggedInID"]);
            clsUserCollection Users = new clsUserCollection();
            Users.Find(LoggedInID);
            //Greet user with name retrieved with the ID
            lblTitle.Text = $"Hello, {Users.ThisUser.FirstName} {Users.ThisUser.SecondName} (Admin Mode)";
        }

        protected void btnTeachers_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageTeachers.aspx");
        }

        protected void btnRooms_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRooms.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Mode"] = "Guest";
            Response.Redirect("TeacherLogin.aspx");
        }
    }
}