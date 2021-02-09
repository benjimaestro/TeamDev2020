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
    }
}