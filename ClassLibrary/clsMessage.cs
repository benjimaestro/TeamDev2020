using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMessage
    {
        private Int32 mID;
        private Int32 mUserID;
        private bool mToAdmin;
        private string mContent;
        private string mTimestamp;

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
        public bool ToAdmin
        {
            get { return mToAdmin; }
            set { mToAdmin = value; }
        }
        public string Content
        {
            get { return mContent; }
            set { mContent = value; }
        }
        public string Timestamp
        {
            get { return mTimestamp; }
            set { mTimestamp = value; }
        }

        public string Validate(int UserID, bool ToAdmin, string Content, string Timestamp)
        {
            //Function to validate inputs before they are used - returns error as string
            string Error = "";
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            if (Users.ThisUser.ID == 0) { Error = Error + "User ID does not exist </br>"; }
            if (Content.Length < 1 || Content.Length > 512) { Error = Error + "Message must be 1-512 characters long </br>"; }
            if (Timestamp.Length < 1 || Timestamp.Length > 20) { Error = Error + "Timestamp must be 1-20 characters long </br>"; }
            return Error;
        }
    }
}
