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

        public void ResetPassword(string EMail)
        {

        }
    }
}
