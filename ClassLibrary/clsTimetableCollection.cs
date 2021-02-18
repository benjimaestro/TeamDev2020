using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsTimetableCollection
    {
        List<clsTimetable> mTimetableList = new List<clsTimetable>();
        clsTimetable mThisTimetable = new clsTimetable();

        public List<clsTimetable> Timetablelist
        {
            get { return mTimetableList; }
            set { mTimetableList = value; }
        }

        public int Count
        {
            get { return mTimetableList.Count; }
        }

        public clsTimetable ThisTimetable
        {
            get { return mThisTimetable; }
            set { mThisTimetable = value; }
        }

        public clsTimetableCollection()
        {
        }

        void PopulateList(clsDataConnection DB)
        {
            //Populates the mTimetableList by looping through rows in the provided table
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mTimetableList = new List<clsTimetable>();
            while (Index < RecordCount)
            {
                clsTimetable Timetable = new clsTimetable();
                Timetable.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Timetable.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                Timetable.P1 = Convert.ToInt32(DB.DataTable.Rows[Index]["P1"]);
                Timetable.P2 = Convert.ToInt32(DB.DataTable.Rows[Index]["P2"]);
                Timetable.P3 = Convert.ToInt32(DB.DataTable.Rows[Index]["P3"]);
                Timetable.P4 = Convert.ToInt32(DB.DataTable.Rows[Index]["P4"]);
                Timetable.P5 = Convert.ToInt32(DB.DataTable.Rows[Index]["P5"]);
                Timetable.WeekNo = Convert.ToInt32(DB.DataTable.Rows[Index]["WeekNo"]);
                Timetable.DayNo = Convert.ToInt32(DB.DataTable.Rows[Index]["DayNo"]);

                mTimetableList.Add(Timetable);

                Index++;
            }
        }
        public void GenerateTimetable(Int32 UserID)
        {
            //Generates rows in tblTimetable for when a new user is made
            Int32 IndexDay = 1;
            Int32 IndexWeek = 1;
            while (IndexWeek <= 5)
            {
                while (IndexDay <= 5)
                {
                    clsDataConnection DB = new clsDataConnection();
                    DB.AddParameter("@UserID", UserID);
                    DB.AddParameter("@WeekNo", IndexWeek);
                    DB.AddParameter("@DayNo", IndexDay);
                    DB.Execute("sproc_tblTimetable_GenerateTimetable");
                    IndexDay++;
                }
                IndexWeek++;
                IndexDay = 1;
            }
        }
        public void DeleteTimetable(Int32 UserID)
        {
            //Deletes the generated rows in tblTimetable for when a user is deleted
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.Execute("sproc_tblTimetable_DeleteTimetable");
        }
        public void FilterByWeekNo(Int32 UserID, Int32 WeekNo)
        {
            //Gets a week's worth of timetable rows for the provided user and provided week
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.AddParameter("@WeekNo", WeekNo);
            DB.Execute("sproc_tblTimetable_FilterByWeekNo");
            PopulateList(DB);
        }

        public clsTimetable FilterByUserDayWeek(Int32 UserID, Int32 DayNo, Int32 WeekNo)
        {
            //Gets a day's worth of timetable rows for the provided user and provided week and provided day
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.AddParameter("@DayNo", DayNo);
            DB.AddParameter("@WeekNo", WeekNo);
            DB.Execute("sproc_tblTimetable_FilterByUserIDAndDayAndWeek");
            PopulateList(DB);

            clsTimetable Timetable = new clsTimetable();
            Timetable.ID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
            Timetable.UserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
            Timetable.P1 = Convert.ToInt32(DB.DataTable.Rows[0]["P1"]);
            Timetable.P2 = Convert.ToInt32(DB.DataTable.Rows[0]["P2"]);
            Timetable.P3 = Convert.ToInt32(DB.DataTable.Rows[0]["P3"]);
            Timetable.P4 = Convert.ToInt32(DB.DataTable.Rows[0]["P4"]);
            Timetable.P5 = Convert.ToInt32(DB.DataTable.Rows[0]["P5"]);
            Timetable.WeekNo = Convert.ToInt32(DB.DataTable.Rows[0]["WeekNo"]);
            Timetable.DayNo = Convert.ToInt32(DB.DataTable.Rows[0]["DayNo"]);
            return Timetable;
        }

        public List<Int32> CheckRoomBooked(Int32 Period, Int32 DayNo, Int32 WeekNo)
        {
            //Gets a day's worth of timetables from all users
            //This is used to check if a room is already booked in a specific period
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DayNo", DayNo);
            DB.AddParameter("@WeekNo", WeekNo);
            DB.Execute("sproc_tblTimetable_FilterByDayAndWeek");

            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            List<Int32> BookedRoomIDs = new List<Int32>();
            while (Index < RecordCount)
            {
                if (Period == 1) { BookedRoomIDs.Add(Convert.ToInt32(DB.DataTable.Rows[Index]["P1"])); }
                if (Period == 2) { BookedRoomIDs.Add(Convert.ToInt32(DB.DataTable.Rows[Index]["P2"])); }
                if (Period == 3) { BookedRoomIDs.Add(Convert.ToInt32(DB.DataTable.Rows[Index]["P3"])); }
                if (Period == 4) { BookedRoomIDs.Add(Convert.ToInt32(DB.DataTable.Rows[Index]["P4"])); }
                if (Period == 5) { BookedRoomIDs.Add(Convert.ToInt32(DB.DataTable.Rows[Index]["P5"])); }

                Index++;
            }
            return BookedRoomIDs;
        }

        public int EditDay(clsTimetable Timetable)
        {
            //Function to edit an existing record/day in tblTimetable with new details
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", Timetable.ID);
            DB.AddParameter("@P1", Timetable.P1);
            DB.AddParameter("@P2", Timetable.P2);
            DB.AddParameter("@P3", Timetable.P3);
            DB.AddParameter("@P4", Timetable.P4);
            DB.AddParameter("@P5", Timetable.P5);
            return DB.Execute("sproc_tblTimetable_ChangeRoomBooking");
        }

        public int DeleteRoomFromTimetable(int RoomID)
        {
            //Function to delete references to a deleted room from all timetables
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@RoomID", RoomID);
            return DB.Execute("sproc_tblTimetable_UpdateAll");
        }
    }
}
