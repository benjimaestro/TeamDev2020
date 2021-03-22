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

        public List<clsConnection> filterConnections(clsConnection AConnection)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConnectionActive", true);
            DB.AddParameter("@ConnectionDate", AConnection.ConnectionDate);
            DB.AddParameter("@ConnectionEndStation", AConnection.ConnectionEndStation);
            DB.AddParameter("@ConnectionStartStation", AConnection.ConnectionStartStation);
            //run the search
            DB.Execute("sproc_tblConnection_FilterConnections");
            //create an empty list to store connections
            List<clsConnection> connectionsFound = new List<clsConnection>();
            //if there were rows returned, get data from them
            for(int i = 0; i < DB.Count; ++i)
            {
                //get details of the connection
                clsConnection FoundConnection = new clsConnection
                {
                    ConnectionActive = Convert.ToBoolean(DB.DataTable.Rows[i]["ConnectionActive"]),
                    ConnectionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ConnectionDate"]),
                    ConnectionEndStation = Convert.ToString(DB.DataTable.Rows[0]["ConnectionEndStation"]),
                    ConnectionId = Convert.ToInt32(DB.DataTable.Rows[0]["ConnectionId"]),
                    ConnectionStartStation = Convert.ToString(DB.DataTable.Rows[0]["ConnectionStartStation"]),
                    ConnectionTicketLimit = Convert.ToInt32(DB.DataTable.Rows[0]["ConnectionTicketLimit"])
                };
                //save a found connection to an array
                connectionsFound.Add(FoundConnection);
            }
            //return the array with all connections that were found
            return connectionsFound;
        }
    }
}