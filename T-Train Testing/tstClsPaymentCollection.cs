using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TTrainPayment
{
    [TestClass]
    public class tstClsPaymentCollection
    {
        [TestMethod]
        public void InstanceExists()
        {
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            Assert.IsNotNull(APaymentCollection);
        }

        [TestMethod]
        public void PaymentCollectionListExists()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //create some test data to assign to the property
            List<clsPayment> testList = new List<clsPayment>();
            //a test object
            clsPayment APayment = new clsPayment
            {
                //assign all the properties
                PaymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0),
                PaymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0),
                PaymentValue = 12.25f,
                PaymentId = 1,
                CustomerId = 1
            };
            //add the test object to the list
            testList.Add(APayment);
            //assign the list to the collection class
            APaymentCollection.MyPayments = testList;
            //test to see that the two values are the same
            Assert.AreEqual(APaymentCollection.MyPayments, testList);
        }

        [TestMethod]
        public void ThisPaymentPropertyExists()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //a test object
            clsPayment APayment = new clsPayment
            {
                //assign all the properties
                PaymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0),
                PaymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0),
                PaymentValue = 12.25f,
                PaymentId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            APaymentCollection.ThisPayment = APayment;
            //test to see that the two values are the same
            Assert.AreEqual(APaymentCollection.ThisPayment, APayment);
        }

        [TestMethod]
        public void ListAndCountExist()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //create some test data to assign to the property
            List<clsPayment> testList = new List<clsPayment>();
            //a test object
            clsPayment APayment = new clsPayment
            {
                //assign all the properties
                PaymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0),
                PaymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0),
                PaymentValue = 12.25f,
                PaymentId = 1,
                CustomerId = 1
            };
            //add the test object to the list
            testList.Add(APayment);
            //assign the list to the collection class
            APaymentCollection.MyPayments = testList;
            //test to see that the two values are the same
            Assert.AreEqual(APaymentCollection.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodExists()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //a test object
            clsPayment APayment = new clsPayment
            {
                //assign all the properties
                PaymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0),
                PaymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0),
                PaymentValue = 12.25f,
                PaymentId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            APaymentCollection.ThisPayment = APayment;
            //store the primary key
            //add the record
            int primaryKey = APaymentCollection.AddPayment();
            //set the primary key of the test data
            APayment.PaymentId = primaryKey;
            //find the record
            APaymentCollection.ThisPayment.FindPayment(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(APaymentCollection.ThisPayment, APayment);
            //delete the recod not to fill the database with duplicate records
            APaymentCollection.DeletePayment();
        }

        [TestMethod]

        public void DeleteMethodExists()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //a test object
            clsPayment APayment = new clsPayment
            {
                //assign all the properties
                PaymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0),
                PaymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0),
                PaymentValue = 12.25f,
                PaymentId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            APaymentCollection.ThisPayment = APayment;
            //store the primary key
            //add the record
            int primaryKey = APaymentCollection.AddPayment();
            //set the primary key of the test data
            APayment.PaymentId = primaryKey;
            //find the record
            APaymentCollection.ThisPayment.FindPayment(primaryKey);
            //delete the record
            APaymentCollection.DeletePayment();
            //now find the record
            bool found = APaymentCollection.ThisPayment.FindPayment(primaryKey);
            //the record must not be found
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //a test object
            clsPayment APayment = new clsPayment
            {
                //assign all the properties
                PaymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0),
                PaymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0),
                PaymentValue = 12.25f,
                PaymentId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            APaymentCollection.ThisPayment = APayment;
            //store the primary key
            //add the record
            int primaryKey = APaymentCollection.AddPayment();
            //set the primary key of the test data
            APayment.PaymentId = primaryKey;
            //assign all the properties
            APayment.PaymentStartDate = new DateTime(2021, 2, 11, 16, 30, 0);
            APayment.PaymentEndDate = new DateTime(2021, 2, 11, 16, 35, 0);
            APayment.PaymentValue = 12.25f;
            APayment.CustomerId = 2;
            //assign the test object to the real object
            APaymentCollection.ThisPayment = APayment;
            //update data of the real object
            APaymentCollection.UpdatePayment();
            //find the record
            APaymentCollection.ThisPayment.FindPayment(primaryKey);
            //check if the data matches
            Assert.AreEqual(APaymentCollection.ThisPayment, APayment);
            //delete the record not to fill the database with duplicate records
            APaymentCollection.DeletePayment();
        }

        [TestMethod]
        public void GetUserPaymentsMethodExists()
        {
            //create an instance of the class we want to create
            clsPaymentCollection APaymentCollection = new clsPaymentCollection();
            //set test user id which exists just for the testing
            int customerId = 257;
            //invoke the method
            APaymentCollection.MyPayments = APaymentCollection.GetUserPayments(customerId);
            //check if any payments were found
            bool found = APaymentCollection.Count > 0;
            //if they were found, that's a pass
            Assert.AreEqual(true, found);
        }
    }
}
