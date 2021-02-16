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
        //List of blocks that rooms can be in
        List<string> Blocks = new List<string>() { "A","B","C","D","E" };
        //List of subjects rooms can be assigned to
        List<string> Subjects = new List<string>() { "English", "Maths", "Sciences", "Languages", "I.T.", "D.T.","Any" };

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

        public List<string> AvailableBlocks
        {
            get { return Blocks; }
        }

        public List<string> AvailableSubjects
        {
            get { return Subjects; }
        }

        public clsRoomCollection()
        {
            //Runs on class initialisation, populates list with all rooms
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRoom_SelectAll");
            PopulateList(DB);
        }

        public void Find(Int32 Id)
        {
            //Loops through mRoomList until it finds a value with the provided ID, then sets the currently selected room to whatever was found
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
            //Populates the mRoomList list by looping through rows in tblRoom
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
            //Function to add new record to tblRoom
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Number", mThisRoom.Number);
            DB.AddParameter("@Block", mThisRoom.Block);
            DB.AddParameter("@Subject", mThisRoom.Subject);
            return DB.Execute("sproc_tblRoom_AddRoom");
        }

        public void Delete(Int32 Id)
        {
            //Function to delete record from tblRoom based on ID
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
        public void FindExistingRoom(string Block, Int32 Number)
        {
            //Sets the ThisRoom to whatever is found with the same room number and block, indicating that a room already exists
            Int32 Index = 0;
            while (mRoomList.Count > Index)
            {
                if (mRoomList[Index].Number == Number && mRoomList[Index].Block == Block)
                {
                    ThisRoom = mRoomList[Index];
                }
                Index++;
            }
        }

        public int Edit()
        {
            //Function to edit an existing record in tblRoom with new details
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisRoom.ID);
            DB.AddParameter("@Number", mThisRoom.Number);
            DB.AddParameter("@Block", mThisRoom.Block);
            DB.AddParameter("@Subject", mThisRoom.Subject);
            return DB.Execute("sproc_tblRoom_EditRoom");
        }

        public void FilterBySubject(string Subject)
        {
            //Populates the mRoomList list by looping through rows in sproc_tblRoom_FilterBySubject based on the inputs
            clsDataConnection DB = new clsDataConnection();
            if (Subject == "Any")
            {
                DB.Execute("sproc_tblRoom_SelectAll");
            }
            else
            {
                DB.AddParameter("@Subject", Subject);
                DB.Execute("sproc_tblRoom_FilterBySubject");
            }
            PopulateList(DB);
        }

        public void RemoveRooms(List<Int32> Rooms, string Subject)
        {
            //Loops through mRoomList and removes any values that are not the provided subject and are not the "Any" subject
            //as well as removing any rooms with IDs that are in the provided list
            Int32 Index = 0;
            while (mRoomList.Count > Index)
            {
                if (mRoomList[Index].Subject != "Any" && mRoomList[Index].Subject != Subject)
                {
                    mRoomList.RemoveAt(Index);
                    Index--;
                }
                else
                {
                    if (Rooms.Contains(mRoomList[Index].ID))
                    {
                        mRoomList.RemoveAt(Index);
                        Index--;
                    }
                }
                Index++;
            }
        }
    }
}
