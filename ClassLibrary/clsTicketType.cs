using System;

namespace ClassLibrary
{
    public class clsTicketType
    {

        int mTicketTypeId;
        bool mTicketTypeActive;
        string mTicketTypeName;
        float mTicketTypePrice;
        bool mTicketTypeRefundable;

        public int TicketTypeId
        {
            get
            {
                return mTicketTypeId;
            }
            set
            {
                mTicketTypeId = value;
            }
        }
        public bool TicketTypeActive
        {
            get
            {
                return mTicketTypeActive;
            }
            set
            {
                mTicketTypeActive = value;
            }
        }
        public string TicketTypeName
        {
            get
            {
                return mTicketTypeName;
            }
            set
            {
                mTicketTypeName = value;
            }
        }
        public float TicketTypePrice
        {
            get
            {
                return mTicketTypePrice;
            }
            set
            {
                mTicketTypePrice = value;
            }
        }
        public bool TicketTypeRefundable
        {
            get
            {
                return mTicketTypeRefundable;
            }
            set
            {
                mTicketTypeRefundable = value;
            }
        }

        public bool FindTicketType(int ticketTypeId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@ticketTypeId", ticketTypeId);
            //execute the procedure to get data
            DB.Execute("sproc_tblTicketType_FilterByTicketTypeId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mTicketTypeId = Convert.ToInt32(DB.DataTable.Rows[0]["TicketTypeId"]);
                //common attributes
                mTicketTypeActive = Convert.ToBoolean(DB.DataTable.Rows[0]["TicketTypeActive"]);
                mTicketTypeName = Convert.ToString(DB.DataTable.Rows[0]["TicketTypeName"]);
                mTicketTypePrice = float.Parse(Convert.ToString(DB.DataTable.Rows[0]["TicketTypePrice"]));
                mTicketTypeRefundable = Convert.ToBoolean(DB.DataTable.Rows[0]["TicketTypeRefundable"]);
                //row was found so return true as "found" is positive, a member was found
                return true;
            }
            else return false; //no row found means no customer with this id exists
        }

        public string ValidateTicketType(string ticketTypeName, float ticketTypePrice)
        {
            string errorMessage = "";

            //Validation for ticket type name
            if (ticketTypeName.Length == 0)
            {
                errorMessage += "Ticket type name is a required field!" + "<br />";
            }
            else if (ticketTypeName.Length < 4)
            {
                errorMessage += "Ticket type name must be 4 characters or longer!" + "<br />";
            }
            else if (ticketTypeName.Length > 40)
            {
                errorMessage += "Ticket type name must be 40 characters or shorter!" + "<br />";
            }
            else if (ticketTypeName.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
            }

            //Validation for ticket type price
            float testNumber;
            try
            {
                testNumber = ticketTypePrice;

                if (ticketTypePrice < 0.00f)
                {
                    errorMessage += "Ticket type price must be 0 or higher!" + "<br />";
                }
                else if (ticketTypePrice > 1000.00f)
                {
                    errorMessage += "Ticket type price must be lower than or equal to 1000!" + "<br />";
                }
            }
            catch(Exception)
            {
                errorMessage += "Ticket type price must be a number!" + "<br />";
            }

            return errorMessage;
        }
    }
}