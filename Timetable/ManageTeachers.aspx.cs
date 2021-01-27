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
            Response.Redirect("Teacher.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteTeacher.aspx");
        }
    }
}