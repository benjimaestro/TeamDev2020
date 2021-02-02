using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class Teacher : System.Web.UI.Page
    {
        Int32 UserID;
        string Mode;
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUserCollection Users = new clsUserCollection();

            foreach (string block in Users.AvailableSubjects)
            {
                ddlSubject.Items.Add(block);
            }
            UserID = Convert.ToInt32(Session["UserID"]);
            Mode = Convert.ToString(Session["Mode"]);

            if (UserID != -1)
            {
                if (IsPostBack == false)
                {
                    lblTitle.Text = "Change User Details";
                    Users.Find(UserID);
                    txtEmail.Text = Convert.ToString(Users.ThisUser.EMail);
                    txtFirstName.Text = Convert.ToString(Users.ThisUser.FirstName);
                    txtLastName.Text = Convert.ToString(Users.ThisUser.SecondName);
                    ddlSubject.SelectedValue = Users.ThisUser.Subject;
                }
                if (Mode != "Admin")
                {
                    lblTitle.Text = "Change Password";
                    txtEmail.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    ddlSubject.Enabled = false;
                }
            }
            else { lblTitle.Text = "New User Account"; }
        }

        string add()
        {
            String Error = "";
            clsUserCollection PreUsers = new clsUserCollection();
            PreUsers.FindExistingUser(txtEmail.Text);
            if (PreUsers.ThisUser.EMail != null)
            {
                Error = Error + "User already exists with that EMail!</br>";
            }

            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                Error = Error + "Passwords do not match!</br>";
            }
            clsUserCollection Users = new clsUserCollection();
            clsTimetableCollection Timetables = new clsTimetableCollection();

            Error = Error + Users.ThisUser.Validate(txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text, ddlSubject.SelectedValue);
            if (Error == "")
            {
                Users.ThisUser.EMail = txtEmail.Text;
                Users.ThisUser.Password = Users.GetHashPassword(txtPassword.Text);
                Users.ThisUser.FirstName = txtFirstName.Text;
                Users.ThisUser.SecondName = txtLastName.Text;
                Users.ThisUser.Subject = Convert.ToString(ddlSubject.SelectedValue);
                Int32 UserID = Users.Add();
                Timetables.GenerateTimetable(UserID);
                return Error;
            }
            else
            {
                lblError.Text = Error;
                return Error;
            }
        }

        string edit()
        {
            String Error = "";
            clsUserCollection PreUsers = new clsUserCollection();
            clsUserCollection Users = new clsUserCollection();
            PreUsers.FindExistingUser(txtEmail.Text);
            Users.FindExistingUser(txtEmail.Text);

            //Doesn't work!!!! Fix me so room cannot be changed to a room that already exists!!!!!
            if (PreUsers.ThisUser != null && PreUsers.ThisUser.EMail != Users.ThisUser.EMail)
            {
                Error = Error + "User already exists with that EMail!</br>";
            }

            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                Error = Error + "Passwords do not match!</br>";
            }

            Error = Error + Users.ThisUser.Validate(txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text, ddlSubject.SelectedValue);
            if (Error == "")
            {
                Users.ThisUser.EMail = txtEmail.Text;
                Users.ThisUser.Password = Users.GetHashPassword(txtPassword.Text);
                Users.ThisUser.FirstName = txtFirstName.Text;
                Users.ThisUser.SecondName = txtLastName.Text;
                Users.ThisUser.Subject = Convert.ToString(ddlSubject.SelectedValue);
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
            if (UserID == -1)
            {
                string Error = add();
                if (Error == "")
                {
                    if (Mode != "Admin") { Response.Redirect("TeacherDefault"); }
                    else { Response.Redirect("ManageTeachers.aspx"); }
                }
                else { lblError.Text = Error; }
            }
            else
            {
                string Error = edit();
                if (Error == "")
                {
                    if (Mode != "Admin") { Response.Redirect("TeacherDefault.aspx"); }
                    else { Response.Redirect("ManageTeachers.aspx"); }
                }
                else { lblError.Text = Error; }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            if (Mode != "Admin") { Response.Redirect("TeacherDefault.aspx"); }
            else { Response.Redirect("ManageTeachers.aspx"); }
        }
    }
}