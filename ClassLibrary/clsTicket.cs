using System;

namespace ClassLibrary
{
    public class clsTicket
    {
        private int mTicketId;
        private int mConnectionId;
        private int mCustomerId;
        private int mTicketTypeId;
        private bool mTicketActive;
        private DateTime mPurchasedAt;

        public int TicketId
        {
            get
            {
                return mTicketId;
            }
            set
            {
                mTicketId = value;
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
        public bool TicketActive
        {
            get
            {
                return mTicketActive;
            }
            set
            {
                mTicketActive = value;
            }
        }

        public DateTime PurchasedAt
        {
            get
            {
                return mPurchasedAt;
            }
            set
            {
                mPurchasedAt = value;
            }
        }

        public bool FindTicket(int ticketId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@TicketId", ticketId);
            //execute the procedure to get data
            DB.Execute("sproc_tblTicket_FilterByTicketId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                TicketId = ticketId;
                //common attributes
                ConnectionId = Convert.ToInt32(DB.DataTable.Rows[0]["ConnectionId"]);
                CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                TicketActive = Convert.ToBoolean(DB.DataTable.Rows[0]["TicketActive"]);
                PurchasedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["PurchasedAt"]);
                //row was found so return true as "found" is positive, a ticket was found
                return true;
            }
            else return false; //no row found means no ticket with this id exists
        }
    }
}