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
    }
}