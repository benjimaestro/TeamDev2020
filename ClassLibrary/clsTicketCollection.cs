using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsTicketCollection
    {
        private List<clsTicket> mMyTickets;
        private clsTicket mThisTicket;

        public List<clsTicket> MyTickets
        {
            get
            {
                return mMyTickets;
            }
            set
            {
                mMyTickets = value;
            }
        }
        public clsTicket ThisTicket
        {
            get
            {
                return mThisTicket;
            }
            set
            {
                mThisTicket = value;
            }
        }
        public int Count
        {
            get
            {
                return MyTickets.Count;
            }
            set
            {
                //later
            }
        }

        public int AddTicket()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConnectionId", ThisTicket.ConnectionId);
            DB.AddParameter("@CustomerId", ThisTicket.CustomerId);
            DB.AddParameter("@TicketActive", ThisTicket.TicketActive);
            DB.AddParameter("@TicketTypeId", ThisTicket.TicketTypeId);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblTicket_Insert");
        }

        public void DeleteTicket()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to delete
            DB.AddParameter("@TicketId", ThisTicket.TicketId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblTicket_Delete");
        }
    }

}