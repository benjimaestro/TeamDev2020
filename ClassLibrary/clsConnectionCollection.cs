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
            DB.AddParameter("@TicketTypeId", ThisConnection.TicketTypeId);
            DB.AddParameter("@ConnectionTime", ThisConnection.ConnectionTime);
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
            DB.AddParameter("@TicketTypeId", ThisConnection.TicketTypeId);
            DB.AddParameter("@ConnectionTime", ThisConnection.ConnectionTime);
            //update the record
            DB.Execute("sproc_tblConnection_Update");
        }

        public List<clsConnection> FilterConnections(clsConnection AConnection)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConnectionActive", AConnection.ConnectionActive);
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
                    ConnectionDate = Convert.ToDateTime(DB.DataTable.Rows[i]["ConnectionDate"]),
                    ConnectionEndStation = Convert.ToString(DB.DataTable.Rows[i]["ConnectionEndStation"]),
                    ConnectionId = Convert.ToInt32(DB.DataTable.Rows[i]["ConnectionId"]),
                    ConnectionStartStation = Convert.ToString(DB.DataTable.Rows[i]["ConnectionStartStation"]),
                    ConnectionTicketLimit = Convert.ToInt32(DB.DataTable.Rows[i]["ConnectionTicketLimit"]),
                    TicketTypeId = Convert.ToInt32(DB.DataTable.Rows[i]["TicketTypeId"]),
                    ConnectionTime = TimeSpan.Parse(Convert.ToString(DB.DataTable.Rows[i]["ConnectionTime"]))
            };
                //save a found connection to an array
                connectionsFound.Add(FoundConnection);
            }
            //return the array with all connections that were found
            return connectionsFound;
        }

        public List<clsConnection> ListConnections()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //get all connections
            DB.Execute("sproc_tblConnection_SelectAll");
            //create an empty list to store connections
            List<clsConnection> connectionsFound = new List<clsConnection>();
            //if there were rows returned, get data from them
            for (int i = 0; i < DB.Count; ++i)
            {
                //get details of the connection
                clsConnection FoundConnection = new clsConnection
                {
                    ConnectionActive = Convert.ToBoolean(DB.DataTable.Rows[i]["ConnectionActive"]),
                    ConnectionDate = Convert.ToDateTime(DB.DataTable.Rows[i]["ConnectionDate"]),
                    ConnectionEndStation = Convert.ToString(DB.DataTable.Rows[i]["ConnectionEndStation"]),
                    ConnectionId = Convert.ToInt32(DB.DataTable.Rows[i]["ConnectionId"]),
                    ConnectionStartStation = Convert.ToString(DB.DataTable.Rows[i]["ConnectionStartStation"]),
                    ConnectionTicketLimit = Convert.ToInt32(DB.DataTable.Rows[i]["ConnectionTicketLimit"]),
                    ConnectionTime = TimeSpan.Parse(Convert.ToString(DB.DataTable.Rows[i]["ConnectionTime"])),
                    TicketTypeId = Convert.ToInt32(DB.DataTable.Rows[i]["TicketTypeId"])
            };
                //save a found connection to an array
                connectionsFound.Add(FoundConnection);
            }
            //return the array with all connections that were found
            return connectionsFound;
        }
    }
}