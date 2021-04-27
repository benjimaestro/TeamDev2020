using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TTrainConnection
{
    [TestClass]
    public class tstClsConnection
    {

        string connectionStartStation = "Leicester";
        string connectionEndStation = "Birmingham";
        DateTime connectionDate = new DateTime(2021, 7, 17);
        int connectionTicketLimit = 150;

        [TestMethod]
        public void InstanceExists()
        {
            //Tests whether a class instance can be initialised
            clsConnection AConnection = new clsConnection();
            Assert.IsNotNull(AConnection);
        }

        [TestMethod]
        public void ConnectionActivePropertyExists()
        {
            //Tests whether the "ConnectionActive" property can be set
            clsConnection AConnection = new clsConnection();
            bool testData = true;
            AConnection.ConnectionActive = testData;
            Assert.AreEqual(AConnection.ConnectionActive, testData);
        }

        [TestMethod]
        public void ConnectionDatePropertyExists()
        {
            //Tests whether the "ConnectionDate" property can be set
            clsConnection AConnection = new clsConnection();
            DateTime testData = new DateTime(2021, 7, 17);
            AConnection.ConnectionDate = testData;
            Assert.AreEqual(AConnection.ConnectionDate, testData);
        }

        [TestMethod]
        public void ConnectionEndStationPropertyExists()
        {
            //Tests whether the "ConnectionEndStation" property can be set
            clsConnection AConnection = new clsConnection();
            string testData = "Birmingham New St.";
            AConnection.ConnectionEndStation = testData;
            Assert.AreEqual(AConnection.ConnectionEndStation, testData);
        }

        [TestMethod]
        public void ConnectionIdPropertyExists()
        {
            //Tests whether the "ConnectionId" property can be set
            clsConnection AConnection = new clsConnection();
            int testData = 15;
            AConnection.ConnectionId = testData;
            Assert.AreEqual(AConnection.ConnectionId, testData);
        }

        [TestMethod]
        public void ConnectionStartStationPropertyExists()
        {
            //Tests whether the "ConnectionStartStation" property can be set
            clsConnection AConnection = new clsConnection();
            string testData = "Leicester";
            AConnection.ConnectionStartStation = testData;
            Assert.AreEqual(AConnection.ConnectionStartStation, testData);
        }

        [TestMethod]
        public void ConnectionTicketLimitPropertyExists()
        {
            //Tests whether the "ConnectionTicketLimit" property can be set
            clsConnection AConnection = new clsConnection();
            int testData = 500;
            AConnection.ConnectionTicketLimit = testData;
            Assert.AreEqual(AConnection.ConnectionTicketLimit, testData);
        }

        [TestMethod]
        public void TicketTypeIdPropertyExists()
        {
            //Tests whether the "TicketTypeId" property can be set
            clsConnection AConnection = new clsConnection();
            int testData = 5;
            AConnection.TicketTypeId = testData;
            Assert.AreEqual(AConnection.TicketTypeId, testData);
        }

        [TestMethod]
        public void ConnectionTimePropertyExists()
        {
            //Tests whether the "ConnectionTime" property can be set
            clsConnection AConnection = new clsConnection();
            TimeSpan testData = TimeSpan.Parse("17:45");
            AConnection.ConnectionTime = testData;
            Assert.AreEqual(AConnection.ConnectionTime, testData);
        }

        [TestMethod]
        public void FindMethodExists()
        {
            //Put Id that exists to test this
            clsConnection AConnection = new clsConnection();
            //Put in test id saved in the db just for testing
            int connectionId = 204;
            //Invoke the method
            bool found = AConnection.FindConnection(connectionId);
            //Do the check
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestConnectionNotFound()
        {
            //Put Id that does not exist to test this
            clsConnection AConnection = new clsConnection();
            int connectionId = 1000;
            bool found = AConnection.FindConnection(connectionId);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void CustomerValidateMethodExists()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void MarkTicketPurchaseMethodExists()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //id of an existing connection
            int connId = 2;
            //get the amount of tickets remaining
            AConnection.FindConnection(connId);
            int ticketsRemaining = AConnection.ConnectionTicketLimit;
            //invoke the method
            AConnection.MarkTicketPurchase();
            //test to see that a ticket was purchased
            Assert.AreNotEqual(AConnection.ConnectionTicketLimit, ticketsRemaining);
        }

        [TestMethod]
        public void ConnectionStartStationMinLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = "A"; //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationMin()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = "AA"; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = "AAA"; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = connectionStartStation.PadRight(69, 'A'); ; //this should be ok
                                                                 //string variable to store any error message
                                                                 //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = connectionStartStation.PadRight(70, 'A'); ; //this should be ok
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = connectionStartStation.PadRight(71, 'A'); //this should fail
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationMid()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = connectionStartStation.PadRight(31, 'A'); ; //this should be ok
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionStartStationExtremeMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionStartStation = connectionStartStation.PadRight(500, 'j'); //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMinLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = "A"; //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMin()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = "AA"; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = "AAA"; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = connectionEndStation.PadRight(69, 'A'); ; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = connectionEndStation.PadRight(70, 'A'); ; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = connectionEndStation.PadRight(71, 'A'); //this should fail
                                                                               //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationMid()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = connectionEndStation.PadRight(31, 'A'); ; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionEndStationExtremeMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionEndStation = connectionEndStation.PadRight(500, 'j'); //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //string variable to store any error message
            DateTime connectionDate = DateTime.Now.Date.AddYears(-200); //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //string variable to store any error message
            DateTime connectionDate = Convert.ToDateTime("31/12/2019");
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionDateMin()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //string variable to store any error message
            DateTime connectionDate = Convert.ToDateTime("01/01/2020");
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //string variable to store any error message
            DateTime connectionDate = Convert.ToDateTime("02/01/2020");
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //string variable to store any error message
            DateTime connectionDate = DateTime.Now.Date.AddYears(200); //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMin()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 0; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMinPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 1; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMaxLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 499; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 500; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 501; //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMid()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 250; //this should be ok
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitExtremeMax()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = 125000; //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitMinLessOne()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = -1; //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ConnectionTicketLimitExtremeMin()
        {
            //create an instance of the class we want to create
            clsConnection AConnection = new clsConnection();
            //create some test data to pass to the method
            connectionTicketLimit = -100000; //this should fail
            //invoke the method
            string error = AConnection.ValidateConnection(
                connectionDate,
                connectionStartStation,
                connectionEndStation,
                connectionTicketLimit
            );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
    }
}
