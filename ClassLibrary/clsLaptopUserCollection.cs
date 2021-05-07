using System.Collections.Generic;
using System;


namespace ClassLibrary
{
    public class clsLaptopUserCollection
    {
        //private data member for the allLaptopUsers list
        List<clsLaptopUser> mAllLaptopUsers = new List<clsLaptopUser>();
        //public List<clsLaptopUser> MyLaptopUsers;
        //public List<clsLaptopUser> MAllLaptopUsers;
        clsLaptopUser mThisLaptopuser;
        clsLaptopUser mThisLaptopUser = new clsLaptopUser();

        public List<clsLaptopUser> MAllLaptopUsers
        {
            get
            {
                return mAllLaptopUsers;
            }
            set
            {
                mAllLaptopUsers = value;
            }
        }
        //public property for Count
        public int Count
        {

            get
            {
                //return the count property of the private list
                return mAllLaptopUsers.Count;
            }
            set
            {
                //we will look at this later!
            }
        }

        //public property for allLaptopUsers
        public List<clsLaptopUser> AllLaptopUsers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllLaptopUsers;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoing value to the private data member
                mAllLaptopUsers = value;
            }
        }
       
        public clsLaptopUser ThisLaptopUser
        {
            get
            {
                return mThisLaptopuser;
            }
            set
            {
                mThisLaptopuser = value;
            }

        }
        
        //public constructor for the class
        public clsLaptopUserCollection()
        {
            //Runs when instance of class is created
            //Populates list with all users
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblLaptopUser_SelectAll");
            PopulateList(DB);
        }
        void PopulateList(clsDataConnection DB)
        {
            //Populates list with whatever table is given to it
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mAllLaptopUsers = new List<clsLaptopUser>();
            while (Index < RecordCount)
            {
                clsLaptopUser LaptopUser = new clsLaptopUser();
                LaptopUser.LaptopUserId = Convert.ToInt32(DB.DataTable.Rows[Index]["LaptopUserId"]);
                LaptopUser.LaptopUserEmail = Convert.ToString(DB.DataTable.Rows[Index]["LaptopUserEmail"]);
                LaptopUser.LaptopUserPassword = Convert.ToString(DB.DataTable.Rows[Index]["LaptopUserPassword"]);
                LaptopUser.LaptopUserFirstName = Convert.ToString(DB.DataTable.Rows[Index]["LaptopUserFirstName"]);
                LaptopUser.LaptopUserLastName = Convert.ToString(DB.DataTable.Rows[Index]["LaptopUserLastName"]);
                LaptopUser.LaptopStaff = Convert.ToBoolean(DB.DataTable.Rows[Index]["LaptopStaff"]);
                LaptopUser.LaptopUserTelephoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["LaptopUserTelephoneNumber"]);
                LaptopUser.LaptopUserAddress = Convert.ToString(DB.DataTable.Rows[Index]["LaptopUserAddress"]);
                mAllLaptopUsers.Add(LaptopUser);

                Index++;
            }
        }

        public void CloseAccount()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to delete
            DB.AddParameter("@LaptopUserId", ThisLaptopUser.LaptopUserId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblLaptopUser_Delete");
        }

        public int CreateAccount()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@LaptopUserAddress", mThisLaptopuser.LaptopUserAddress);
            DB.AddParameter("@LaptopUserCreatedAt", mThisLaptopuser.LaptopUserCreatedAt);
            DB.AddParameter("@LaptopUserEmail", ThisLaptopUser.LaptopUserEmail);
            DB.AddParameter("@LaptopUserFirstName", ThisLaptopUser.LaptopUserFirstName);
            DB.AddParameter("@LaptopUserLastName", ThisLaptopUser.LaptopUserLastName);
            DB.AddParameter("@LaptopUserPassword", ThisLaptopUser.LaptopUserPassword);
            DB.AddParameter("@LaptopUserTelephoneNumber", ThisLaptopUser.LaptopUserPassword);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblLaptopUser_Insert");
        }

       
    }

    }


