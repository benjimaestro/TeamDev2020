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
            //update the record
            DB.Execute("sproc_tblPayment_Update");
        }

        public List<clsPayment> GetUserPayments(int customerId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter
            DB.AddParameter("@CustomerId", customerId);
            //run the procedure
            DB.Execute("sproc_tblPayment_SelectAllCustomerPayments");
            //create an empty list to store payments
            List<clsPayment> paymentsFound = new List<clsPayment>();
            //if there were rows returned, get data from them
            for (int i = 0; i < DB.Count; ++i)
            {
                //get details of the payment
                clsPayment FoundPayment = new clsPayment
                {
                    //primary key
                    PaymentId = Convert.ToInt32(DB.DataTable.Rows[i]["PaymentId"]),
                    //common attributes
                    CustomerId = customerId,
                    PaymentEndDate = Convert.ToDateTime(DB.DataTable.Rows[i]["PaymentEndDate"]),
                    PaymentStartDate = Convert.ToDateTime(DB.DataTable.Rows[i]["PaymentStartDate"]),
                    PaymentValue = float.Parse(Convert.ToString(DB.DataTable.Rows[i]["PaymentValue"]))
                };

                // save a found connection to an array
                paymentsFound.Add(FoundPayment);
            }
                
            //return the array with all payments that were found
            return paymentsFound;
        }
    }
}