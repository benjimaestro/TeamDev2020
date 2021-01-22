using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsMessageCollection
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

        public void FilterByUserID()
        {
            //Finish!!!
        }
    }
}
