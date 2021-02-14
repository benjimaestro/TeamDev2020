using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TTrainConnection
{
    [TestClass]
    public class tstClsConnectionCollection
    {
        [TestMethod]
        public void InstanceExists()
        {
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            Assert.IsNotNull(AConnectionCollection);
        }

        [TestMethod]
        public void ConnectionCollectionListExists()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //create some test data to assign to the property
            List<clsConnection> testList = new List<clsConnection>();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17, 16, 30, 0),
                ConnectionTicketLimit = 150
            };
            //add the test object to the list
            testList.Add(AConnection);
            //assign the list to the collection class
            AConnectionCollection.MyConnections = testList;
            //test to see that the two values are the same
            Assert.AreEqual(AConnectionCollection.MyConnections, testList);
        }

        [TestMethod]
        public void ThisCustomerPropertyExists()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17, 16, 30, 0),
                ConnectionTicketLimit = 150
            };
            //assign the test object to the collection class
            AConnectionCollection.ThisConnection = AConnection;
            //test to see that the two values are the same
            Assert.AreEqual(AConnectionCollection.ThisConnection, AConnection);
        }

        [TestMethod]
        public void ListAndCountExist()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //create some test data to assign to the property
            List<clsConnection> testList = new List<clsConnection>();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17, 16, 30, 0),
                ConnectionTicketLimit = 150
            };
            //add the test object to the list
            testList.Add(AConnection);
            //assign the list to the collection class
            AConnectionCollection.MyConnections = testList;
            //test to see that the two values are the same
            Assert.AreEqual(AConnectionCollection.Count, testList.Count);
        }
    }
}
