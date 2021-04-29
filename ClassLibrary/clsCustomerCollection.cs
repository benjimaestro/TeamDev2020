using System;
using System.Collections.Generic;

namespace ClassLibrary
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
            DB.AddParameter("@customerPassword", ThisCustomer.AccountPassword);
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
            DB.AddParameter("@customerPassword", ThisCustomer.AccountPassword);
            //update the record
            DB.Execute("sproc_tblCustomer_Update");
        }

        public List<clsCustomer> FilterCustomers(clsCustomer ACustomer)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@firstName", ACustomer.FirstName);
            DB.AddParameter("@lastName", ACustomer.LastName);
            DB.AddParameter("@dob", ACustomer.DateOfBirth);
            //run the search
            DB.Execute("sproc_tblCustomer_FilterCustomers");
            //create an empty list to store customers
            List<clsCustomer> customersFound = new List<clsCustomer>();
            //if there were rows returned, get data from them
            for (int i = 0; i < DB.Count; ++i)
            {
                //get details of the connection
                clsCustomer FoundCustomer = new clsCustomer
                {
                    FirstName = Convert.ToString(DB.DataTable.Rows[i]["FirstName"]),
                    LastName = Convert.ToString(DB.DataTable.Rows[i]["LastName"]),
                    DateOfBirth = Convert.ToString(DB.DataTable.Rows[i]["DateOfBirth"]),
                    CustomerId = Convert.ToInt32(DB.DataTable.Rows[i]["CustomerId"]),
                    Address = Convert.ToString(DB.DataTable.Rows[i]["Address"]),
                    Email = Convert.ToString(DB.DataTable.Rows[i]["Email"]),
                    CustomerActive = Convert.ToBoolean(DB.DataTable.Rows[i]["AccountActive"]),
                    CustomerCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[i]["AccountCreatedAt"]),
                    AccountPassword = Convert.ToString(DB.DataTable.Rows[i]["AccountPassword"]),
                    IsStaff = Convert.ToBoolean(DB.DataTable.Rows[i]["IsStaff"]),
                    TwoFactorEnabled = Convert.ToBoolean(DB.DataTable.Rows[i]["TwoFactorEnabled"]),
                    TwoFactorCode = Convert.ToString(DB.DataTable.Rows[i]["TwoFactorCode"]),
                    DeletionStarted = Convert.ToBoolean(DB.DataTable.Rows[i]["DeletionStarted"]),
                    DeletionStartDate = Convert.ToDateTime(DB.DataTable.Rows[i]["DeletionStartDate"])
            };
                //save a found connection to an array
                customersFound.Add(FoundCustomer);
            }
            //return the array with all connections that were found
            return customersFound;
        }
    }
}