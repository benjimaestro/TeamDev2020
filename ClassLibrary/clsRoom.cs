using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsRoom
    {
        private Int32 mID;
        private Int32 mNumber;
        private string mBlock;
        private string mSubject;

        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public int Number
        {
            get { return mNumber; }
            set { mNumber = value; }
        }
        public string Block
        {
            get { return mBlock; }
            set { mBlock = value; }
        }
        public string Subject
        {
            get { return mSubject; }
            set { mSubject = value; }
        }
        public string RoomName
        {
            get { return $"{mBlock.ToUpper()}.{mNumber.ToString()}"; }
        }

        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Id", ID);
            DB.Execute("sproc_tblRoom_FilterByID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mNumber = Convert.ToInt32(DB.DataTable.Rows[0]["Number"]);
                mBlock = Convert.ToString(DB.DataTable.Rows[0]["Block"]);
                mSubject = Convert.ToString(DB.DataTable.Rows[0]["Subject"]);
                return true;
            }
            else { return false; }
        }
        public string Validate(int ID, int Number, string Block, int Subject)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
