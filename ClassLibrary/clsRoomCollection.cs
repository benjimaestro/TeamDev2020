using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsRoomCollection
    {
        List<clsRoom> mRoomList = new List<clsRoom>();
        clsRoom mThisRoom = new clsRoom();

        public List<clsRoom> Roomlist
        {
            get { return mRoomList; }
            set { mRoomList = value; }
        }

        public int Count
        {
            get { return mRoomList.Count; }
        }

        public clsRoom ThisRoom
        {
            get { return mThisRoom; }
            set { mThisRoom = value; }
        }

        public clsRoomCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRoom_SelectAll");
            PopulateList(DB);
        }

        public void Find(Int32 Id)
        {
            Int32 Index = 0;
            while (mRoomList.Count > Index)
            {
                if (mRoomList[Index].ID == Id)
                {
                    ThisRoom = mRoomList[Index];
                }
                Index++;
            }
        }

        void PopulateList(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mRoomList = new List<clsRoom>();
            while (Index < RecordCount)
            {
                clsRoom Room = new clsRoom();
                Room.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Room.Subject = Convert.ToString(DB.DataTable.Rows[Index]["Subject"]);
                Room.Number = Convert.ToInt32(DB.DataTable.Rows[Index]["Number"]);
                Room.Block = Convert.ToString(DB.DataTable.Rows[Index]["Block"]);

                mRoomList.Add(Room);

                Index++;
            }
        }

        public int Add()
        {
            //Finish MEEEEEEEEE
            return 0;
        }

        public void Delete(Int32 Id)
        {
            //Function to delete an instance of a Room from the mRoomList and DB based on provided ID
            clsDataConnection DB = new clsDataConnection();
            Int32 Index = 0;
            while (mRoomList.Count > Index)
            {
                if (mRoomList[Index].ID == Id)
                {
                    mRoomList.RemoveAt(Index);
                }
                Index++;
            }

            DB.AddParameter("@Id", Id);
            DB.Execute("sproc_tblRoom_DeleteRoom");
        }

        public void Edit()
        {
            //Function to edit an existing record in tblRoom with new details
        }

        public void FilterBySubject()
        {
            //Finish!!!
        }
    }
}
