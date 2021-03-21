using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsConnectionCollection
    {
        public List<clsConnection> MyConnections { get; set; }

        public clsConnection ThisConnection { get; set; }
        public int Count
        {
            get
            {
                return MyConnections.Count;
            }
            set
            {
                //later
            }
        }

        public int AddConnection()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConnectionActive", ThisConnection.ConnectionActive);
            DB.AddParameter("@ConnectionDate", ThisConnection.ConnectionDate);
            DB.AddParameter("@ConnectionEndStation", ThisConnection.ConnectionEndStation);
            DB.AddParameter("@ConnectionStartStation", ThisConnection.ConnectionStartStation);
            DB.AddParameter("@ConnectionTicketLimit", ThisConnection.ConnectionTicketLimit);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblConnection_Insert");
        }

        public void DeleteConnection()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to delete
            DB.AddParameter("@ConnectionId", ThisConnection.ConnectionId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblConnection_Delete");
        }

        public void ModifyConnection()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConnectionId", ThisConnection.ConnectionId);
            DB.AddParameter("@ConnectionActive", ThisConnection.ConnectionActive);
            DB.AddParameter("@ConnectionDate", ThisConnection.ConnectionDate);
            DB.AddParameter("@ConnectionEndStation", ThisConnection.ConnectionEndStation);
            DB.AddParameter("@ConnectionStartStation", ThisConnection.ConnectionStartStation);
            DB.AddParameter("@ConnectionTicketLimit", ThisConnection.ConnectionTicketLimit);
            //update the record
            DB.Execute("sproc_tblConnection_Update");
        }
    }
}