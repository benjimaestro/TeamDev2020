﻿using System;
using System.Linq;

namespace T_Train_Classes
{
    public class clsCustomer
    {

        string mAddress;
        bool mCustomerActive;
        DateTime mCustomerCreatedAt;
        int mCustomerId;
        DateTime mDateOfBirth;
        string mEmail;
        string mFirstName;
        string mLastName;

        public string Address 
        { 
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public bool CustomerActive 
        { 
            get 
            {
                return mCustomerActive;
            }
            set
            {
                mCustomerActive = value;
            }
        }
        public DateTime CustomerCreatedAt 
        { 
            get 
            {
                return mCustomerCreatedAt;
            } 
            set 
            {
                mCustomerCreatedAt = value;

            }
        }
        public int CustomerId 
        { 
            get 
            { 
                return mCustomerId; 
            } 
            set 
            { 
                mCustomerId = value; 
            } 
        }
        public DateTime DateOfBirth 
        { 
            get 
            { 
                return mDateOfBirth; 
            } 
            set 
            { 
                mDateOfBirth = value; 
            } 
        }
        public string Email 
        { 
            get 
            { 
                return mEmail; 
            } 
            set 
            { 
                mEmail = value; 
            } 
        }
        public string FirstName 
        { 
            get 
            { 
                return mFirstName; 
            } 
            set 
            { 
                mFirstName = value; 
            } 
        }
        public string LastName 
        { 
            get 
            { 
                return mLastName; 
            } 
            set 
            { 
                mLastName = value; 
            } 
        }

        public string ValidateCustomer(string customerAddress, DateTime customerDateOfBirth, string customerEmail, string customerFirstName, string customerLastName)
        {
            string errorMessage = "";

            //Validation for first name
            if (customerFirstName.Length == 0)
            {
                errorMessage += "First name is a required field!" + "<br />";
            }
            else if (customerFirstName.Length > 30)
            {
                errorMessage += "First name must be 30 characters or shorter!" + "<br />";
            }
            else if (customerFirstName.Any(char.IsDigit))
            {
                errorMessage += "First name must not contain any numbers!" + "<br />";
            }

            //Validation for last name
            if (customerLastName.Length == 0)
            {
                errorMessage += "Last name is a required field!" + "<br />";
            }
            else if (customerLastName.Length > 50)
            {
                errorMessage += "Last name must be 50 characters or shorter!" + "<br />";
            }
            else if (customerLastName.Any(char.IsDigit))
            {
                errorMessage += "Last name must not contain any numbers!" + "<br />";
            }

            //Validation for date of birth
            try
            {
                DateTime DateTemp = Convert.ToDateTime(customerDateOfBirth);
                if (DateTemp < Convert.ToDateTime("01/01/1920"))
                {
                    errorMessage += "Entered date of birth suggest the customer is over 100 years old!" + "<br />";
                }
                else if (DateTemp >= Convert.ToDateTime("01/01/2004"))
                {
                    errorMessage += "Entered date of birth suggest the customer is younger than 16 years old!" + "<br />";
                }
            }
            catch
            {
                errorMessage += "Date of birth is a required field!" + "<br />";
            }

            //Validation for address
            if (customerAddress.Length == 0)
            {
                errorMessage += "Address is a required field!" + "<br />";
            }
            else if (customerAddress.Length > 100)
            {
                errorMessage += "Address must be 100 characters or shorter!" + "<br />";
            }
            else if (customerAddress.Length < 11)
            {
                errorMessage += "Address must be 11 characters or longer!" + "<br />";
            }

            //Validation for email
            if (customerEmail.Length == 0)
            {
                errorMessage += "E-Mail address is a required field!" + "<br />";
            }
            else if (customerEmail.Length > 30)
            {
                errorMessage += "E-Mail address must be 30 characters or shorter!" + "<br />";
            }
            else if (customerEmail.Length < 6) //shorted existing email is in format a@g.cn
            {
                errorMessage += "E-Mail address must be 6 characters or longer!" + "<br />";
            }
            else if (!customerEmail.Any(c => c == '@')) //Check if @ is present in string
            {
                errorMessage += "You must enter a valid E-Mail address!" + "<br />";
            }

            return errorMessage;
        }

        public bool FindCustomer(int primaryKey)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@customerId", primaryKey);
            //execute the procedure to get data
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                //common attributes
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                mCustomerCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreatedAt"]);
                //row was found so return true as "found" is positive, a member was found
                return true;
            }
            else return false; //no row found means no customer with this id exists
        }

    }
}