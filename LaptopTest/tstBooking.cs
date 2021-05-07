using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace LaptopTest
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLaptop ABooking = new clsLaptop();
            //test to see that it exists
            Assert.IsNotNull(ABooking);
        }
        [TestMethod]
        public void BookingPropertyOk()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //create spme test data to assign to the property
            string SomeBooking = "Booking1";
            //assign the data to the property
            ABooking.Booking = SomeBooking;
            //test to see that the two values are the same
            Assert.AreEqual(ABooking.Booking, SomeBooking);
        }
    }
    
}
