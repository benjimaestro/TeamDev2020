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

        public List<clsTicket> GetUserTickets(int customerId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to get tickets from
            DB.AddParameter("@CustomerId", customerId);
            //proceed to get the tickets
            DB.Execute("sproc_tblTicket_GetUserTickets");
            //create an empty list to store tickets
            List<clsTicket> userTickets = new List<clsTicket>();
            //if there were rows returned, get data from them
            for (int i = 0; i < DB.Count; ++i)
            {
                //get details of the ticket
                clsTicket ATicket = new clsTicket
                {
                    TicketId = Convert.ToInt32(DB.DataTable.Rows[i]["TicketId"]),
                    TicketActive = Convert.ToBoolean(DB.DataTable.Rows[i]["TicketActive"]),
                    ConnectionId = Convert.ToInt32(DB.DataTable.Rows[i]["ConnectionId"])
                };
                //save a found ticket to an array
                userTickets.Add(ATicket);
            }
            //return the array with all tickets that were found
            return userTickets;
        }
    }

}