using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace LaptopLoanTesting
{
    [TestClass]
    public class tstClsLaptop
    {
        [TestMethod]
        public void ClassInstanceOK()
        {
            clsLaptop ALaptop = new clsLaptop();
            Assert.IsNotNull(ALaptop);
        }
    }
}
