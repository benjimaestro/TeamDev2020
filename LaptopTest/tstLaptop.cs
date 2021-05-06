using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace LaptopTest
{
    [TestClass]
    public class tstLaptop
    {
        [TestMethod]
        public void InstanceOK()
        {
         clsLaptop ALaptop = new clsLaptop();
        //test to see that it exists
        Assert.IsNotNull(ALaptop);
        }
        [TestMethod]
        public void LaptopPropertyOk()
        {
            //create an instance of the class we want to create
            clsLaptop Alaptop = new clsLaptop();
            //create spme test data to assign to the property
            string SomeLaptop = "MacBook";
            //assign the data to the property
            Alaptop.Laptop = SomeLaptop;
            //test to see that the two values are the same
            Assert.AreEqual(Alaptop.Laptop, SomeLaptop);
        }
        [TestMethod]
        public void LaptopNoOK()
        {
            //create an instance of the class we want to create
            clsLaptop ALaptop = new clsLaptop();
            //create some test data to assign to the property
            Int32 LaptopNo = 1;
            //assign the data property
            ALaptop.LaptopNo = LaptopNo;
            //test to see that the values are the same
            Assert.AreEqual(ALaptop.LaptopNo, LaptopNo);

        }
    }
}
