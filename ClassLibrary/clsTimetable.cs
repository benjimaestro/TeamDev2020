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
        private Int32 mDay;
        private Int32 mP1;
        private Int32 mP2;
        private Int32 mP3;
        private Int32 mP4;
        private Int32 mP5;
        private Int32 mWeekNo;

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
        public int Day
        {
            get { return mDay; }
            set { mDay = value; }
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


        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblTimetable_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["Number"]);
                mDay = Convert.ToInt32(DB.DataTable.Rows[0]["Block"]);
                mP1 = Convert.ToInt32(DB.DataTable.Rows[0]["P1"]);
                mP2 = Convert.ToInt32(DB.DataTable.Rows[0]["P2"]);
                mP3 = Convert.ToInt32(DB.DataTable.Rows[0]["P3"]);
                mP4 = Convert.ToInt32(DB.DataTable.Rows[0]["P4"]);
                mP5 = Convert.ToInt32(DB.DataTable.Rows[0]["P5"]);
                mWeekNo = Convert.ToInt32(DB.DataTable.Rows[0]["WeekNo"]);
                return true;
            }
            else { return false; }
        }
        public string Validate(int ID, int UserID, int Day, int P1, int P2, int P3, int P4, int P5, int WeekNo)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
