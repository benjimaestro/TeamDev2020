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
        public string Validate(string Block, string Number, string Subject)
        {
            Int32 IntNumber = 1;
            string Error = "";
            try { IntNumber = Convert.ToInt32(Number); }
            catch { Error = Error + "Room number must be a number</br>"; }

            if (IntNumber < 2 || IntNumber > 99) { Error = Error + "Room number must be 1-99</br>"; }
            if (Block.Length != 1) { Error = Error + "Block must be a single character</br>"; }
            if (Subject.Length < 1 || Subject.Length > 10) { Error = Error + "Subject must be 1-10 characters</br>"; }
            return Error;
        }
    }
}
