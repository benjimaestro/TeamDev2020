using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsTimetable
    {
        private Int32 mID;
        private Int32 mUserID;
        private int mP1;
        private int mP2;
        private int mP3;
        private int mP4;
        private int mP5;
        private Int32 mWeekNo;
        private Int32 mDayNo;

        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }
        public int P1
        {
            get { return mP1; }
            set { mP1 = value; }
        }
        public int P2
        {
            get { return mP2; }
            set { mP2 = value; }
        }
        public int P3
        {
            get { return mP3; }
            set { mP3 = value; }
        }
        public int P4
        {
            get { return mP4; }
            set { mP4 = value; }
        }
        public int P5
        {
            get { return mP5; }
            set { mP5 = value; }
        }
        public int WeekNo
        {
            get { return mWeekNo; }
            set { mWeekNo = value; }
        }
        public int DayNo
        {
            get { return mDayNo; }
            set { mDayNo = value; }
        }

        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblTimetable_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                try { mP1 = Convert.ToInt32(DB.DataTable.Rows[0]["P1"]); }
                catch { mP1 = 0; }
                try { mP2 = Convert.ToInt32(DB.DataTable.Rows[0]["P2"]); }
                catch { mP2 = 0; }
                try { mP3 = Convert.ToInt32(DB.DataTable.Rows[0]["P3"]); }
                catch { mP3 = 0; }
                try { mP4 = Convert.ToInt32(DB.DataTable.Rows[0]["P4"]); }
                catch { mP4 = 0; }
                try { mP5 = Convert.ToInt32(DB.DataTable.Rows[0]["P5"]); }
                catch { mP5 = 0; }
                mWeekNo = Convert.ToInt32(DB.DataTable.Rows[0]["WeekNo"]);
                mDayNo = Convert.ToInt32(DB.DataTable.Rows[0]["DayNo"]);
                return true;
            }
            else { return false; }
        }
        public string Validate(int ID, int UserID, int P1, int P2, int P3, int P4, int P5, int WeekNo, int DayNo)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
