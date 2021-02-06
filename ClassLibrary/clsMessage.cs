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

        public bool Find(int ID)
        {
            //Used for testing purposes
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblMessage_FilterMessageByMessageID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                ToAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["ToAdmin"]);
                mContent = Convert.ToString(DB.DataTable.Rows[0]["Content"]);
                mTimestamp = Convert.ToString(DB.DataTable.Rows[0]["Timestamp"]);
                return true;
            }
            else { return false; }
        }

        public string Validate(int UserID, bool ToAdmin, string Content, string Timestamp)
        {
            //Function to validate inputs before they are used - returns error as string
            string Error = "";
            clsUserCollection Users = new clsUserCollection();
            Users.Find(UserID);
            if (Users.ThisUser.ID == 0) { Error = Error + "User ID does not exist </br>"; }
            if (Content.Length < 1 || Content.Length > 512) { Error = Error + "Message must be 1-512 characters long </br>"; }
            if (Timestamp.Length != 19) { Error = Error + "Timestamp must be 19 characters long </br>"; }
            return Error;
        }
    }
}
