using System;
using System.Collections.Generic;

namespace T_Train_Classes
{
    public class clsCustomerCollection
    {

        List<clsCustomer> mMyCustomers;
        clsCustomer mThisCustomer;

        public List<clsCustomer> MyCustomers
        {
            get
            {
                return mMyCustomers;
            }
            set
            {
                mMyCustomers = value;
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mMyCustomers.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int CreateAccount()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@customerAddress", ThisCustomer.Address);
            DB.AddParameter("@customerDateOfBirth", ThisCustomer.DateOfBirth);
            DB.AddParameter("@customerEmail", ThisCustomer.Email);
            DB.AddParameter("@customerFirstName", ThisCustomer.FirstName);
            DB.AddParameter("@customerLastName", ThisCustomer.LastName);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void CloseAccount()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to delete
            DB.AddParameter("@customerId", ThisCustomer.CustomerId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ChangeDetails()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@customerId", ThisCustomer.CustomerId);
            DB.AddParameter("@customerAddress", ThisCustomer.Address);
            DB.AddParameter("@customerDateOfBirth", ThisCustomer.DateOfBirth);
            DB.AddParameter("@customerEmail", ThisCustomer.Email);
            DB.AddParameter("@customerFirstName", ThisCustomer.FirstName);
            DB.AddParameter("@customerLastName", ThisCustomer.LastName);
            //update the record
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}