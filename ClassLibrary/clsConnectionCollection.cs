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
    }
}