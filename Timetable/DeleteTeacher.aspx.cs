using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class DeleteTeacher : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Sets UserID variable, if blank then redirects to login since it should not be blank
            UserID = Convert.ToInt32(Session["UserID"]);
            if (Session["UserID"] == null || UserID == 3) { Response.Redirect("TeacherLogin.aspx"); }

            //Finds RoomID, changes page text depending on the room name for that Room ID
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            lblDelete.Text = $"Are you sure you want to delete the account for {Users.ThisUser.FullNameEmail}";
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //Redirects back to teacher management page
            Response.Redirect("ManageTeachers.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //Run when btnYes is clicked, deletes teacher and their timetable if Mode is admin
            clsUserCollection UserList = new clsUserCollection();
            clsTimetableCollection Timetables = new clsTimetableCollection();
            clsMessageCollection Messages = new clsMessageCollection();
            if (Convert.ToString(Session["Mode"]) == "Admin")
            {
                UserList.Delete(UserID);
                Timetables.DeleteTimetable(UserID);
                Messages.Delete(UserID);
                Response.Redirect("ManageTeachers.aspx");
            }
            else { Response.Redirect("Default.aspx"); }
        }
    }
}