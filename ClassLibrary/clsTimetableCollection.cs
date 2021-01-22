using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsTimetableCollection
    {
        List<clsTimetable> mTimetableList = new List<clsTimetable>();
        clsTimetable mThisTimetable = new clsTimetable();

        public List<clsTimetable> Timetablelist
        {
            get { return mTimetableList; }
            set { mTimetableList = value; }
        }

        public int Count
        {
            get { return mTimetableList.Count; }
        }

        public clsTimetable ThisTimetable
        {
            get { return mThisTimetable; }
            set { mThisTimetable = value; }
        }

        public clsTimetableCollection()
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
            //Function to edit an existing record in tblTimetable with new details
        }

        public void FilterByID()
        {
            //Finish!!!
        }
        public void FilterByRoomBooked()
        {
            //Finish!!!
        }
    }
}
