using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsUser
    {
        private Int32 mID;
        private string mEMail;
        private string mPassword;
        private string mFirstName;
        private string mSecondName;
        private Boolean mAdmin;
        private string mSubject;

        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public string EMail
        {
            get { return mEMail; }
            set { mEMail = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string SecondName
        {
            get { return mSecondName; }
            set { mSecondName = value; }
        }
        public bool Admin
        {
            get { return mAdmin; }
            set { mAdmin = value; }
        }
        public string Subject
        {
            get { return mSubject; }
            set { mSubject = value; }
        }
        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblUser_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mEMail = Convert.ToString(DB.DataTable.Rows[0]["EMail"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSecondName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mSubject = Convert.ToString(DB.DataTable.Rows[0]["Subject"]);
                return true;
            }
            else { return false; }
        }
        public string Validate(int ID, string EMail, string FirstName, string SecondName, string Subject)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
