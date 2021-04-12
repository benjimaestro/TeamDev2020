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
        //Initialise variables used to identify if it is an admin or not, and the user's ID
        Int32 UserID = -1;
        string Mode = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUserCollection Users = new clsUserCollection();
            UserID = Convert.ToInt32(Session["UserID"]);
            Mode = Convert.ToString(Session["Mode"]);

            //Sets webpage title and send button text
            Users.Find(UserID);
            if (Mode == "Admin") 
            {
                lblTitle.Text = $"Message {Users.ThisUser.FirstName} {Users.ThisUser.LastName}"; 
                btnSend.Text = $"Send to {Users.ThisUser.FirstName} {Users.ThisUser.LastName}";
            }
            else 
            { 
                lblTitle.Text = $"Message Admins";
                btnSend.Text = "Send to Admins";
            }

            //Collects messages, formats them with the name and timestamps and puts them into
            //the txtMessages message box for reading
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
                    Thread = Thread + $"{Users.ThisUser.FirstName} {Users.ThisUser.LastName} ({Messages.Messagelist[Index].Timestamp}): {Messages.Messagelist[Index].Content}"+Environment.NewLine + Environment.NewLine;
                }
                Index++;
            }
            txtMessages.Text = Thread;

        }

        string send()
        {
            //Run when the btnSend is clicked, returns error string
            String Error = "";
            clsMessageCollection Messages = new clsMessageCollection();
            bool ToAdmin = false;

            //Gets the current time and date as a string
            string Timestamp = DateTime.Now.ToString();
            
            if (Mode == "Admin") { ToAdmin = false; }
            else { ToAdmin = true; }

            //Checks if there's validation errors in the message
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
            //Run when the btnSend is clicked
            //If empty string returned by send(), page reloads
            //Otherwise, display the error
            string Error = send();
            if (Error == "")
            {
                Response.Redirect("Contact.aspx");
            }
            else { lblError.Text = Error; }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            //Run when btnBack is clicked, determines where to redirect to based on Mode
            if (Mode == "Admin") { Response.Redirect("ManageTeachers.aspx"); }
            else { Response.Redirect("TeacherDefault.aspx"); }
        }
    }
}