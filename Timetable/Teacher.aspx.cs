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
                    lblTitle.Text = "Change user details";
                    Users.Find(UserID);
                    txtEmail.Text = Convert.ToString(Users.ThisUser.EMail);
                    txtFirstName.Text = Convert.ToString(Users.ThisUser.FirstName);
                    txtLastName.Text = Convert.ToString(Users.ThisUser.SecondName);
                    ddlSubject.SelectedValue = Users.ThisUser.Subject;
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

            //Error = Error + Users.ThisUser.Valid();
            if (Error == "")
            {
                Users.ThisUser.EMail = txtEmail.Text;
                Users.ThisUser.Password = Users.GetHashPassword(txtEmail.Text);
                Users.ThisUser.FirstName = txtFirstName.Text;
                Users.ThisUser.SecondName = txtLastName.Text;
                Users.ThisUser.Subject = Convert.ToString(ddlSubject.SelectedValue);
                Users.Add();
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
            //Fix meeeeeeeeeeeeeeeeee
            //Error = Error + Rooms.ThisRoom.Validate();
            if (Error == "")
            {
                Users.ThisUser.EMail = txtEmail.Text;
                Users.ThisUser.Password = Users.GetHashPassword(txtEmail.Text);
                Users.ThisUser.FirstName = txtFirstName.Text;
                Users.ThisUser.SecondName = txtLastName.Text;
                Users.ThisUser.Subject = Convert.ToString(ddlSubject.SelectedValue);
                Users.Edit();
                Session["UserID"] = Users.ThisUser.ID;
                return Error;
            }
            else
            {
                lblError.Text = Error;//Display errors
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
            Response.Redirect("ManageTeachers.aspx");
        }
    }
}