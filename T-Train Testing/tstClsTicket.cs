using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TTrainTicket
{
    [TestClass]
    public class tstClsTicket
    {
        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsTicket ATicket = new clsTicket();
            Assert.IsNotNull(ATicket);
        }

        [TestMethod]
        public void TicketIdExists()
        {
            //Tests whether the "TicketId" property can be set
            clsTicket ATicket = new clsTicket();
            int testTicketId = 15;
            ATicket.TicketId = testTicketId;
            Assert.AreEqual(ATicket.TicketId, testTicketId);
        }

        [TestMethod]
        public void ConnectionIdExists()
        {
            //Tests whether the "ConnectionId" property can be set
            clsTicket ATicket = new clsTicket();
            int testConnectionId = 15;
            ATicket.ConnectionId = testConnectionId;
            Assert.AreEqual(ATicket.ConnectionId, testConnectionId);
        }

        [TestMethod]
        public void CustomerIdExists()
        {
            //Tests whether the "CustomerId" property can be set
            clsTicket ATicket = new clsTicket();
            int testCustomerId = 15;
            ATicket.CustomerId = testCustomerId;
            Assert.AreEqual(ATicket.CustomerId, testCustomerId);
        }

        [TestMethod]
        public void TicketTypeIdExists()
        {
            //Tests whether the "TicketTypeId" property can be set
            clsTicket ATicket = new clsTicket();
            int testTicketTypeId = 15;
            ATicket.TicketTypeId = testTicketTypeId;
            Assert.AreEqual(ATicket.TicketTypeId, testTicketTypeId);
        }

        [TestMethod]
        public void TicketActiveExists()
        {
            //Tests whether the "TicketActive" property can be set
            clsTicket ATicket = new clsTicket();
            bool testTicketActive = true;
            ATicket.TicketActive = testTicketActive;
            Assert.AreEqual(ATicket.TicketActive, testTicketActive);
        }

        [TestMethod]
        public void FindTicketExists()
        {
            //Put Id that exists to test this
            clsTicket ATicket = new clsTicket();
            int ticketId = 1;
            bool found = ATicket.FindTicket(ticketId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestTicketNotFound()
        {
            //Put Id that does not exist to test this
            clsTicket ATicket = new clsTicket();
            int ticketId = 8000;
            bool found = ATicket.FindTicket(ticketId);
            Assert.IsFalse(found);
        }
    }
}
