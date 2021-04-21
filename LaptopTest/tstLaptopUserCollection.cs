using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            Int32 SomeCount = 2;
            //assign the data to the property
            AllLaptopUsers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptopUsers.Count, SomeCount);
        }
        [TestMethod]
        public void AllLaptopUsersOK()
        {
            // create an instance of the class we want to create
            clsLaptopUserCollection LaptopUsers = new clsLaptopUserCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsLaptopUser> TestList = new List<clsLaptopUser>();
            //add an itemm to the list
            //create the item of test data
            clsLaptopUser TestItem = new clsLaptopUser();
            //set its properties
            TestItem.LaptopUserNo = 1;
            TestItem.LaptopUser = "Eddie Rose";
            //add the item tot the test list
            TestList.Add(TestItem);
            //assign the data to the property
            LaptopUsers.AllLaptopUsers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(LaptopUsers.AllLaptopUsers, TestList);
        }
        [TestMethod]
        public void CountMatchesList()
        {
            // create an instance of the class we want to create
            clsLaptopUserCollection LaptopUsers = new clsLaptopUserCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsLaptopUser> TestList = new List<clsLaptopUser>();
            //add an itemm to the list
            //create the item of test data
            clsLaptopUser TestItem = new clsLaptopUser();
            //set its properties
            TestItem.LaptopUserNo = 1;
            TestItem.LaptopUser = "Eddie Rose";
            //add the item tot the test list
            TestList.Add(TestItem);
            //assign the data to the property
            LaptopUsers.AllLaptopUsers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(LaptopUsers.Count, TestList.Count);

        }
        [TestMethod]
        public void TwoLaptopUsersPresent()
        {
            //create an instance of the class we want to create 
            clsLaptopUserCollection LaptopUsers = new clsLaptopUserCollection();
            //test to see that the two values are the same
            Assert.AreEqual(LaptopUsers.Count, 2);
        }
    }
   

}

