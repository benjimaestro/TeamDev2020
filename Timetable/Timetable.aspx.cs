using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class Timetable : System.Web.UI.Page
    {
        Int32 WeekNo = 1;
        Int32 UserID = -1;
        string Mode = "";
        List<List<Button>> ButtonList = new List<List<Button>>();

        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonList = new List<List<Button>>{
                                                new List<Button> { btn1P1, btn1P2, btn1P3, btn1P4, btn1P5 },
                                                new List<Button> { btn2P1, btn2P2, btn2P3, btn2P4, btn2P5 },
                                                new List<Button> { btn3P1, btn3P2, btn3P3, btn3P4, btn3P5 },
                                                new List<Button> { btn4P1, btn4P2, btn4P3, btn4P4, btn4P5 },
                                                new List<Button> { btn5P1, btn5P2, btn5P3, btn5P4, btn5P5 },
                                                };
            UserID = Convert.ToInt32(Session["UserID"]);
            Mode = Convert.ToString(Session["Mode"]);
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            lblTitle.Text = $"{Users.ThisUser.FirstName} {Users.ThisUser.SecondName}'s Timetable";
            if (IsPostBack == false)
            {
                DisplayTimetable(UserID, WeekNo);
            }
        }
        void DisplayTimetable(Int32 UserID ,Int32 WeekNo)
        {
            clsTimetableCollection Timetables = new clsTimetableCollection();
            Timetables.FilterByWeekNo(UserID, WeekNo);
            Int32 IndexDay = 0;
            while (IndexDay <= 4)
            {
                ButtonList[IndexDay][0].Text = Convert.ToString(Timetables.Timetablelist[IndexDay].P1);
                ButtonList[IndexDay][1].Text = Convert.ToString(Timetables.Timetablelist[IndexDay].P2);
                ButtonList[IndexDay][2].Text = Convert.ToString(Timetables.Timetablelist[IndexDay].P3);
                ButtonList[IndexDay][3].Text = Convert.ToString(Timetables.Timetablelist[IndexDay].P4);
                ButtonList[IndexDay][4].Text = Convert.ToString(Timetables.Timetablelist[IndexDay].P5);
                IndexDay++;
            }
        }
    }
}