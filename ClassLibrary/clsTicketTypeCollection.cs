using System;
using System.Collections.Generic;

namespace T_Train_Classes
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
    }
}