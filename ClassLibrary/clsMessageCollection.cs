using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMessageCollection
    {
        List<clsMessage> mMessageList = new List<clsMessage>();
        clsMessage mThisMessage = new clsMessage();

        public List<clsMessage> Messagelist
        {
            get { return mMessageList; }
            set { mMessageList = value; }
        }

        public int Count
        {
            get { return mMessageList.Count; }
        }

        public clsMessage ThisMessage
        {
            get { return mThisMessage; }
            set { mThisMessage = value; }
        }

        public clsMessageCollection()
        {
        }

        void PopulateList(clsDataConnection DB)
        {
            //Populates the mMessageList list by looping through rows in tblMessage or output of stored procedure
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mMessageList = new List<clsMessage>();
            while (Index < RecordCount)
            {
                clsMessage Message = new clsMessage();
                Message.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Message.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                Message.ToAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["ToAdmin"]);
                Message.Content = Convert.ToString(DB.DataTable.Rows[Index]["Content"]);
                Message.Timestamp = Convert.ToString(DB.DataTable.Rows[Index]["Timestamp"]);

                mMessageList.Add(Message);

                Index++;
            }
        }

        public void FilterByUserID(Int32 UserID)
        {
            //Gets output of stored procedure to pass to PopulateList() 
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("UserID", UserID);
            DB.Execute("sproc_tblMessage_FilterMessageByID");
            PopulateList(DB);
        }

        public int Add()
        {
            //Function to add new record to tblMessage
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", mThisMessage.UserID);
            DB.AddParameter("@ToAdmin", mThisMessage.ToAdmin);
            DB.AddParameter("@Content", mThisMessage.Content);
            DB.AddParameter("@Timestamp", mThisMessage.Timestamp);
            return DB.Execute("sproc_tblMessage_AddMessage");
        }
    }
}
