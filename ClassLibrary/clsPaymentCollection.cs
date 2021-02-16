using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        public List<clsPayment> MyPayments { get; set; }
        public clsPayment ThisPayment { get; set; }
        public int Count
        {
            get
            {
                return MyPayments.Count;
            }
            set
            {
                //later
            }
        }

        public int AddPayment()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", ThisPayment.CustomerId);
            DB.AddParameter("@PaymentEndDate", ThisPayment.PaymentEndDate);
            DB.AddParameter("@PaymentStartDate", ThisPayment.PaymentStartDate);
            DB.AddParameter("@PaymentValue", ThisPayment.PaymentValue);
            DB.AddParameter("@TicketId", ThisPayment.TicketId);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void DeletePayment()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of customer to delete
            DB.AddParameter("@PaymentId", ThisPayment.PaymentId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblPayment_Delete");
        }

        public void UpdatePayment()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PaymentId", ThisPayment.PaymentId);
            DB.AddParameter("@CustomerId", ThisPayment.CustomerId);
            DB.AddParameter("@PaymentEndDate", ThisPayment.PaymentEndDate);
            DB.AddParameter("@PaymentStartDate", ThisPayment.PaymentStartDate);
            DB.AddParameter("@PaymentValue", ThisPayment.PaymentValue);
            DB.AddParameter("@TicketId", ThisPayment.TicketId);
            //update the record
            DB.Execute("sproc_tblPayment_Update");
        }
    }
}