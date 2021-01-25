using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public class clsUserCollection
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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUser_SelectAll");
            PopulateList(DB);
        }

        void PopulateList(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mUserList = new List<clsUser>();
            while (Index < RecordCount)
            {
                clsUser User = new clsUser();
                User.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                User.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                User.EMail = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                User.EMail = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                User.EMail = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                User.Admin = Convert.ToBoolean(DB.DataTable.Rows[Index]["Admin"]);
                User.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);

                mUserList.Add(User);

                Index++;
            }
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

        public string GetHashPassword(string ToHash)
        {
            if (ToHash != "")
            {
                SHA512Managed HashGen = new SHA512Managed();
                string HashString;
                byte[] TextBytes;
                byte[] HashBytes;

                TextBytes = System.Text.Encoding.UTF8.GetBytes(ToHash);
                HashBytes = HashGen.ComputeHash(TextBytes);
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;
            }
            else { return ""; }
        }
    }
}
