using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsTicketTypeCollection
    {
        public List<clsTicketType> MyTicketTypes { get; set; }
        public clsTicketType ThisTicketType { get; set; }
        public int Count
        {
            get
            {
                return MyTicketTypes.Count;
            }
            set
            {
                //we will do this later
            }
        }

        public int AddTicketType()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ticketTypeActive", ThisTicketType.TicketTypeActive);
            DB.AddParameter("@ticketTypeName", ThisTicketType.TicketTypeName);
            DB.AddParameter("@ticketTypePrice", ThisTicketType.TicketTypePrice);
            DB.AddParameter("@ticketTypeRefundable", ThisTicketType.TicketTypeRefundable);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblTicketType_Insert");
        }

        public void DeleteTicketType()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to delete
            DB.AddParameter("@TicketTypeId", ThisTicketType.TicketTypeId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblTicketType_Delete");
        }

        public void ModifyTicketType()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TicketTypeActive", ThisTicketType.TicketTypeActive);
            DB.AddParameter("@TicketTypeName", ThisTicketType.TicketTypeName);
            DB.AddParameter("@TicketTypePrice", ThisTicketType.TicketTypePrice);
            DB.AddParameter("@TicketTypeRefundable", ThisTicketType.TicketTypeRefundable);
            DB.AddParameter("@TicketTypeId", ThisTicketType.TicketTypeId);
            //update the record
            DB.Execute("sproc_tblTicketType_Update");
        }

        public List<clsTicketType> FilterTicketTypes(clsTicketType ATicketType)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TicketTypeName", ATicketType.TicketTypeName);
            DB.AddParameter("@TicketTypePrice", ATicketType.TicketTypePrice);
            DB.AddParameter("@TicketTypeRefundable", ATicketType.TicketTypeRefundable);
            //execute the procedure to get data
            DB.Execute("sproc_tblTicketType_FilterTicketTypes");
            //create an empty list to store ticket types
            List<clsTicketType> ticketTypesFound = new List<clsTicketType>();
            //if there were rows returned, get data from them
            for (int i = 0; i < DB.Count; ++i)
            {
                //get details of the ticket type
                clsTicketType FoundTicketType = new clsTicketType
                {
                    TicketTypeId = Convert.ToInt32(DB.DataTable.Rows[i]["TicketTypeId"]),
                    //common attributes
                    TicketTypeActive = Convert.ToBoolean(DB.DataTable.Rows[i]["TicketTypeActive"]),
                    TicketTypeName = Convert.ToString(DB.DataTable.Rows[i]["TicketTypeName"]),
                    TicketTypePrice = float.Parse(Convert.ToString(DB.DataTable.Rows[i]["TicketTypePrice"])),
                    TicketTypeRefundable = Convert.ToBoolean(DB.DataTable.Rows[i]["TicketTypeRefundable"])
                };
                //save a found ticket type to an array
                ticketTypesFound.Add(FoundTicketType);
            }
            //return the array with all ticket types that were found
            return ticketTypesFound;
        }

        public List<clsTicketType> ListTicketTypes()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //execute the procedure to get data
            DB.Execute("sproc_tblTicketType_GetAllTicketTypes");
            //create an empty list to store ticket types
            List<clsTicketType> ticketTypesFound = new List<clsTicketType>();
            //if there were rows returned, get data from them
            for (int i = 0; i < DB.Count; ++i)
            {
                //get details of the ticket type
                clsTicketType FoundTicketType = new clsTicketType
                {
                    TicketTypeId = Convert.ToInt32(DB.DataTable.Rows[i]["TicketTypeId"]),
                    //common attributes
                    TicketTypeActive = Convert.ToBoolean(DB.DataTable.Rows[i]["TicketTypeActive"]),
                    TicketTypeName = Convert.ToString(DB.DataTable.Rows[i]["TicketTypeName"]),
                    TicketTypePrice = float.Parse(Convert.ToString(DB.DataTable.Rows[i]["TicketTypePrice"])),
                    TicketTypeRefundable = Convert.ToBoolean(DB.DataTable.Rows[i]["TicketTypeRefundable"])
                };
                //save a found ticket type to an array
                ticketTypesFound.Add(FoundTicketType);
            }
            //return the array with all ticket types that were found
            return ticketTypesFound;
        }
    }
}