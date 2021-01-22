using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsUserCollection
    {
        List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();

        public List<clsUser> Userlist
        {
            get { return mUserList; }
            set { mUserList = value; }
        }

        public int Count
        {
            get { return mUserList.Count; }
        }

        public clsUser ThisUser
        {
            get { return mThisUser; }
            set { mThisUser = value; }
        }

        public clsUserCollection()
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
            //Function to edit an existing record in tblUser with new details
        }

        public void FilterByEMail()
        {
            //Finish!!!
        }

        public void FilterByName()
        {
            //Finish!!!
        }
    }
}
