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
        //Initialze useful variables
        Int32 WeekNo = -1;
        Int32 UserID = -1;
        Int32 SelectedDayNo = -1;
        Int32 SelectedPNo = -1;
        string Mode = "";

        //2D list of all the buttons on the page so they can be looped through by day and by period
        List<List<Button>> ButtonList = new List<List<Button>>();

        //List of days, used for displaying info
        List<string> Days = new List<string> { "Monday","Tuesday","Wednesday","Thursday","Friday" };

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set up ButtonList with all the buttons on page
            ButtonList = new List<List<Button>>{new List<Button> { btn1P1, btn1P2, btn1P3, btn1P4, btn1P5 },
                                                new List<Button> { btn2P1, btn2P2, btn2P3, btn2P4, btn2P5 },
                                                new List<Button> { btn3P1, btn3P2, btn3P3, btn3P4, btn3P5 },
                                                new List<Button> { btn4P1, btn4P2, btn4P3, btn4P4, btn4P5 },
                                                new List<Button> { btn5P1, btn5P2, btn5P3, btn5P4, btn5P5 }};

            //Set up other useful variables
            WeekNo = Convert.ToInt32(Session["WeekNo"]);
            UserID = Convert.ToInt32(Session["UserID"]);
            Mode = Convert.ToString(Session["Mode"]);

            //Set title of page to indicate who's timetable it is
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            lblTitle.Text = $"{Users.ThisUser.FirstName} {Users.ThisUser.SecondName}'s Timetable";
            DisplayTimetable(UserID, WeekNo);

            //Disables buttons if user has reached the end or beginning of timetable
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
            //Sets button text depending on room or lack of room
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
            //Function to loop through days and periods and set button names accordingly
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
            //Lowers the weekNo counter by 1, refreshes page
            //This will display the user's timetable for the previous week
            WeekNo--;
            Session["WeekNo"] = WeekNo;
            Response.Redirect("Timetable.aspx");
        }

        protected void btnNextWeek_Click(object sender, EventArgs e)
        {
            //Increments the weekNo counter by 1, refreshes page
            //This will display the user's timetable for the next week
            WeekNo++;
            Session["WeekNo"] = WeekNo;
            Response.Redirect("Timetable.aspx");
        }

        protected void TimetableButton_Click(object sender, EventArgs e)
        {
            //This is run when any one of the period cell buttons are clicked
            Int32 IndexDay = 0;
            Int32 IndexPeriod = 0;

            //Clear any border styling
            while (IndexDay < 5)
            {
                IndexPeriod = 0;
                while (IndexPeriod < 5)
                {
                    ButtonList[IndexDay][IndexPeriod].BorderColor = System.Drawing.Color.Empty;
                    IndexPeriod++;
                }
                IndexDay++;
            }

            //Set button styling to have red border so user knows which is selected
            Button Button = (Button)sender;
            Button.BorderColor = System.Drawing.Color.Red;
            SelectedDayNo = Convert.ToInt32(Button.ID.Substring(3, 1));
            SelectedPNo = Convert.ToInt32(Button.ID.Substring(5, 1));

            //Get the subject for the current user
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            string Subject = Users.ThisUser.Subject;

            //Check if the room is booked on that period 
            clsRoomCollection Rooms = new clsRoomCollection();
            clsTimetableCollection Timetables = new clsTimetableCollection();
            List<Int32> BookedRoomIDs = Timetables.CheckRoomBooked(SelectedPNo, SelectedDayNo, WeekNo);
            Int32 x = Rooms.Count;
            //Remove booked rooms from the list of rooms
            Rooms.RemoveRooms(BookedRoomIDs, Subject);
            x = Rooms.Count;

            //Add valid rooms to ddlRooms
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
            //Function run when the selected room in the room dropdown changes
            if (ddlRooms.SelectedValue != "Select a room...")
            {
                //Get selected room number and block
                clsRoomCollection Rooms = new clsRoomCollection();
                string Block = ddlRooms.SelectedValue.Substring(0, 1);
                Int32 Number = Convert.ToInt32(ddlRooms.SelectedValue.Substring(2, ddlRooms.SelectedValue.Length-2));

                //Finds room from block and number
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

                //Change selected period to be the selected room
                Timetables.EditDay(Timetable);
                Response.Redirect("Timetable.aspx");
            }
        }

        protected void btnUnbook_Click(object sender, EventArgs e)
        {
            //When clicked, sets period to be free (no room selected on that day)
            SelectedDayNo = Convert.ToInt32(Session["DayNo"]);
            SelectedPNo = Convert.ToInt32(Session["Period"]);

            clsTimetableCollection Timetables = new clsTimetableCollection();
            clsTimetable Timetable = Timetables.FilterByUserDayWeek(UserID, SelectedDayNo, WeekNo);
            if (SelectedPNo == 1) { Timetable.P1 = 0; }
            if (SelectedPNo == 2) { Timetable.P2 = 0; }
            if (SelectedPNo == 3) { Timetable.P3 = 0; }
            if (SelectedPNo == 4) { Timetable.P4 = 0; }
            if (SelectedPNo == 5) { Timetable.P5 = 0; }

            //Edits DB record to be room ID of 0
            Timetables.EditDay(Timetable);
            Response.Redirect("Timetable.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            //Redirects back to page based on Mode
            if (Mode == "Admin") { Response.Redirect("ManageTeachers.aspx"); }
            else { Response.Redirect("TeacherDefault.aspx"); }
        }
    }
}