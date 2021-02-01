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
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mTimetableList = new List<clsTimetable>();
            while (Index < RecordCount)
            {
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

                mTimetableList.Add(Timetable);

                Index++;
            }
        }
        public void GenerateTimetable(Int32 UserID)
        {
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.Execute("sproc_tblTimetable_DeleteTimetable");
        }
        public void FilterByWeekNo(Int32 UserID, Int32 WeekNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.AddParameter("@WeekNo", WeekNo);
            DB.Execute("sproc_tblTimetable_FilterByWeekNo");
            PopulateList(DB);
        }

        public void EditDay()
        {
            //Function to edit an existing record in tblTimetable with new details
        }

        public void FilterByID()
        {
            //Finish!!!
        }
        public void FilterByRoomBooked()
        {
            //Finish!!!
        }
    }
}
