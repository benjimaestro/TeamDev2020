using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace LaptopLoanTesting
{
    [TestClass]

    public class tstLaptopUser

    {
        public object ALaptopUser { get; private set; }

        //good test data
        //create some test data to pass to the method
        string LaptopUserAddress = "8 GinStreet, Nottingham, NT1 111, United Kingdom";
        string LaptopUserEmail = "Visualove@gmail.com";
        string LaptopUserFirstName = "Eddie";
        string LaptopUserLastName = "Example";
        string LaptopUserPassword = "visual123";
        string LaptopUserTelephoneNumber = "07835338736";

        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            Assert.IsNotNull(ALaptopUser);
        }
        [TestMethod]
        public void IDPropertyOK()
        {
            clsLaptopUser LaptopUser = new clsLaptopUser();
            Int32 TestData = 1;
            LaptopUser.ID = TestData;
            Assert.AreEqual(LaptopUser.ID, TestData);
        }


        [TestMethod]
        public void LaptopUserActivePropertyExists()
        {
            //Tests whether the "LaptopUserActive" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            bool testLaptopUserActive = true;
            ALaptopUser.LaptopUserActive = testLaptopUserActive;
            Assert.AreEqual(ALaptopUser.LaptopUserActive, testLaptopUserActive);
        }
        [TestMethod]
        public void LaptopUserEmailExists()
        {
            //Tests whether the "email" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testEmail = "Visualove@gmail.com";
            ALaptopUser.LaptopUserEmail = testEmail;
            Assert.AreEqual(ALaptopUser.LaptopUserEmail, testEmail);
        }

        [TestMethod]
        public void LaptopUserFirstNameExists()
        {
            //Tests whether the "firstName" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testFirstName = "Eddie";
            ALaptopUser.LaptopUserFirstName = testFirstName;
            Assert.AreEqual(ALaptopUser.LaptopUserFirstName, testFirstName);
        }
        [TestMethod]
        public void LaptopUserLastNameExists()
        {
            //Tests whether the "lastName" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testLastName = "Example";
            ALaptopUser.LaptopUserLastName = testLastName;
            Assert.AreEqual(ALaptopUser.LaptopUserLastName, testLastName);
        }
        //[TestMethod]
        public void FindMethodExists()
        {
            //Put Id that exists to test this
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            int staffID = 1;
            bool found = ALaptopUser.FindLaptopUser(staffID);
            Assert.IsTrue(found);//
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
            string testPassword = "visual123";
            ALaptopUser.LaptopTelephoneNumber = testPassword;
            Assert.AreEqual(ALaptopUser.LaptopTelephoneNumber, testPassword);
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
            string testTelephoneNumber = "07835338736";
            ALaptopUser.LaptopTelephoneNumber = testTelephoneNumber;
            Assert.AreEqual(ALaptopUser.LaptopTelephoneNumber, testTelephoneNumber);
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

    }
}
