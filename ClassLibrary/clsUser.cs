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
            //FINISH MEEEEEEEEEEEEEEE
            return true;
        }
        public string Validate(int ID, string EMail, string FirstName, string SecondName, string Subject)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
