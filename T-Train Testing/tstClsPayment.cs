using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TTrainPayment
{
    [TestClass]
    public class tstClsPayment
    {

        DateTime paymentStartDate = new DateTime(2021, 2, 10, 16, 30, 0);
        DateTime paymentEndDate = new DateTime(2021, 2, 10, 16, 35, 0);
        float paymentValue = 12.25f;

        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsPayment APayment = new clsPayment();
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void PaymentEndDatePropertyExists()
        {
            //Tests whether the "PaymentStartDate" property can be set
            clsPayment APayment = new clsPayment();
            DateTime testDate = new DateTime(2021, 7, 17, 16, 30, 0);
            APayment.PaymentEndDate = testDate;
            Assert.AreEqual(APayment.PaymentEndDate, testDate);
        }

        [TestMethod]
        public void PaymentStartDatePropertyExists()
        {
            //Tests whether the "PaymentEndDate" property can be set
            clsPayment APayment = new clsPayment();
            DateTime testDate = new DateTime(2021, 7, 17, 16, 35, 0);
            APayment.PaymentStartDate = testDate;
            Assert.AreEqual(APayment.PaymentStartDate, testDate);
        }

        [TestMethod]
        public void CustomerIdExists()
        {
            //Tests whether the "CustomerId" property can be set
            clsPayment APayment = new clsPayment();
            int testCustomerId = 15;
            APayment.CustomerId = testCustomerId;
            Assert.AreEqual(APayment.CustomerId, testCustomerId);
        }

        [TestMethod]
        public void PaymentIdExists()
        {
            //Tests whether the "PaymentId" property can be set
            clsPayment APayment = new clsPayment();
            int testPaymentId = 15;
            APayment.PaymentId = testPaymentId;
            Assert.AreEqual(APayment.PaymentId, testPaymentId);
        }

        [TestMethod]
        public void PaymentValuePropertyExists()
        {
            //Tests whether the "PaymentValue" property can be set
            clsPayment APayment = new clsPayment();
            float testPrice = 10.25f;
            APayment.PaymentValue = testPrice;
            Assert.AreEqual(APayment.PaymentValue, testPrice);
        }

        [TestMethod]
        public void FindPaymentExists()
        {
            //Put Id that exists to test this
            clsPayment APayment = new clsPayment();
            int paymentId = 273;
            bool found = APayment.FindPayment(paymentId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestPaymentNotFound()
        {
            //Put Id that does not exist to test this
            clsPayment APayment = new clsPayment();
            int paymentId = 8000;
            bool found = APayment.FindPayment(paymentId);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ValidatePaymentMethodExists()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 0.00f; //this should be ok
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 0.01f; //this should be ok
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 999.99f; //this should be ok
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 1000.00f; //this should be ok
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 1000.01f; //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMid()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 500.00f; //this should be ok
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = 125000.00f; //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = -0.01f; //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentValueExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to pass to the method
            paymentValue = -10000.00f; //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentStartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentStartDate = DateTime.Now.Date.AddYears(-200); //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentStartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentStartDate = Convert.ToDateTime("31/12/2019");
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentStartDateMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentStartDate = Convert.ToDateTime("01/01/2020");
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentStartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentStartDate = Convert.ToDateTime("02/01/2020");
            //invoke the method
            string error = APayment.ValidatePayment(
                 paymentStartDate,
                 paymentEndDate,
                 paymentValue
             );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentStartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentStartDate = DateTime.Now.Date.AddYears(200); //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentEndDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentEndDate = DateTime.Now.Date.AddYears(-200); //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentEndDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentEndDate = paymentStartDate.AddMilliseconds(-1);
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentEndDateMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentEndDate = paymentStartDate;
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentEndDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentEndDate = paymentStartDate.AddMilliseconds(1);
            //invoke the method
            string error = APayment.ValidatePayment(
                 paymentStartDate,
                 paymentEndDate,
                 paymentValue
             );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentEndDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            DateTime paymentEndDate = DateTime.Now.Date.AddYears(200); //this should fail
            //invoke the method
            string error = APayment.ValidatePayment(
                paymentStartDate,
                paymentEndDate,
                paymentValue
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
    }

    
}
