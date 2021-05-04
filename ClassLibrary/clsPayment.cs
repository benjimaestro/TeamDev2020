using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        private DateTime mPaymentEndDate;
        private DateTime mPaymentStartDate;
        private int mCustomerId;
        private int mPaymentId;
        private float mPaymentValue;

        public DateTime PaymentEndDate
        {
            get
            {
                return mPaymentEndDate;
            }
            set
            {
                mPaymentEndDate = value;
            }
        }
        public DateTime PaymentStartDate
        {
            get
            {
                return mPaymentStartDate;
            }
            set
            {
                mPaymentStartDate = value;
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
        public int PaymentId
        {
            get
            {
                return mPaymentId;
            }
            set
            {
                mPaymentId = value;
            }
        }
        public float PaymentValue
        {
            get
            {
                return mPaymentValue;
            }
            set
            {
                mPaymentValue = value;
            }
        }

        public bool FindPayment(int paymentId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@PaymentId", paymentId);
            //execute the procedure to get data
            DB.Execute("sproc_tblPayment_FilterByPaymentId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mPaymentId = paymentId;
                //common attributes
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mPaymentEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentEndDate"]);
                mPaymentStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentStartDate"]);
                mPaymentValue = float.Parse(Convert.ToString(DB.DataTable.Rows[0]["PaymentValue"]));
                //row was found so return true as "found" is positive, a payment was found
                return true;
            }
            else return false; //no row found means no payment with this id exists
        }

        public string ValidatePayment(DateTime paymentStartDate, DateTime paymentEndDate, float paymentValue)
        {
            string errorMessage = "";

            //Validation for payment value
            float testNumber;
            try
            {
                testNumber = paymentValue;

                if (paymentValue < 0.00f)
                {
                    errorMessage += "Payment value must be 0 or higher!" + "<br />";
                }
                else if (paymentValue > 1000.00f)
                {
                    errorMessage += "Payment value must be lower than or equal to 1000!" + "<br />";
                }
            }
            catch (Exception)
            {
                errorMessage += "Payment value must be a number!" + "<br />";
            }

            //Validation for payment start date
            try
            {
                DateTime DateTemp = Convert.ToDateTime(paymentStartDate);
                if (DateTemp < Convert.ToDateTime("01/01/2020"))
                {
                    errorMessage += "Payment start date entered before the business was established!" + "<br />";
                }
                else if (DateTemp > DateTime.Now)
                {
                    errorMessage += "Payments cannot be made in advance!" + "<br />";
                }
            }
            catch
            {
                errorMessage += "Payment start date is a required field!" + "<br />";
            }

            //Validation for payment end date
            //null value is a default value
            if(paymentEndDate != null)
            {
                try
                {
                    DateTime DateTemp = Convert.ToDateTime(paymentEndDate);
                    if (paymentEndDate < paymentStartDate)
                    {
                        errorMessage += "Payment end date entered before payment start date!" + "<br />";
                    }
                    else if (paymentEndDate > DateTime.Now.AddMonths(1))
                    {
                        errorMessage += "Payment ended a month after it was started!" + "<br />";
                    }
                }
                catch
                {
                    errorMessage += "Payment end date is not a valid date!" + "<br />";
                }

            }

            return errorMessage;
        }
    }
}