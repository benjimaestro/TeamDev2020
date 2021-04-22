using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TTrainCustomer
{
    [TestClass]
    public class tstClsCustomerCollection
    {
        [TestMethod]
        public void InstanceExists()
        {
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            Assert.IsNotNull(ACustomerCollection);
        }

        [TestMethod]
        public void CustomerCollectionListExists()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> testList = new List<clsCustomer>();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom",
                CustomerActive = true,
                CustomerCreatedAt = new DateTime(2001, 01, 17, 0, 0, 0),
                CustomerId = 15,
                DateOfBirth = "15/07/2000",
                Email = "HelloWorld@gmail.com",
                FirstName = "Adam",
                LastName = "Example"
            };
            //add the test object to the list
            testList.Add(ACustomer);
            //assign the list to the collection class
            ACustomerCollection.MyCustomers = testList;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerCollection.MyCustomers, testList);
        }

        [TestMethod]
        public void ThisCustomerPropertyExists()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom",
                CustomerActive = true,
                CustomerCreatedAt = new DateTime(2001, 01, 17, 0, 0, 0),
                CustomerId = 15,
                DateOfBirth = "15/07/2000",
                Email = "HelloWorld@gmail.com",
                FirstName = "Adam",
                LastName = "Example"
            };
            //assign the test object to the collection class
            ACustomerCollection.ThisCustomer = ACustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerCollection.ThisCustomer, ACustomer);
        }

        [TestMethod]
        public void ListAndCountExist()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> testList = new List<clsCustomer>();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom",
                CustomerActive = true,
                CustomerCreatedAt = new DateTime(2001, 01, 17, 0, 0, 0),
                CustomerId = 15,
                DateOfBirth = "15/07/2000",
                Email = "HelloWorld@gmail.com",
                FirstName = "Adam",
                LastName = "Example"
            };
            //add the test object to the list
            testList.Add(ACustomer);
            //assign the list to the collection class
            ACustomerCollection.MyCustomers = testList;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerCollection.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom",
                DateOfBirth = "15/07/2000",
                Email = "HelloWorld@gmail.com",
                FirstName = "Adam",
                LastName = "Example"
            };
            ACustomer.AccountPassword = ACustomer.GetHashPassword("testpassword1");
            //set ThisStaff to the test data
            ACustomerCollection.ThisCustomer = ACustomer;
            //store the primary key
            //add the record
            int primaryKey = ACustomerCollection.CreateAccount();
            //set the primary key of the test data
            ACustomer.CustomerId = primaryKey;
            //find the record
            ACustomerCollection.ThisCustomer.FindCustomer(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerCollection.ThisCustomer, ACustomer);
            //delete the recod not to fill the database with duplicate records
            ACustomerCollection.CloseAccount();
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom",
                DateOfBirth = "15/07/2000",
                Email = "HelloWorld@gmail.com",
                FirstName = "Adam",
                LastName = "Example"
            };
            ACustomer.AccountPassword = ACustomer.GetHashPassword("testpassword1");
            //set ThisStaff to the test data
            ACustomerCollection.ThisCustomer = ACustomer;
            //store the primary key
            //add the record
            int primaryKey = ACustomerCollection.CreateAccount();
            //set the primary key of the test data
            ACustomer.CustomerId = primaryKey;
            //find the record
            ACustomerCollection.ThisCustomer.FindCustomer(primaryKey);
            //delete the record
            ACustomerCollection.CloseAccount();
            //now find the record
            bool found = ACustomerCollection.ThisCustomer.FindCustomer(primaryKey);
            //the record must not be found
            Assert.IsFalse(found);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom",
                DateOfBirth = "15/07/2000",
                Email = "HelloWorld@gmail.com",
                FirstName = "Adam",
                LastName = "Example"
            };
            ACustomer.AccountPassword = ACustomer.GetHashPassword("testpassword1");
            //set ThisCustomer to the test data
            ACustomerCollection.ThisCustomer = ACustomer;
            //store the primary key
            //add the record
            int primaryKey = ACustomerCollection.CreateAccount();
            //set the primary key of the test data
            ACustomer.CustomerId = primaryKey;
            //assign all the properties
            ACustomer.Address = "19 NewStreet, Birmingham, BA1 111, United Kingdom";
            ACustomer.DateOfBirth = "15/07/2000";
            ACustomer.Email = "HelloWorld@gmail.com";
            ACustomer.FirstName = "Adam";
            ACustomer.LastName = "Example";
            ACustomer.AccountPassword = ACustomer.GetHashPassword("testpassword1");
            //assign the test object to the real object
            ACustomerCollection.ThisCustomer = ACustomer;
            //update data of the real object
            ACustomerCollection.ChangeDetails();
            //find the record
            ACustomerCollection.ThisCustomer.FindCustomer(primaryKey);
            //check if the data matches
            Assert.AreEqual(ACustomerCollection.ThisCustomer, ACustomer);
            //delete the record not to fill the database with duplicate records
            ACustomerCollection.CloseAccount();
        }

        [TestMethod]
        public void FilterCustomersMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomerCollection = new clsCustomerCollection();
            //a test object
            clsCustomer ACustomer = new clsCustomer
            {
                //assign all the properties
                DateOfBirth = "/07/",
                FirstName = "Adam",
                LastName = "DBTestExample"
            };
            //perform the filtering
            ACustomerCollection.MyCustomers = ACustomerCollection.FilterCustomers(ACustomer);
            //there should be exactly 1 result, check if it exist
            Assert.AreEqual(1, ACustomerCollection.MyCustomers.Count);
        }
    }
}
