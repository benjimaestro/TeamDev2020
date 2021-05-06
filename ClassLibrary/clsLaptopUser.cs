using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsLaptopUser : clsAbstractUser
    {
        string mLaptopUserAddress;
        bool mLaptopUserActive;
        string mLaptopUserEmail;
        string mLaptopUserFirstName;
        string mLaptopUserLastName;
        string mLaptopUserTelephoneNumber;
        int mLaptopUserId;
        string mLaptopUser;
        DateTime mLaptopUserCreatedAt;
        string mLaptopUserPassword;
        bool mLaptopStaff;

        public class ClsLaptopUser
        {
            //private data member for the LaptopUserId property
            private Int32 mLaptopUserId;
            private string mLaptopUserAddress;
            private string mLaptopUserFirstName;
            private string mLaptopUserLastName;
            private string mLaptopUserPassword;
            private string mLaptopUserEmail;
            private DateTime mLaptopUserCreatedAt;
            private Boolean mLaptopStaff;

        }


        public string LaptopUserAddress
        {
            get
            {
                return mLaptopUserAddress;
            }
            set
            {
                mLaptopUserAddress = value;
            }
        }
        public bool LaptopUserActive
        {
            get
            {
                return mLaptopUserActive;
            }
            set
            {
                mLaptopUserActive = value;
            }
        }
        public string LaptopUserEmail
        {
            get
            {
                return mLaptopUserEmail;
            }
            set
            {
                mLaptopUserEmail = value;
            }
        }
        public string LaptopUserFirstName
        {
            get
            {
                return mLaptopUserFirstName;
            }
            set
            {
                mLaptopUserFirstName = value;
            }
        }
        public string LaptopUserLastName
        {
            get
            {
                return mLaptopUserLastName;
            }
            set
            {
                mLaptopUserLastName = value;
            }
        }
        public string LaptopUserTelephoneNumber
        {
            get
            {
                return mLaptopUserTelephoneNumber;
            }
            set
            {
                mLaptopUserTelephoneNumber = value;
            }
        }
        public int LaptopUserId
        {
            get
            {
                return mLaptopUserId;
            }
            set
            {
                mLaptopUserId = value;
            }
        }
        public string LaptopUser
        {
            get
            {
                return mLaptopUser;
            }
            set
            {
                mLaptopUser = value;
            }
        }



       

        public bool FindLaptopUser(int LaptopUserId)
        {
            throw new NotImplementedException();
        }

        public DateTime LaptopUserCreatedAt
        {
            get
            {
                return mLaptopUserCreatedAt;
            }
            set
            {
                mLaptopUserCreatedAt = value;
            }
        }
        public string LaptopUserPassword
        {
            get
            {
                return mLaptopUserPassword;
            }
            set
            {
                mLaptopUserPassword = value;
            }
        }
        public bool LaptopStaff
        {
            get
            {
                return mLaptopStaff;
            }
            set
            {
                mLaptopStaff= value;
            }
        }

    
        public string FullNameEmail
        {
            get { return $"{LaptopUserFirstName} {LaptopUserLastName} ({LaptopUserEmail})"; }
        }

        public string AccountPassword { get; set; }

        public string Valid(string LaptopUserAddress, string LaptopUserEmail, string LaptopUserFirstName, string LaptopUserLastName, string LaptopUserPassword, string LaptopUserTelephoneNumber)
        {
            return "";
        }

        public string ValidateLaptopUser(string LaptopUserAddress, string LaptopUserPassword, string LaptopUserEmail, string LaptopUserFirstName, string LaptopUserLastName, string LaptopUserTelephoneNumber)
        {
            string errorMessage = "";

            //Validation for first name
            if (LaptopUserFirstName.Length == 0)
            {
                errorMessage += "First name is a required field!" + "<br />";
            }
            else if (LaptopUserFirstName.Length > 14)
            {
                errorMessage += "First name must be 14 characters or shorter!" + "<br />";
            }
            else if (LaptopUserFirstName.Any(char.IsDigit))
            {
                errorMessage += "First name must not contain any numbers!" + "<br />";


            }

            //Validation for last name
            if (LaptopUserLastName.Length == 0)
            {
                errorMessage += "Last name is a required field!" + "<br />";
            }
            else if (LaptopUserLastName.Length > 14)
            {
                errorMessage += "Last name must be 14 characters or shorter!" + "<br />";
            }
            else if (LaptopUserLastName.Any(char.IsDigit))
            {
                errorMessage += "Last name must not contain any numbers!" + "<br />";
            }
            //Validation for email
            if (LaptopUserEmail.Length == 0)
            {
                errorMessage += "E-Mail address is a required field!" + "<br />";
            }
            else if (LaptopUserEmail.Length > 30)
            {
                errorMessage += "E-Mail address must be 30 characters or shorter!" + "<br />";
            }
            else if (LaptopUserEmail.Length < 13) //shorted existing email is in format e@hotmail.com
            {
                errorMessage += "E-Mail address must be 13 characters or longer!" + "<br />";
            }
            else if (!LaptopUserEmail.Any(c => c == '@')) //Check if @ is present in string
            {
                errorMessage += "You must enter a valid E-Mail address!" + "<br />";

            }

            //Validation for address
            if (LaptopUserAddress.Length == 0)
            {
                errorMessage += "Address is a required field!" + "<br />";
            }
            else if (LaptopUserAddress.Length > 100)
            {
                errorMessage += "Address must be 100 characters or shorter!" + "<br />";
            }
            else if (LaptopUserAddress.Length < 12)
            {
                errorMessage += "Address must be 12 characters or longer!" + "<br />";
            }

            //Validation for Password
            if (LaptopUserPassword.Length == 0)
            {
                errorMessage += "TelephoneNumber is a required field!" + "<br />";
            }
            else if (LaptopUserPassword.Length > 14)
            {
                errorMessage += "TelephoneNumber must be 14 characters or shorter!" + "<br />";
            }
            else if (LaptopUserPassword.Length < 10)
            {
                errorMessage += "TelephoneNumber must be 10 characters or longer!" + "<br />";
            }
            //Validation for TelephoneNumber
            if (LaptopUserTelephoneNumber.Length == 0)
            {
                errorMessage += "TelephoneNumber is a required field!" + "<br />";
            }
            else if (LaptopUserTelephoneNumber.Length > 14)
            {
                errorMessage += "TelephoneNumber must be 14 characters or shorter!" + "<br />";
            }
            else if (LaptopUserTelephoneNumber.Length < 12)
            {
                errorMessage += "TelephoneNumber must be 12 characters or longer!" + "<br />";
            }
            return errorMessage;
        }

        public bool FindLaptopUserId(int LaptopUserId)
        {

            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@LaptopUserId", LaptopUserId);
            //execute the procedure to get data
            DB.Execute("sproc_tblLaptopUser_FilterByLaptopUserId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mLaptopUserId = Convert.ToInt32(DB.DataTable.Rows[0]["LaptopUserId"]);
                //common attributes
                mLaptopUserFirstName = Convert.ToString(DB.DataTable.Rows[0]["LaptopUserFirstName"]);
                mLaptopUserLastName = Convert.ToString(DB.DataTable.Rows[0]["LaptopUserLastName"]);
                mLaptopUserAddress = Convert.ToString(DB.DataTable.Rows[0]["LaptopUserAddress"]);
                mLaptopUserEmail = Convert.ToString(DB.DataTable.Rows[0]["LaptopUserEMail"]);
                mLaptopUserCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["LaptopUserCreatedAt"]);
                mLaptopUserTelephoneNumber = Convert.ToString(DB.DataTable.Rows[0]["LaptopUserTelephoneNumber"]);
                mLaptopUserPassword = Convert.ToString(DB.DataTable.Rows[0]["LaptopUserPassword"]);
                mLaptopStaff = Convert.ToBoolean(DB.DataTable.Rows[0]["LaptopStaff"]);
                
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {  
                //return false indicating a problem
               return false; 
            }
                
        }

        public void UpdateLaptopUserPassword(string newLaptopUserPassword)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@LaptopUserId", LaptopUserId);
            DB.AddParameter("@LaptopUserPassword", newLaptopUserPassword);
            //execute the procedure to update the user password
            DB.Execute("sproc_tblLaptopUser_UpdateLaptopUserPassword");
        }

        
        
    }

    
}