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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            { 
                DisplayUsers(); 
            }
        }

        void DisplayUsers()
        {
            clsUserCollection Users = new clsUserCollection();
            lstTeachers.Items.Clear();
            lstTeachers.DataSource = Users.Userlist;
            lstTeachers.DataValueField = "Id";
            lstTeachers.DataTextField = "FullNameEmail";
            lstTeachers.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["UserID"] = -1;
            Session["Mode"] = "Admin";
            Response.Redirect("Teacher.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 UserID;
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
            Int32 UserID;
            if (lstTeachers.SelectedIndex != -1)
            {
                UserID = Convert.ToInt32(lstTeachers.SelectedValue);
                Session["UserID"] = UserID;
                Session["Mode"] = "Admin";
                Response.Redirect("DeleteTeacher.aspx");
            }
            else { lblError.Text = "You must select a user to modify"; }
        }

        protected void btnSearchNames_Click(object sender, EventArgs e)
        {
            clsUserCollection Users = new clsUserCollection();
            Users.FilterByName(txtFilter.Text);
            lstTeachers.Items.Clear();
            lstTeachers.DataSource = Users.Userlist;
            lstTeachers.DataValueField = "Id";
            lstTeachers.DataTextField = "FullNameEmail";
            lstTeachers.DataBind();
        }

        protected void btnSearchEMails_Click(object sender, EventArgs e)
        {
            clsUserCollection Users = new clsUserCollection();
            Users.FilterByEMail(txtFilter.Text);
            lstTeachers.Items.Clear();
            lstTeachers.DataSource = Users.Userlist;
            lstTeachers.DataValueField = "Id";
            lstTeachers.DataTextField = "FullNameEmail";
            lstTeachers.DataBind();
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        protected void btnTimetable_Click(object sender, EventArgs e)
        {
            Int32 UserID;
            if (lstTeachers.SelectedIndex != -1)
            {
                UserID = Convert.ToInt32(lstTeachers.SelectedValue);
                Session["WeekNo"] = 1;
                Session["UserID"] = UserID;
                Session["Mode"] = "Admin";
                Response.Redirect("Timetable.aspx");
            }
            else { lblError.Text = "You must select a user to modify"; }
        }
    }
}