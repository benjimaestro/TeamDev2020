using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsUser : clsAbstractUser
    {
        private string mPassword;
        private Boolean mAdmin;
        private string mSubject;

        public string EMail
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string SecondName
        {
            get { return mLastName; }
            set { mLastName = value; }
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
        public string FullNameEmail
        {
            get { return $"{mFirstName} {mLastName} ({mEmail})"; }
        }
        public bool Find(int ID)
        {
            //Used for testing purposes only for testing database connection and lookups
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblUser_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["EMail"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mSubject = Convert.ToString(DB.DataTable.Rows[0]["Subject"]);
                return true;
            }
            else { return false; }
        }
        public string Validate(string EMail, string FirstName, string SecondName, string Password, string Subject)
        {
            //Function to validate inputs before they are used - returns error as string
            string Error = "";
            try
            {
                var addr = new System.Net.Mail.MailAddress(EMail);
            }
            catch
            {
                Error = Error + "Invalid EMail format</br>";
            }
            Regex PasswordRegex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{4,50}$");
            
            if (EMail.Length > 50 || EMail.Length < 6) { Error = Error + "EMail must be 6-50 characters</br>"; }
            if (FirstName.Length > 50 || FirstName.Length < 1) { Error = Error + "First name must be 1-50 characters</br>"; }
            if (SecondName.Length > 50 || SecondName.Length < 1) { Error = Error + "Last name must be 1-50 characters</br>"; }
            if (Password.Length == 0) { Error = Error + "Password cannot be blank</br>"; }
            if (PasswordRegex.IsMatch(Password) == false) { Error = Error + "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>"; }
            if (Password.Length > 50) { Error = Error + "Password must be 50 characters or under</br>"; }
            if (Subject.Length > 10 || Subject.Length < 1) { Error = Error + "Subject must be 1-10 characters</br>"; }
            return Error;
        }
    }
}
