using System;

namespace ClassLibrary
{
    public class clsConnection
    {
        private bool mConnectionActive;
        private DateTime mConnectionDate;
        private string mConnectionEndStation;
        private int mConnectionId;
        private string mConnectionStartStation;
        private int mConnectionTicketLimit;
        private int mTicketTypeId;
        private TimeSpan mConnectionTime;

        public bool ConnectionActive
        {
            get
            {
                return mConnectionActive;
            }
            set
            {
                mConnectionActive = value;
            }
        }
        public DateTime ConnectionDate
        {
            get
            {
                return mConnectionDate;
            }
            set
            {
                mConnectionDate = value;
            }
        }
        public string ConnectionEndStation
        {
            get
            {
                return mConnectionEndStation;
            }
            set
            {
                mConnectionEndStation = value;
            }
        }
        public int ConnectionId
        {
            get
            {
                return mConnectionId;
            }
            set
            {
                mConnectionId = value;
            }
        }
        public string ConnectionStartStation
        {
            get
            {
                return mConnectionStartStation;
            }
            set
            {
                mConnectionStartStation = value;
            }
        }
        public int ConnectionTicketLimit
        {
            get
            {
                return mConnectionTicketLimit;
            }
            set
            {
                mConnectionTicketLimit = value;
            }
        }

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

        public TimeSpan ConnectionTime
        {
            get
            {
                return mConnectionTime;
            }
            set
            {
                mConnectionTime = value;
            }
        }

        public bool FindConnection(int connectionId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@ConnectionId", connectionId);
            //execute the procedure to get data
            DB.Execute("sproc_tblConnection_FilterByConnectionId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mConnectionId = connectionId;
                //common attributes
                mConnectionActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ConnectionActive"]);
                mConnectionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ConnectionDate"]);
                mConnectionEndStation = Convert.ToString(DB.DataTable.Rows[0]["ConnectionEndStation"]);
                mConnectionStartStation = Convert.ToString(DB.DataTable.Rows[0]["ConnectionStartStation"]);
                mConnectionTicketLimit = Convert.ToInt32(DB.DataTable.Rows[0]["ConnectionTicketLimit"]);
                mTicketTypeId = Convert.ToInt32(DB.DataTable.Rows[0]["TicketTypeId"]);
                mConnectionTime = TimeSpan.Parse(Convert.ToString(DB.DataTable.Rows[0]["ConnectionTime"]));
                //row was found so return true as "found" is positive, a connection was found
                return true;
            }
            else return false; //no row found means no connection with this id exists
        }

        public string ValidateConnection(DateTime connectionDate, string connectionStartStation, string connectionEndStation, int connectionTicketLimit)
        {
            string errorMessage = "";

            //Validation for connectionStartStation
            if (String.IsNullOrEmpty(connectionStartStation) || connectionStartStation.Length == 0)
            {
                errorMessage += "Start Station is a required field!" + "<br />";
            }
            else if (connectionStartStation.Length > 70)
            {
                errorMessage += "Start Station must be 70 characters or shorter!" + "<br />";
            }
            else if (connectionStartStation.Length < 2)
            {
                errorMessage += "Start Station must be 2 characters or longer!" + "<br />";
            }
            else if (connectionStartStation.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
            }    

            //Validation for connectionEndStation
            if (String.IsNullOrEmpty(connectionEndStation) || connectionEndStation.Length == 0)
            {
                errorMessage += "End station is a required field!" + "<br />";
            }
            else if (connectionEndStation.Length > 70)
            {
                errorMessage += "End station must be 70 characters or shorter!" + "<br />";
            }
            else if (connectionEndStation.Length < 2)
            {
                errorMessage += "End station must be 2 characters or longer!" + "<br />";
            }
            else if (connectionEndStation.Contains("script"))
            {
                errorMessage += "Illegal input detected!" + "<br />";
            }

            //Validation for connection date
            try
            {
                DateTime DateTemp = Convert.ToDateTime(connectionDate);
                if (DateTemp < Convert.ToDateTime("01/01/2020"))
                {
                    errorMessage += "Connection date entered before the business was established!" + "<br />";
                }
                else if (DateTemp >= Convert.ToDateTime("01/01/2023"))
                {
                    errorMessage += "Connections can only be added two or less years in advance!" + "<br />";
                }
            }
            catch
            {
                errorMessage += "Connection date is a required field!" + "<br />";
            }

            //Validation for ticket limit 
            float testNumber;
            try
            {
                testNumber = connectionTicketLimit;

                if (connectionTicketLimit < 0)
                {
                    errorMessage += "Ticket limit must be 0 or higher!" + "<br />";
                }
                else if (connectionTicketLimit > 500)
                {
                    errorMessage += "Ticket limit must be lower than or equal to 500!" + "<br />";
                }
            }
            catch (Exception)
            {
                errorMessage += "Ticket limit must be a number!" + "<br />";
            }

            return errorMessage;
        }

        public void MarkTicketPurchase()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConnectionId", mConnectionId);
            //execute the procedure
            DB.Execute("sproc_tblConnection_ReduceTicketLimitByOne");
            //update the local count
            ConnectionTicketLimit--;
        }
    }
}