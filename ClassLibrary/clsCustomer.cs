using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsCustomer : clsAbstractUser
    {

        string mAddress;
        bool mCustomerActive;
        DateTime mCustomerCreatedAt;
        int mCustomerId;
        string mDateOfBirth;
        string mAccountPassword;
        bool mIsStaff;
        bool mTwoFactorEnabled;
        string mTwoFactorCode;
        bool mDeletionStarted;
        DateTime mDeletionStartDate;

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
        public string DateOfBirth 
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

        public string AccountPassword
        {
            get
            {
                return mAccountPassword;
            }
            set
            {
                mAccountPassword = value;
            }
        }

        public bool IsStaff
        {
            get
            {
                return mIsStaff;
            }
            set
            {
                mIsStaff = value;
            }
        }

        public bool TwoFactorEnabled
        {
            get
            {
                return mTwoFactorEnabled;
            }
            set
            {
                mTwoFactorEnabled = value;
            }
        }

        public string TwoFactorCode
        {
            get
            {
                return mTwoFactorCode;
            }
            set
            {
                mTwoFactorCode = value;
            }
        }

        public bool DeletionStarted
        {
            get
            {
                return mDeletionStarted;
            }
            set
            {
                mDeletionStarted = value;
            }
        }

        public DateTime DeletionStartDate
        {
            get
            {
                return mDeletionStartDate;
            }
            set
            {
                mDeletionStartDate = value;
            }
        }

        public string ValidateCustomer(string customerAddress, string customerDateOfBirth, string customerEMail, string customerFirstName, string customerLastName)
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
            else if (customerFirstName.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
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
            else if (customerLastName.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
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
            else if (customerAddress.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
            }

            //Validation for EMail
            if (customerEMail.Length == 0)
            {
                errorMessage += "E-Mail address is a required field!" + "<br />";
            }
            else if (customerEMail.Length > 30)
            {
                errorMessage += "E-Mail address must be 30 characters or shorter!" + "<br />";
            }
            else if (customerEMail.Length < 6) //shorted existing EMail is in format a@g.cn
            {
                errorMessage += "E-Mail address must be 6 characters or longer!" + "<br />";
            }
            else if (!customerEMail.Any(c => c == '@')) //Check if @ is present in string
            {
                errorMessage += "You must enter a valid E-Mail address!" + "<br />";
            }
            else if (customerEMail.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
            }

            return errorMessage;
        }

        public void ToggleTwoFactorAuthentication()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", CustomerId);
            //toggle means switch enabled to disabled and vice versa
            DB.AddParameter("@toggle", !TwoFactorEnabled);
            //if we disable 2FA, reset the code to an empty string
            if(TwoFactorEnabled) DB.AddParameter("@code", "00000000");
            else DB.AddParameter("@code", TwoFactorCode);
            //execute the procedure to update the user password
            DB.Execute("sproc_tblCustomer_ToggleTwoFactorAuth");
        }

        public void UpdatePassword(string newPassword)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@customerId", CustomerId);
            DB.AddParameter("@newPassword", newPassword);
            //execute the procedure to update the user password
            DB.Execute("sproc_tblCustomer_UpdatePassword");
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
                mDateOfBirth = Convert.ToString(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["EMail"]);
                mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                mCustomerCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreatedAt"]);
                mAccountPassword = Convert.ToString(DB.DataTable.Rows[0]["AccountPassword"]);
                mIsStaff = Convert.ToBoolean(DB.DataTable.Rows[0]["IsStaff"]);
                mTwoFactorEnabled = Convert.ToBoolean(DB.DataTable.Rows[0]["TwoFactorEnabled"]);
                mTwoFactorCode = Convert.ToString(DB.DataTable.Rows[0]["TwoFactorCode"]);
                mDeletionStarted = Convert.ToBoolean(DB.DataTable.Rows[0]["DeletionStarted"]);
                mDeletionStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeletionStartDate"]);
                //row was found so return true as "found" is positive, a member was found
                return true;
            }
            else return false; //no row found means no customer with this id exists
        }

        public void ToggleDeletion()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", CustomerId);
            //toggle means switch enabled to disabled and vice versa
            DB.AddParameter("@toggle", !DeletionStarted);
            //if we disable deletion, reset the date to a null
            if (DeletionStarted) DB.AddParameter("@date", DateTime.Now);
            else DB.AddParameter("@date", DeletionStartDate);
            //execute the procedure to update the user password
            DB.Execute("sproc_tblCustomer_ToggleDeletion");
        }

        public bool FindCustomerByEmail(string testEmail)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@customerEmail", testEmail);
            //execute the procedure to get data
            DB.Execute("sproc_tblCustomer_FilterByCustomerEmail");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                //common attributes
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateOfBirth = Convert.ToString(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = testEmail;
                mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                mCustomerCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreatedAt"]);
                mAccountPassword = Convert.ToString(DB.DataTable.Rows[0]["AccountPassword"]);
                mIsStaff = Convert.ToBoolean(DB.DataTable.Rows[0]["IsStaff"]);
                mTwoFactorEnabled = Convert.ToBoolean(DB.DataTable.Rows[0]["TwoFactorEnabled"]);
                mTwoFactorCode = Convert.ToString(DB.DataTable.Rows[0]["TwoFactorCode"]);
                mDeletionStarted = Convert.ToBoolean(DB.DataTable.Rows[0]["DeletionStarted"]);
                mDeletionStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeletionStartDate"]);
                //row was found so return true as "found" is positive, a member was found
                return true;
            }
            else return false; //no row found means no customer with this email exists
        }

        static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        static bool IsSymbol(char c)
        {
            return c > 32 && c < 127 && !IsDigit(c) && !IsLetter(c);
        }
        public bool ValidatePassword(string password)
        {
            //a valid password is at least 8 characters long and contains both:
            //a special character, a digit
            return password.Any(c => IsDigit(c)) && password.Any(c => IsSymbol(c)) && password.Length > 7;
        }
    }
}