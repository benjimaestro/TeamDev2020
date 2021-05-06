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
        public void AllLaptopUsersExists()
        {
            //create an instance of the class we want to create
            clsLaptopUserCollection AllLaptopUsers = new clsLaptopUserCollection();
            //create some test data to assign to the property
            List<clsLaptopUser> testList = new List<clsLaptopUser>();
            //a test object
            clsLaptopUser ALaptopUser = new clsLaptopUser
            {

                LaptopUserAddress = "8 GinStreet, Nottingham, NT1 111, United Kingdom",
                LaptopUserEmail = "Visualove@gmail.com",
                LaptopUserFirstName = "Eddie",
                LaptopUserLastName = "Example",
                LaptopUserPassword = "visual1234",
                LaptopUserTelephoneNumber = "078353387368",
                LaptopStaff = false

            };
            //assign the test object to the collection class
            AllLaptopUsers.ThisLaptopUser = ALaptopUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptopUsers.ThisLaptopUser, ALaptopUser);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsLaptopUserCollection AllLaptopUsers = new clsLaptopUserCollection();
            clsLaptopUser ALaptopUser = new clsLaptopUser
            {
                //ASSIGN PROPERTIES
                LaptopUserAddress = "8 GinStreet, Nottingham, NT1 111, United Kingdom",
                LaptopUserEmail = "Visualove@gmail.com",
                LaptopUserFirstName = "Eddie",
                LaptopUserLastName = "Rose",
                LaptopUserPassword = "visual1234",
                LaptopUserTelephoneNumber = "078353387368",
            };
            ALaptopUser.LaptopUserPassword = ALaptopUser.GetHashPassword("testpassword2");
            //set LaptopStaff to test data
            AllLaptopUsers.ThisLaptopUser = ALaptopUser;
            //store the primary key
            //add the record
            int primaryKey = AllLaptopUsers.CreateAccount();
            //set the primary key of the test data
            ALaptopUser.LaptopUserId = (primaryKey);
            //find the record
            AllLaptopUsers.ThisLaptopUser.FindLaptopUserId(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptopUsers.ThisLaptopUser, ALaptopUser);
            //delete record so theres no redundant records
            AllLaptopUsers.CloseAccount();
        }

        [TestMethod]
        public void ListAndCountExist()
        {
            //create an instance of the class we want to create
            clsLaptopUserCollection AllLaptopUsers = new clsLaptopUserCollection();
            //create some test data to assign to the property
            List<clsLaptopUser> testList = new List<clsLaptopUser>();
            //a test object
            clsLaptopUser ALaptopUser = new clsLaptopUser
            {
                LaptopUserAddress = "8 GinStreet, Nottingham, NT1 111, United Kingdom",
                LaptopUserEmail = "Visualove@gmail.com",
                LaptopUserFirstName = "Eddie",
                LaptopUserLastName = "Example",
                LaptopUserPassword = "visual1234",
                LaptopUserTelephoneNumber = "078353387368",
                LaptopStaff = false
            };
            //add the test object to the list
            testList.Add(ALaptopUser);
            //assign the list to the collection class
            AllLaptopUsers.MAllLaptopUsers = testList;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptopUsers.Count, testList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create
            clsLaptopUserCollection AllLaptopUsers = new clsLaptopUserCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 10;
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
            TestItem.LaptopUserId = 1;
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
            TestItem.LaptopUserId = 1;
            TestItem.LaptopUser = "Eddie Rose";
            //add the item tot the test list
            TestList.Add(TestItem);
            //assign the data to the property
            LaptopUsers.AllLaptopUsers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(LaptopUsers.Count, TestList.Count);

        }




        //[TestMethod]
        public void TwoLaptopUsersPresent()
        {
            //create an instance of the class we want to create 
            clsLaptopUserCollection LaptopUsers = new clsLaptopUserCollection();
            //test to see that the two values are the same
            Assert.AreEqual(LaptopUsers.Count, 2);
        }


    }     
   

}

