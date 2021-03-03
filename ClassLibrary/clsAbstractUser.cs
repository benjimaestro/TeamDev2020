using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public abstract class clsAbstractUser
    {
        protected Int32 mID;
        protected string mEmail;
        protected string mFirstName;
        protected string mLastName;
        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }
        public string FullName
        {
            get { return $"{mFirstName} {mLastName}"; }
        }

        public string ChangePassword(Int32 TimetableFound, Int32 TTrainFound, Int32 LaptopFound, string Password)
        {
            clsDataConnection DB = new clsDataConnection();
            string Info = "Password changed on:</br>";
            if (TimetableFound == 1)
            {
                DB.AddParameter("@Password", Password);
                DB.Execute("sproc_tblTimetable_ChangePassword");
                Info = Info + "Teacher Timetable</br>";
            }
            //if (TTrainFound == 1)
            //{
            //    DB.AddParameter("@Password", Password);
            //    DB.Execute("sproc_tblCustomer_ChangePassword");
            //    Info = Info + "T-Train System</br>";
            //}

            //if (LaptopFound == 1)
            //{
            //    DB.AddParameter("@Password", Password);
            //    DB.Execute("");
            //    Info = Info + "Laptop System</br>";
            //}

            return Info;
        }

        public void FindEMail(string EMail)
        {
            int TimetableFound = 0;
            int TTrainFound = 0;
            int LaptopFound = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EMail", EMail);
            TimetableFound = DB.Execute("sproc_tblUser_EMailExists");
           
            //Needs stored procedure for tblCustomer to work
            //DB = new clsDataConnection();
            //DB.AddParameter("@EMail", EMail);
            //TTrainFound = DB.Execute("sproc_tblUser_EMailExists");

            //Needs stored procedure for laptop user table to work
            //DB = new clsDataConnection();
            //DB.AddParameter("@EMail", EMail);
            //TTrainFound = DB.Execute("");
        }
    }
}
