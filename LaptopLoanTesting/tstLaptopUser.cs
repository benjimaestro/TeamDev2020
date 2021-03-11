using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace LaptopLoanTesting
{
    [TestClass]
    public class tstLaptopUser
    {
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
        public void AddressPropertyExists()
        {
            //Tests whether the "address" property can be set
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            string testAddress = "18 GinStreet, Nottingham, NT1 111, United Kingdom";
            ALaptopUser.Address = testAddress;
            Assert.AreEqual(ALaptopUser.Address, testAddress);
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
            ALaptopUser.Email = testEmail;
            Assert.AreEqual(ALaptopUser.Email, testEmail);
        }
    }

}
