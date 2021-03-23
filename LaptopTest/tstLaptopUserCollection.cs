using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaptopTest
{
    [TestClass]
        public class tstLaptopUserCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                // create an instance of the class we want to create
                clsLaptopUserCollection AllLaptopUsers = new clsLaptopUserCollection();
                //test to see that it exists
                Assert.IsNotNull(AllLaptopUsers);
            }

        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create
            clsLaptopUserCollection AllLaptopUsers = new clsLaptopUserCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllLaptopUsers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptopUsers.Count, SomeCount);
        }
    }
   

}

