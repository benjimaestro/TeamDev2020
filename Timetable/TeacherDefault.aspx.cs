using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class TeacherDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 UserID = Convert.ToInt32(Session["UserID"]);
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            lblTitle.Text = $"Hello, {Users.ThisUser.FirstName} {Users.ThisUser.SecondName}";
        }
    }
}