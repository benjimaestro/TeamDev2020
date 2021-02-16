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
        Int32 WeekNo = -1;
        Int32 UserID = -1;
        Int32 SelectedDayNo = -1;
        Int32 SelectedPNo = -1;
        string Mode = "";
        List<List<Button>> ButtonList = new List<List<Button>>();
        List<string> Days = new List<string> { "Monday","Tuesday","Wednesday","Thursday","Friday" };

        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonList = new List<List<Button>>{
                                                new List<Button> { btn1P1, btn1P2, btn1P3, btn1P4, btn1P5 },
                                                new List<Button> { btn2P1, btn2P2, btn2P3, btn2P4, btn2P5 },
                                                new List<Button> { btn3P1, btn3P2, btn3P3, btn3P4, btn3P5 },
                                                new List<Button> { btn4P1, btn4P2, btn4P3, btn4P4, btn4P5 },
                                                new List<Button> { btn5P1, btn5P2, btn5P3, btn5P4, btn5P5 },
                                                };
            WeekNo = Convert.ToInt32(Session["WeekNo"]);
            UserID = Convert.ToInt32(Session["UserID"]);
            Mode = Convert.ToString(Session["Mode"]);
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            lblTitle.Text = $"{Users.ThisUser.FirstName} {Users.ThisUser.SecondName}'s Timetable";
            DisplayTimetable(UserID, WeekNo);
            if (WeekNo == 1) 
            { 
                btnPrevWeek.Enabled = false;
                btnNextWeek.Enabled = true;
            }
            if (WeekNo == 5) 
            { 
                btnNextWeek.Enabled = false;
                btnPrevWeek.Enabled = true;
            }
            lblWeekNo.Text = $"Week {WeekNo.ToString()}/5";
            ddlRooms.Enabled = false;
            btnUnbook.Enabled = false;
        }
        void IDToRoom(int ID, Button button)
        {
            if (ID == 0) 
            {
                button.Text = "Free";
                if (Mode != "Admin") { button.Enabled = false; }
            }
            else 
            {
                clsRoomCollection Rooms = new clsRoomCollection();
                Rooms.Find(ID);
                button.Text = Rooms.ThisRoom.RoomName;
                button.Enabled = true;
            }
        }

        void DisplayTimetable(Int32 UserID ,Int32 WeekNo)
        {
            clsTimetableCollection Timetables = new clsTimetableCollection();
            Timetables.FilterByWeekNo(UserID, WeekNo);
            Int32 IndexDay = 0;
            while (IndexDay <= 4)
            {
                IDToRoom(Timetables.Timetablelist[IndexDay].P1, ButtonList[IndexDay][0]);
                IDToRoom(Timetables.Timetablelist[IndexDay].P2, ButtonList[IndexDay][1]);
                IDToRoom(Timetables.Timetablelist[IndexDay].P3, ButtonList[IndexDay][2]);
                IDToRoom(Timetables.Timetablelist[IndexDay].P4, ButtonList[IndexDay][3]);
                IDToRoom(Timetables.Timetablelist[IndexDay].P5, ButtonList[IndexDay][4]);
                IndexDay++;
            }
        }

        protected void btnPrevWeek_Click(object sender, EventArgs e)
        {
            WeekNo--;
            Session["WeekNo"] = WeekNo;
            Response.Redirect("Timetable.aspx");
        }

        protected void btnNextWeek_Click(object sender, EventArgs e)
        {
            WeekNo++;
            Session["WeekNo"] = WeekNo;
            Response.Redirect("Timetable.aspx");
        }

        protected void TimetableButton_Click(object sender, EventArgs e)
        {
            Button Button = (Button)sender;
            SelectedDayNo = Convert.ToInt32(Button.ID.Substring(3, 1));
            SelectedPNo = Convert.ToInt32(Button.ID.Substring(5, 1));

            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            string Subject = Users.ThisUser.Subject;

            clsRoomCollection Rooms = new clsRoomCollection();

            clsTimetableCollection Timetables = new clsTimetableCollection();
            List<Int32> BookedRoomIDs = Timetables.CheckRoomBooked(SelectedPNo, SelectedDayNo, WeekNo);
            Int32 x = Rooms.Count;
            Rooms.RemoveRooms(BookedRoomIDs, Subject);
            x = Rooms.Count;

            Int32 Index = 0;
            ddlRooms.Items.Clear();
            ddlRooms.Items.Add("Select a room...");
            while (Index < Rooms.Roomlist.Count)
            {
                ddlRooms.Items.Add(Rooms.Roomlist[Index].RoomName);
                Index++;
            }

            ddlRooms.Enabled = true;
            if (Mode == "Admin") { btnUnbook.Enabled = true; }
            lblRooms.Text = $"Rooms available on {Days[SelectedDayNo-1]} period {SelectedPNo}";
            Session["DayNo"] = SelectedDayNo;
            Session["Period"] = SelectedPNo;
        }

        protected void ddlRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRooms.SelectedValue != "Select a room...")
            {
                clsRoomCollection Rooms = new clsRoomCollection();
                string Block = ddlRooms.SelectedValue.Substring(0, 1);
                Int32 Number = Convert.ToInt32(ddlRooms.SelectedValue.Substring(2, 1));
                Rooms.FindExistingRoom(Block, Number);

                SelectedDayNo = Convert.ToInt32(Session["DayNo"]);
                SelectedPNo = Convert.ToInt32(Session["Period"]);

                clsTimetableCollection Timetables = new clsTimetableCollection();
                clsTimetable Timetable = Timetables.FilterByUserDayWeek(UserID, SelectedDayNo, WeekNo);
                if (SelectedPNo == 1) { Timetable.P1 = Rooms.ThisRoom.ID; }
                if (SelectedPNo == 2) { Timetable.P2 = Rooms.ThisRoom.ID; }
                if (SelectedPNo == 3) { Timetable.P3 = Rooms.ThisRoom.ID; }
                if (SelectedPNo == 4) { Timetable.P4 = Rooms.ThisRoom.ID; }
                if (SelectedPNo == 5) { Timetable.P5 = Rooms.ThisRoom.ID; }
                Timetables.EditDay(Timetable);
                Response.Redirect("Timetable.aspx");
            }
        }

        protected void btnUnbook_Click(object sender, EventArgs e)
        {
            SelectedDayNo = Convert.ToInt32(Session["DayNo"]);
            SelectedPNo = Convert.ToInt32(Session["Period"]);

            clsTimetableCollection Timetables = new clsTimetableCollection();
            clsTimetable Timetable = Timetables.FilterByUserDayWeek(UserID, SelectedDayNo, WeekNo);
            if (SelectedPNo == 1) { Timetable.P1 = 0; }
            if (SelectedPNo == 2) { Timetable.P2 = 0; }
            if (SelectedPNo == 3) { Timetable.P3 = 0; }
            if (SelectedPNo == 4) { Timetable.P4 = 0; }
            if (SelectedPNo == 5) { Timetable.P5 = 0; }
            Timetables.EditDay(Timetable);
            Response.Redirect("Timetable.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            if (Mode == "Admin") { Response.Redirect("ManageTeachers.aspx"); }
            else { Response.Redirect("TeacherDefault.aspx"); }
        }
    }
}