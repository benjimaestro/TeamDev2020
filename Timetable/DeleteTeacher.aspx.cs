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
            UserID = Convert.ToInt32(Session["UserID"]);
            if (Session["UserID"] == null || UserID == 3) { Response.Redirect("Default.aspx"); }
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            lblDelete.Text = $"Are you sure you want to delete the account for {Users.ThisUser.FullNameEmail}";
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageTeachers.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            clsUserCollection UserList = new clsUserCollection();
            if (Convert.ToString(Session["Mode"]) == "Admin")
            {
                UserList.Delete(UserID);
                Response.Redirect("ManageTeachers.aspx");
            }
            else { Response.Redirect("Default.aspx"); }
        }
    }
}