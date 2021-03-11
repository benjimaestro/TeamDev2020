using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
namespace LaptopLoanTesting
{
    [TestClass]
    public class tstLaptop
    {
        [TestMethod]
        public void ClassInstanceOK()
        {
            clsLaptop ALaptop = new clsLaptop();
            Assert.IsNotNull(ALaptop);
        }
    }
}
