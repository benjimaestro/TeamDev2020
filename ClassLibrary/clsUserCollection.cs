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
        //List of subjects that a teacher can teach
        List<string> Subjects = new List<string>() { "English", "Maths", "Sciences", "Languages", "I.T.", "D.T.", "Any" };

        public List<clsUser> Userlist
        {
            get { return mUserList; }
            set { mUserList = value; }
        }

        public int Count
        {
            get { return mUserList.Count; }
        }

        public List<string> AvailableSubjects
        {
            get { return Subjects; }
        }

        public clsUser ThisUser
        {
            get { return mThisUser; }
            set { mThisUser = value; }
        }

        public clsUserCollection()
        {
            //Runs when instance of class is created
            //Populates list with all users
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUser_SelectAll");
            PopulateList(DB);
        }

        void PopulateList(clsDataConnection DB)
        {
            //Populates list with whatever table is given to it
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mUserList = new List<clsUser>();
            while (Index < RecordCount)
            {
                clsUser User = new clsUser();
                User.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                User.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                User.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                User.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                User.SecondName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                User.Admin = Convert.ToBoolean(DB.DataTable.Rows[Index]["Admin"]);
                User.Subject = Convert.ToString(DB.DataTable.Rows[Index]["Subject"]);

                mUserList.Add(User);

                Index++;
            }
        }

        public int Add()
        {
            //Function to add new record to tblUser
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EMail", mThisUser.EMail);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@FirstName", mThisUser.FirstName);
            DB.AddParameter("@LastName", mThisUser.SecondName);
            DB.AddParameter("@Admin", mThisUser.Admin);
            DB.AddParameter("@Subject", mThisUser.Subject);
            return DB.Execute("sproc_tblUser_AddUser");
        }

        public void Delete(Int32 Id)
        {
            //Function to delete record from tblUser based on ID
            clsDataConnection DB = new clsDataConnection();
            Int32 Index = 0;
            while (mUserList.Count > Index)
            {
                if (mUserList[Index].ID == Id)
                {
                    mUserList.RemoveAt(Index);
                }
                Index++;
            }
            DB.AddParameter("@Id", Id);
            DB.Execute("sproc_tblUser_DeleteUser");
        }

        public void FindExistingUser(string EMail)
        {
            //Sets the ThisUser to whatever is found with the same user EMail, indicating that a user with this detail already exists
            Int32 Index = 0;
            while (mUserList.Count > Index)
            {
                if (mUserList[Index].EMail == EMail)
                {
                    ThisUser = Userlist[Index];
                }
                Index++;
            }
        }

        public int Edit()
        {
            //Function to edit an existing record in tblUser with new details
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisUser.ID);
            DB.AddParameter("@EMail", mThisUser.EMail);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@FirstName", mThisUser.FirstName);
            DB.AddParameter("@LastName", mThisUser.SecondName);
            DB.AddParameter("@Admin", mThisUser.Admin);
            DB.AddParameter("@Subject", mThisUser.Subject);
            return DB.Execute("sproc_tblUser_EditUser");
        }

        public void FilterByEMail(string EMail)
        {
            //Filters user list by provided EMail
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EMail", EMail);
            DB.Execute("sproc_tblUser_FilterByEMail");
            PopulateList(DB);
        }
   
        public void FilterByName(string Name)
        {
            //Filters user list by provided name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblUser_FilterByName");
            PopulateList(DB);
        }

        public void Find(Int32 Id)
        {
            //Loops through mUserList until it finds a value with the provided ID
            Int32 Index = 0;
            while (mUserList.Count > Index)
            {
                if (mUserList[Index].ID == Id)
                {
                    ThisUser = mUserList[Index];
                }
                Index++;
            }
        }

        public Int32 Login(string EMail, string Password)
        {
            //Loops through mUserList until it finds a value with matching EMail and a correct password
            Int32 Index = 0;
            Int32 ID = -1;
            while (mUserList.Count > Index)
            {
                if (mUserList[Index].EMail == EMail)
                {
                    if (mUserList[Index].Password == Password)
                    {
                        ThisUser = mUserList[Index];
                        ID = ThisUser.ID;
                    }
                    else { ID = 0; }
                }
                Index++;
            }
            return ID;
        }

        public string GetHashPassword(string ToHash)
        {
            //Generates a SHA512 hash of a given password
            //SHA512 is used here because it is the best hashing algorithm the System.Security.Cryptography provides
            //In real world use, a better hashing algorithm would be used, like SHA3

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
