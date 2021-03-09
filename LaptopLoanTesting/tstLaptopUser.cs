using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace LaptopLoanTesting
{
    [TestClass]
    public class tstLaptopUser
    {
        [TestMethod]
        public void ClassInstanceOK()
        {
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            Assert.IsNotNull(ALaptopUser);
        }
        [TestMethod]
        public void IDPropertyOK()
        {
            clsLaptopUser LaptopUser = new clsLaptopUser();
            Int32 TestData = 3;
            LaptopUser.ID = TestData;
            Assert.AreEqual(LaptopUser.ID, TestData);
        }

    }
}
