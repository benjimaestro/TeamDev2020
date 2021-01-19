using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsRoom
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
        public bool Find(int ID)
        {
            //FINISH MEEEEEEEEEEEEEEE
            return true;
        }
        public string Validate(int ID, int Number, string Block, int Subject)
        {
            //Finish me also!!!!!!!
            string Error = "";
            return Error;
        }
    }
}
