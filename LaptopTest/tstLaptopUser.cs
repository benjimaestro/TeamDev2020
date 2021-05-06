using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LaptopLoanTest
{
    [TestClass]

    public class tstLaptopUser

    {
        

        //good test data
        //create some test data to pass to the method
        string LaptopUserAddress = "8 GinStreet, Nottingham, NT1 111, United Kingdom";
        string LaptopUserEmail = "Visualove@gmail.com";
        string LaptopUserFirstName = "Eddie";
        string LaptopUserLastName = "Rose";
        string LaptopUserPassword = "visual1234";
        string LaptopUserTelephoneNumber = "078353387368";
        public bool LaptopStaff = false;
        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            Assert.IsNotNull(ALaptopUser);
        }
        [TestMethod]
        public void LaptopStaffPropertyExists()
        {
            //Tests whether the "IsStaff" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            bool testLaptopStaff = false;
            ALaptopUser.LaptopStaff = false;
            Assert.AreEqual(ALaptopUser.LaptopStaff, testLaptopStaff);
        }
        [TestMethod]
        public void LaptopUserIDPropertyOK()
        {
            clsLaptopUser LaptopUser = new clsLaptopUser();
            Int32 TestData = 1;
            LaptopUser.LaptopUserId = TestData;
            Assert.AreEqual(LaptopUser.LaptopUserId, TestData);
        }
 

        [TestMethod]
        public void LaptopUserActivePropertyExists()
        {
            //Tests whether the "LaptopUserActive" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            Boolean testData = true;
            ALaptopUser.LaptopUserActive = testData;
            Assert.AreEqual(ALaptopUser.LaptopUserActive, testData);
        }
        [TestMethod]
        public void LaptopUserEmailExists()
        {
            //Tests whether the "email" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testData = "Visualove@gmail.com";
            ALaptopUser.LaptopUserEmail = testData;
            Assert.AreEqual(ALaptopUser.LaptopUserEmail, testData);
        }
        [TestMethod]
        public void UpdateLaptopUserPasswordExists()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //declare a test password and hash it
            string testLaptopUserPassword = "treysongz12";
            testLaptopUserPassword = ALaptopUser.GetHashPassword(testLaptopUserPassword);
            //use the admin test user it to try and update
            ALaptopUser.LaptopUserId = 2001;
            //call the method
            ALaptopUser.UpdateLaptopUserPassword(testLaptopUserPassword);
            //now fetch the customer details
            _ = ALaptopUser.FindLaptopUserId(ALaptopUser.LaptopUserId);
            //compare the two passwords
            Assert.AreEqual(ALaptopUser.LaptopUserPassword, testLaptopUserPassword);
        }

        [TestMethod]
        public void LaptopUserFirstNameExists()
        {
            //Tests whether the "firstName" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testData = "Eddie";
            ALaptopUser.LaptopUserFirstName = testData;
            Assert.AreEqual(ALaptopUser.LaptopUserFirstName, testData);
        }
        [TestMethod]
        public void LaptopUserLastNameExists()
        {
            //Tests whether the "lastName" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testData = "Rose";
            ALaptopUser.LaptopUserLastName = testData;
            Assert.AreEqual(ALaptopUser.LaptopUserLastName, testData);
        }
       
        [TestMethod]
        public void FindMethodExistss()
        {
            //Put Id that exists to test this
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            Boolean Found = false;
            Int32 LaptopUserId = 21;
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestLaptopUserIdFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserId != 21) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestLaptopUserAddressFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserAddress != "Test Address") 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLaptopUserEmailFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserEmail != "Test@email.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLaptopUserFirstNameFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserFirstName != "Test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLaptopUserLastNameFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserLastName != "Testing")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLaptopUserPasswordFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserPassword != "testpw")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLaptopUserTelephoneNumberFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the LaptopUserId
            if (ALaptopUser.LaptopUserTelephoneNumber != "07777777777")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        

        [TestMethod]
        public void TestLaptopUserCreatedAtFound()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopUserId = 21;
            //invoke the method
            Found = ALaptopUser.FindLaptopUserId(LaptopUserId);
            //check the property
            if (ALaptopUser.LaptopUserCreatedAt != Convert.ToDateTime("01/05/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //invoke the method
            string Error = "";
            //invoke the method
            Error = ALaptopUser.Valid(LaptopUserAddress, LaptopUserEmail, LaptopUserFirstName, LaptopUserLastName, LaptopUserPassword, LaptopUserTelephoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordExists()
        {
            //Tests whether the "Password" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testData = "visual123";
            ALaptopUser.LaptopUserPassword = testData;
            Assert.AreEqual(ALaptopUser.LaptopUserPassword, testData);
        }

        [TestMethod]
        public void LaptopUserFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = ""; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LaptopUserFirstNameMin()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = "E"; //this should PASS
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = "ED"; //this should BE OK
                                        //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberExists()
        {
            //Tests whether the "Password" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testData = "07835338736";
            ALaptopUser.LaptopUserTelephoneNumber = testData;
            Assert.AreEqual(ALaptopUser.LaptopUserTelephoneNumber, testData);
        }
        [TestMethod]
        public void LaptopUserFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = "EDDIEDSEIPOND"; //this should BE OK
                                                   //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LaptopUserFirstNameMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = "EDDIEDSEIPONDE"; //this should BE OK
                                                   //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = "EDDIEDSEIPONDEE"; //this should BE OK
                                                    //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserFirstNameMid()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserFirstName = "EDDIEDS"; //this should BE OK
                                                    //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //string variable to store any error message

            //create some test data to pass to the method
            LaptopUserFirstName = LaptopUserFirstName.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LaptopUserLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = ""; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserLastNameMin()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "P"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "PO"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "PONPRSLTREIMQ"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserLastNameMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "PONPRSLTREIMQJ"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "PONPRSLTREIMQJF"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserLastNameMid()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "PONPRSL"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //string variable to store any error message

            //create some test data to pass to the method
            LaptopUserLastName = LaptopUserLastName.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = ""; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMin()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = "e@hotmail.com"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = "ed@hotmail.com"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = "eddieeddieeddieed@hotmail.com"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = "eddieeddieeddieedi@hotmail.com"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = "eddieeddieeddieedie@hotmail.com"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserEmailMid()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserEmail = "eddieeddieedd@hotmail.com"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LaptopUserEmaileExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //string variable to store any error message

            //create some test data to pass to the method
            LaptopUserEmail = LaptopUserEmail.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserLastName = "123Nottigha"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressMin()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserAddress = "123Nottigham"; //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserAddress = "123Nottigham2"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserAddress = "12312Nottigham8SGinStreet,Nottingham,NT1111,UnitedKingdom8GinStreet,Nottingham,NT1111,UnitedKingdom"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
       // [TestMethod]
        public void LaptopUserNotFound()
        {
            //Put Id that does not exist to test this
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            int LaptopUserId = 8000;
            bool found = ALaptopUser.FindLaptopUser(LaptopUserId);
            Assert.IsFalse(found);
        }
        [TestMethod]
        public void LaptopUserAddressMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserAddress = "123123Nottigham8SGinStreet,Nottingham,NT1111,UnitedKingdom8GinStreet,Nottingham,NT1111,UnitedKingdom"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserAddress = "123123Nottigham8SGinStreet,Nottingham,NT1111,UnitedKingdom8GinStreet,Nottingham,NT1111,UnitedKingdoms"; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressMid()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserAddress = "1Nottingham,United Kingdom "; //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //string variable to store any error message

            //create some test data to pass to the method
            LaptopUserAddress = LaptopUserAddress.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "0783533873";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberdMin()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "078353387368";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "0783533873689";  //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "0783533873689";  //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "07835338736897";  //this should pass
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "078353387368978";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberMid()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserTelephoneNumber = "0783533";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserTelephoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //string variable to store any error message

            //create some test data to pass to the method
            LaptopUserTelephoneNumber = LaptopUserTelephoneNumber.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserPassword = "visual123";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordMin()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserPassword = "visual1234";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserPassword = "visual12345";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserPassword = "visualweb1234";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserPassword = "visualweb123456";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordMid()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to pass to the method
            LaptopUserPassword = "visual1";  //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //string variable to store any error message

            //create some test data to pass to the method
            LaptopUserPassword = LaptopUserPassword.PadRight(500, 'H'); //this should fail
            //invoke the method
            string error = ALaptopUser.ValidateLaptopUser(
                LaptopUserAddress,
                LaptopUserPassword,
                LaptopUserEmail,
                LaptopUserFirstName,
                LaptopUserLastName,
                LaptopUserTelephoneNumber
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void LaptopUserAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //create some test data to assign to the property
            string TestData = "8 GinStreet, Nottingham, NT1 111, United Kingdom";
            //assign the data to the property
            ALaptopUser.LaptopUserAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ALaptopUser.LaptopUserAddress, TestData);
        }
        [TestMethod]
        public void LaptopUserCreatedAtPropertyExists()
        {
            //Tests whether the "LaptopUserCreatedAt" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            DateTime testLaptopUserCreatedAt = new DateTime(2001, 01, 17, 0, 0, 0);
            ALaptopUser.LaptopUserCreatedAt = testLaptopUserCreatedAt;
            Assert.AreEqual(ALaptopUser.LaptopUserCreatedAt, testLaptopUserCreatedAt);
        }
        

    }
}

