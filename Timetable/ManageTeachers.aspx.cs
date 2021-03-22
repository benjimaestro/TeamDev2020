using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class ManageTeachers : System.Web.UI.Page
    {
        Int32 UserID = 0;
        Int32 LoggedInID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            { 
                DisplayUsers(); 
            }
            UserID = Convert.ToInt32(Session["UserID"]);
            LoggedInID = Convert.ToInt32(Session["LoggedInID"]);
        }

        void DisplayUsers()
        {
            //Function to populate lstTeachers with user accounts
            clsUserCollection Users = new clsUserCollection();
            lstTeachers.Items.Clear();
            lstTeachers.DataSource = Users.Userlist;
            lstTeachers.DataValueField = "Id";
            lstTeachers.DataTextField = "FullNameEmail";
            lstTeachers.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Run when btnAdd is clicked
            //Redirects to Teacher page but sets the UserID session object to
            //-1 to indicate that a new User is being added, rather than editing
            //an existing User
            Session["UserID"] = -1;
            Session["Mode"] = "Admin";
            Response.Redirect("Teacher.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //Run when btnEdit is clicked
            //Redirects to Teacher page but sets the UserID session object to
            //the ID of the selected User to indicate that an existing User is being edited, rather than adding
            //a new User
            //If no User is selected, show an error
            if (lstTeachers.SelectedIndex != -1)
            {
                UserID = Convert.ToInt32(lstTeachers.SelectedValue);
                Session["UserID"] = UserID;
                Session["Mode"] = "Admin";
                Response.Redirect("Teacher.aspx");
            }
            else { lblError.Text = "You must select a user to modify"; }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Run when btnDelete is clicked
            //Redirects to DeleteTeacher page but sets the UserID session object to
            //the ID of the selected user to indicate which user needs to be deleted
            //If no user is selected, show an error
            //User cannot delete their own account either
            if (Convert.ToInt32(lstTeachers.SelectedValue) == LoggedInID) { lblError.Text = "You cannot delete your own account"; }
            else
            {
                if (lstTeachers.SelectedIndex != -1)
                {
                    UserID = Convert.ToInt32(lstTeachers.SelectedValue);
                    Session["UserID"] = UserID;
                    Session["Mode"] = "Admin";
                    Response.Redirect("DeleteTeacher.aspx");
                }
                else { lblError.Text = "You must select a user to modify"; }
            }
        }

        protected void btnSearchNames_Click(object sender, EventArgs e)
        {
            //Populates lstTeachers with a list of names filtered by name
            clsUserCollection Users = new clsUserCollection();
            Users.FilterByName(txtFilter.Text);
            lstTeachers.Items.Clear();
            lstTeachers.DataSource = Users.Userlist;
            lstTeachers.DataValueField = "Id";
            lstTeachers.DataTextField = "FullNameEmail";
            lstTeachers.DataBind();
        }

        protected void btnSearchEmails_Click(object sender, EventArgs e)
        {
            //Populates lstTeachers with a list of names filtered by Email
            clsUserCollection Users = new clsUserCollection();
            Users.FilterByEmail(txtFilter.Text);
            lstTeachers.Items.Clear();
            lstTeachers.DataSource = Users.Userlist;
            lstTeachers.DataValueField = "Id";
            lstTeachers.DataTextField = "FullNameEmail";
            lstTeachers.DataBind();
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            //Populates lstTeachers with a list of names, unfiltered
            DisplayUsers();
        }

        protected void btnTimetable_Click(object sender, EventArgs e)
        {
            //Redirects to the timetable page for the selected user
            //Shows error if none selected
            Int32 UserID;
            if (lstTeachers.SelectedIndex != -1)
            {
                UserID = Convert.ToInt32(lstTeachers.SelectedValue);
                Session["WeekNo"] = 1;
                Session["UserID"] = UserID;
                Session["Mode"] = "Admin";
                Response.Redirect("Timetable.aspx");
            }
            else { lblError.Text = "You must select a user to manage the timetable of"; }
        }

        protected void btnMessages_Click(object sender, EventArgs e)
        {
            //Redirects to the messages page for the selected user
            //Shows error if none selected
            Int32 UserID;
            if (lstTeachers.SelectedIndex != -1)
            {
                UserID = Convert.ToInt32(lstTeachers.SelectedValue);
                Session["WeekNo"] = 1;
                Session["UserID"] = UserID;
                Session["Mode"] = "Admin";
                Response.Redirect("Contact.aspx");
            }
            else { lblError.Text = "You must select a user to message"; }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            //Returns user to AdminDefault page
            Response.Redirect("AdminDefault.aspx");
        }
    }
}