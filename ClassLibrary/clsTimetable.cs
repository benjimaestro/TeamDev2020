﻿using System;
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
        private Int32 mP1;
        private Int32 mP2;
        private Int32 mP3;
        private Int32 mP4;
        private Int32 mP5;
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

        public bool FindByWeekNo(Int32 UserID, Int32 WeekNo)
        {
            //Used for testing only, gets a users timetable and checks to see if it is returned properly
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.AddParameter("@WeekNo", WeekNo);
            DB.Execute("sproc_tblTimetable_FilterByWeekNo");
            if (DB.Count == 5) { return true; }
            else { return false; }
        }

        public bool Find(int ID)
        {
            //Used for testing
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblTimetable_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mP1 = Convert.ToInt32(DB.DataTable.Rows[0]["P1"]);
                mP2 = Convert.ToInt32(DB.DataTable.Rows[0]["P2"]);
                mP3 = Convert.ToInt32(DB.DataTable.Rows[0]["P3"]);
                mP4 = Convert.ToInt32(DB.DataTable.Rows[0]["P4"]);
                mP5 = Convert.ToInt32(DB.DataTable.Rows[0]["P5"]);
                WeekNo = Convert.ToInt32(DB.DataTable.Rows[0]["WeekNo"]);
                DayNo = Convert.ToInt32(DB.DataTable.Rows[0]["DayNo"]);
                return true;
            }
            else { return false; }
        }

        public string Validate(int UserID, int P1, int P2, int P3, int P4, int P5, int WeekNo, int DayNo)
        {
            //Function to validate inputs before they are used - returns error as string
            string Error = "";
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            if (Users.ThisUser.ID == 0) { Error = Error + "User ID does not exist </br>"; }
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.Find(P1);
            if (Rooms.ThisRoom.ID == 0) { Error = Error + "P1 ID does not exist </br>"; }
            Rooms = new clsRoomCollection();
            Rooms.Find(P2);
            if (Rooms.ThisRoom.ID == 0) { Error = Error + "P2 ID does not exist </br>"; }
            Rooms = new clsRoomCollection();
            Rooms.Find(P3);
            if (Rooms.ThisRoom.ID == 0) { Error = Error + "P3 ID does not exist </br>"; }
            Rooms = new clsRoomCollection();
            Rooms.Find(P4);
            if (Rooms.ThisRoom.ID == 0) { Error = Error + "P4 ID does not exist </br>"; }
            Rooms = new clsRoomCollection();
            Rooms.Find(P5);
            if (Rooms.ThisRoom.ID == 0) { Error = Error + "P5 ID does not exist </br>"; }
            
            if (WeekNo < 1 || WeekNo > 5) { Error = Error + "WeekNo must be 1-5 </br>"; }
            if (DayNo < 1 || DayNo > 5) { Error = Error + "DayNo must be 1-5 </br>"; }
            return Error;
        }
    }
}
