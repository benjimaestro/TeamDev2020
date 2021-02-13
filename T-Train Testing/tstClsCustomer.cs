﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using T_Train_Classes;

namespace TTrainCustomer
{
    [TestClass]
    public class tstClsCustomer
    {

        //example test data
        private string customerAddress = "19 NewStreet, Birmingham, BA1 111, United Kingdom";
        private DateTime customerDateOfBirth = new DateTime(2000, 7, 15);
        private string customerEmail = "HelloWorld@gmail.com";
        private string customerFirstName = "Adam";
        private string customerLastName = "Example";

        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void AddressPropertyExists()
        {
            //Tests whether the "address" property can be set
            clsCustomer ACustomer = new clsCustomer();
            string testAddress = "19 NewStreet, Birmingham, BA1 111, United Kingdom";
            ACustomer.Address = testAddress;
            Assert.AreEqual(ACustomer.Address, testAddress);
        }

        [TestMethod]
        public void CustomerActivePropertyExists()
        {
            //Tests whether the "customerActive" property can be set
            clsCustomer ACustomer = new clsCustomer();
            bool testCustomerActive = true;
            ACustomer.CustomerActive = testCustomerActive;
            Assert.AreEqual(ACustomer.CustomerActive, testCustomerActive);
        }

        [TestMethod]
        public void CustomerCreatedAtPropertyExists()
        {
            //Tests whether the "customerCreatedAt" property can be set
            clsCustomer ACustomer = new clsCustomer();
            DateTime testCustomerCreatedAt = new DateTime(2001, 01, 17, 0, 0, 0);
            ACustomer.CustomerCreatedAt = testCustomerCreatedAt;
            Assert.AreEqual(ACustomer.CustomerCreatedAt, testCustomerCreatedAt);
        }

        [TestMethod]
        public void CustomerIdExists()
        {
            //Tests whether the "customerId" property can be set
            clsCustomer ACustomer = new clsCustomer();
            int testCustomerId = 15;
            ACustomer.CustomerId = testCustomerId;
            Assert.AreEqual(ACustomer.CustomerId, testCustomerId);
        }

        [TestMethod]
        public void CustomerDateOfBirthExists()
        {
            //Tests whether the "dateOfBirth" property can be set
            clsCustomer ACustomer = new clsCustomer();
            DateTime testDateOfBirth = new DateTime(2000, 7, 15);
            ACustomer.DateOfBirth = testDateOfBirth;
            Assert.AreEqual(ACustomer.DateOfBirth, testDateOfBirth);
        }

        [TestMethod]
        public void CustomerEmailExists()
        {
            //Tests whether the "email" property can be set
            clsCustomer ACustomer = new clsCustomer();
            string testEmail = "HelloWorld@gmail.com";
            ACustomer.Email = testEmail;
            Assert.AreEqual(ACustomer.Email, testEmail);
        }

        [TestMethod]
        public void CustomerFirstNameExists()
        {
            //Tests whether the "firstName" property can be set
            clsCustomer ACustomer = new clsCustomer();
            string testFirstName = "Adam";
            ACustomer.FirstName = testFirstName;
            Assert.AreEqual(ACustomer.FirstName, testFirstName);
        }

        [TestMethod]
        public void CustomerLastNameExists()
        {
            //Tests whether the "lastName" property can be set
            clsCustomer ACustomer = new clsCustomer();
            string testLastName = "Example";
            ACustomer.LastName = testLastName;
            Assert.AreEqual(ACustomer.LastName, testLastName);
        }

        [TestMethod]
        public void FindMethodExists()
        {
            //Put Id that exists to test this
            clsCustomer ACustomer = new clsCustomer();
            int staffId = 1;
            bool found = ACustomer.FindCustomer(staffId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestCustomerNotFound()
        {
            //Put Id that does not exist to test this
            clsCustomer ACustomer = new clsCustomer();
            int customerId = 8000;
            bool found = ACustomer.FindCustomer(customerId);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void CustomerValidateMethodExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = ""; //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = "A"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = "Jo"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = "JohnJohnJohnJohnJohnJohnJohnJ"; //this should be ok
                                                                 //string variable to store any error message
                                                                 //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = "JohnJohnJohnJohnJohnJohnJohnJo"; //this should be ok
                                                                  //string variable to store any error message
                                                                  //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = "JohnJohnJohnJohnJohnJohnJohnJoh"; //this should fail
                                                                   //string variable to store any error message
                                                                   //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = "JohnJohnJohnJoh"; //this should be ok
                                                   //string variable to store any error message
                                                   //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerFirstName = customerFirstName.PadRight(500, 'j'); //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to pass to the method
            customerLastName = ""; //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = "O"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = "Ro"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = "HathorneHathorneHathorneHathorneHathorneHathorneH"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = "HathorneHathorneHathorneHathorneHathorneHathorneHa"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = "HathorneHathorneHathorneHathorneHathorneHathorneHat"; //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = "HathorneHathorneHathorneH"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerLastName = customerLastName.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "B@g.c"; //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "B@g.cn"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "Jo@g.cn"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "SuperSuperSuperSuperSup@o2.pl"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "SuperSuperSuperSuperSupe@o2.pl"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "SuperSuperSuperSuperSuper@o2.pl"; //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = "SuperSuperSu@o2.pl"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerEmail = customerEmail.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            customerDateOfBirth = DateTime.Now.Date.AddYears(-200); //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            customerDateOfBirth = Convert.ToDateTime("31/12/1919");
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            customerDateOfBirth = Convert.ToDateTime("01/01/1920");
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            customerDateOfBirth = Convert.ToDateTime("02/01/1920");
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            customerDateOfBirth = DateTime.Now.Date.AddYears(200); //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "SaffSaffSa"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "SaffSaffSaf"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "SaffSaffSaff"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "Saffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsS"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "Saffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSa"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "Saffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaSaffron CrossroadsSaf"; //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = "Saffron CrossroadsSaffron CrossroadsSa"; //this should be ok
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            
            //create some test data to pass to the method
            customerAddress = customerAddress.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ACustomer.ValidateCustomer(
                customerAddress,
                customerDateOfBirth,
                customerEmail,
                customerFirstName,
                customerLastName
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
    }
}