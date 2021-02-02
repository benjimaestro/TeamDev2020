using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class Contact : System.Web.UI.Page
    {
        Int32 UserID = -1;
        string Mode = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUserCollection Users = new clsUserCollection();
            UserID = Convert.ToInt32(Session["UserID"]);
            Mode = Convert.ToString(Session["Mode"]);
            Users.Find(UserID);
            if (Mode == "Admin") 
            {
                lblTitle.Text = $"Message {Users.ThisUser.FirstName} {Users.ThisUser.SecondName}"; 
                btnSend.Text = $"Send to {Users.ThisUser.FirstName} {Users.ThisUser.SecondName}";
            }
            else 
            { 
                lblTitle.Text = $"Message Admins";
                btnSend.Text = "Send to Admins";
            }

            clsMessageCollection Messages = new clsMessageCollection();
            Messages.FilterByUserID(UserID);
            Int32 Index = 0;
            string Thread = "";
            while (Index < Messages.Count)
            {
                if (Messages.Messagelist[Index].ToAdmin == false)
                {
                    Thread = Thread + $"Admin ({Messages.Messagelist[Index].Timestamp}): {Messages.Messagelist[Index].Content}"+Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    Thread = Thread + $"{Users.ThisUser.FirstName} {Users.ThisUser.SecondName} ({Messages.Messagelist[Index].Timestamp}): {Messages.Messagelist[Index].Content}"+Environment.NewLine + Environment.NewLine;
                }
                Index++;
            }
            txtMessages.Text = Thread;

        }

        string send()
        {
            String Error = "";
            clsMessageCollection Messages = new clsMessageCollection();
            bool ToAdmin = false;
            string Timestamp = DateTime.Now.ToString();
            if (Mode == "Admin") { ToAdmin = false; }
            else { ToAdmin = true; }

            Error = Error + Messages.ThisMessage.Validate(Convert.ToInt32(Session["UserID"]), ToAdmin, txtSendMessage.Text, Timestamp);
            if (Error == "")
            {
                Messages.ThisMessage.UserID = Convert.ToInt32(Session["UserID"]);
                Messages.ThisMessage.Content = txtSendMessage.Text;
                Messages.ThisMessage.ToAdmin = ToAdmin;
                Messages.ThisMessage.Timestamp = Timestamp;
                Messages.Add();
                return Error;
            }
            else
            {
                lblError.Text = Error;
                return Error;
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string Error = send();
            if (Error == "")
            {
                Response.Redirect("Contact.aspx");
            }
            else { lblError.Text = Error; }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            if (Mode == "Admin") { Response.Redirect("ManageTeachers.aspx"); }
            else { Response.Redirect("TeacherDefault.aspx"); }
        }
    }
}