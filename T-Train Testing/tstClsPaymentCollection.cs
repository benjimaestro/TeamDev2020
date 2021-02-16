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
                TicketId = 1,
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
                TicketId = 1,
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
                TicketId = 1,
                CustomerId = 1
            };
            //add the test object to the list
            testList.Add(APayment);
            //assign the list to the collection class
            APaymentCollection.MyPayments = testList;
            //test to see that the two values are the same
            Assert.AreEqual(APaymentCollection.Count, testList.Count);
        }
    }
}
