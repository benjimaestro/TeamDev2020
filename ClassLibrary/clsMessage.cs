using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsMessage
    {
        private Int32 mID;
        private Int32 mFromID;
        private Int32 mToID;
        private string mContent;
        private DateTime mTimestamp;

        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public int FromID
        {
            get { return mFromID; }
            set { mFromID = value; }
        }
        public int ToID
        {
            get { return mToID; }
            set { mToID = value; }
        }
        public string Content
        {
            get { return mContent; }
            set { mContent = value; }
        }
        public DateTime Timestamp
        {
            get { return mTimestamp; }
            set { mTimestamp = value; }
        }
        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblUser_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mFromID = Convert.ToInt32(DB.DataTable.Rows[0]["FromID"]);
                mToID = Convert.ToInt32(DB.DataTable.Rows[0]["ToID"]);
                mContent = Convert.ToString(DB.DataTable.Rows[0]["Content"]);
                mTimestamp = Convert.ToDateTime(DB.DataTable.Rows[0]["Timestamp"]);
                return true;
            }
            else { return false; }
        }
        public string Validate(int ID, int FromID, int ToID, int Content, DateTime Timestamp)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
