using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsRoomCollection
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
            //FINISH MEEEEEE
        }

        void PopulateList(clsDataConnection DB)
        {
            //FINISH MEEEEEEEEEEEEEE
        }

        public int Add()
        {
            //Finish MEEEEEEEEE
            return 0;
        }

        public void Delete()
        {
            //Me too!
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
