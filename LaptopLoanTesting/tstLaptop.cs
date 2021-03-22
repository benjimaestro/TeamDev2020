using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
namespace LaptopLoanTesting
{
    [TestClass]
    public class tstLaptop
    {
        [TestMethod]
        public void ClassInstanceOKk()
        {
            clsLaptop ALaptop = new clsLaptop();
            Assert.IsNotNull(ALaptop);
        }
    }
}
