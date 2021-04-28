using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TTrainTicketType
{

    [TestClass]
    public class tstClsTicketType
    {

        string ticketTypeName = "Summer Holiday Ticket";
        float ticketTypePrice = 12.25f;

        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsTicketType ATicketType = new clsTicketType();
            Assert.IsNotNull(ATicketType);
        }

        [TestMethod]
        public void TicketTypeIdPropertyExists()
        {
            //Tests whether the "TicketTypeId" property can be set
            clsTicketType ATicketType = new clsTicketType();
            int testId = 10;
            ATicketType.TicketTypeId = testId;
            Assert.AreEqual(ATicketType.TicketTypeId, testId);
        }

        [TestMethod]
        public void TicketTypeActivePropertyExists()
        {
            //Tests whether the "TicketTypeActive" property can be set
            clsTicketType ATicketType = new clsTicketType();
            bool ticketTypeActive = true;
            ATicketType.TicketTypeActive = ticketTypeActive;
            Assert.AreEqual(ATicketType.TicketTypeActive, ticketTypeActive);
        }

        [TestMethod]
        public void TicketTypeNamePropertyExists()
        {
            //Tests whether the "TicketTypeName" property can be set
            clsTicketType ATicketType = new clsTicketType();
            string testName = "Summer Special 2021";
            ATicketType.TicketTypeName = testName;
            Assert.AreEqual(ATicketType.TicketTypeName, testName);
        }

        [TestMethod]
        public void TicketTypePricePropertyExists()
        {
            //Tests whether the "TicketTypePrice" property can be set
            clsTicketType ATicketType = new clsTicketType();
            float testPrice = 10.25f;
            ATicketType.TicketTypePrice = testPrice;
            Assert.AreEqual(ATicketType.TicketTypePrice, testPrice);
        }

        [TestMethod]
        public void TicketTypeRefundablePropertyExists()
        {
            //Tests whether the "TicketTypeRefundable" property can be set
            clsTicketType ATicketType = new clsTicketType();
            bool testRefundable = false;
            ATicketType.TicketTypeRefundable = testRefundable;
            Assert.AreEqual(ATicketType.TicketTypeRefundable, testRefundable);
        }

        [TestMethod]
        public void FindMethodExists()
        {
            //Put Id that exists to test this
            clsTicketType ATicketType = new clsTicketType();
            int ticketTypeId = 2;
            bool found = ATicketType.FindTicketType(ticketTypeId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestTicketTypeNotFound()
        {
            //Put Id that does not exist to test this
            clsTicketType ATicketType = new clsTicketType();
            int ticketTypeId = 8000;
            bool found = ATicketType.FindTicketType(ticketTypeId);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ValidateTicketTypeMethodExists()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMin()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "Tick"; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "Ticke"; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "JohnJohnJohnJohnJohnJohnJohnJohnJohnJoh"; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMax()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "JohnJohnJohnJohnJohnJohnJohnJohnJohnJohn"; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "JohnJohnJohnJohnJohnJohnJohnJohnJohnJohnJ"; //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMid()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "JohnJohnJohnJohnJohn"; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = ticketTypeName.PadRight(500, 'j'); //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TicketTypeNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypeName = "Tic"; //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMin()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 0.00f; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 0.01f; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 999.99f; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMax()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 1000.00f; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 1000.01f; //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMid()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 500.00f; //this should be ok
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = 125000.00f; //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = -0.01f; //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TicketTypePriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsTicketType ATicketType = new clsTicketType();
            //create some test data to pass to the method
            ticketTypePrice = -10000.00f; //this should fail
            //invoke the method
            string error = ATicketType.ValidateTicketType(
                ticketTypeName,
                ticketTypePrice
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
    }
}
