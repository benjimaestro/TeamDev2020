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
                ConnectionDate = new DateTime(2021, 7, 17),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("17:45")
            };
            //add the test object to the list
            testList.Add(AConnection);
            //assign the list to the collection class
            AConnectionCollection.MyConnections = testList;
            //test to see that the two values are the same
            Assert.AreEqual(AConnectionCollection.MyConnections, testList);
        }

        [TestMethod]
        public void ThisConnectionPropertyExists()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("17:45")
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
                ConnectionDate = new DateTime(2021, 7, 17),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("17:45")
            };
            //add the test object to the list
            testList.Add(AConnection);
            //assign the list to the collection class
            AConnectionCollection.MyConnections = testList;
            //test to see that the two values are the same
            Assert.AreEqual(AConnectionCollection.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodExists()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("17:45")
            };
            //assign the test object to the collection class
            AConnectionCollection.ThisConnection = AConnection;
            //store the primary key
            //add the record
            int primaryKey = AConnectionCollection.AddConnection();
            //set the primary key of the test data
            AConnection.ConnectionId = primaryKey;
            //find the record
            AConnectionCollection.ThisConnection.FindConnection(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AConnectionCollection.ThisConnection, AConnection);
            //delete the recod not to fill the database with duplicate records
            AConnectionCollection.DeleteConnection();
        }

        [TestMethod]

        public void DeleteMethodExists()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("17:45")
            };
            //assign the test object to the collection class
            AConnectionCollection.ThisConnection = AConnection;
            //store the primary key
            //add the record
            int primaryKey = AConnectionCollection.AddConnection();
            //set the primary key of the test data
            AConnection.ConnectionId = primaryKey;
            //find the record
            AConnectionCollection.ThisConnection.FindConnection(primaryKey);
            //delete the record
            AConnectionCollection.DeleteConnection();
            //now find the record
            bool found = AConnectionCollection.ThisConnection.FindConnection(primaryKey);
            //the record must not be found
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsConnectionCollection AConnectionCollection = new clsConnectionCollection();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = true,
                ConnectionStartStation = "Leicester",
                ConnectionEndStation = "Birmingham",
                ConnectionDate = new DateTime(2021, 7, 17),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("17:45")
            };
            //assign the test object to the collection class
            AConnectionCollection.ThisConnection = AConnection;
            //store the primary key
            //add the record
            int primaryKey = AConnectionCollection.AddConnection();
            //set the primary key of the test data
            AConnection.ConnectionId = primaryKey;
            //assign all the properties
            AConnection.ConnectionActive = true;
            AConnection.ConnectionStartStation = "Leicester";
            AConnection.ConnectionEndStation = "Birmingham";
            AConnection.ConnectionDate = new DateTime(2021, 7, 17);
            AConnection.ConnectionTicketLimit = 150;
            AConnection.TicketTypeId = 1;
            AConnection.ConnectionTime = TimeSpan.Parse("18:45");
            //assign the test object to the real object
            AConnectionCollection.ThisConnection = AConnection;
            //update data of the real object
            AConnectionCollection.ModifyConnection();
            //find the record
            AConnectionCollection.ThisConnection.FindConnection(primaryKey);
            //check if the data matches
            Assert.AreEqual(AConnectionCollection.ThisConnection, AConnection);
            //delete the record not to fill the database with duplicate records
            AConnectionCollection.DeleteConnection();
        }

        [TestMethod]
        public void ListConnectionsMethodOK()
        {
            //create an instance of the class we want to create
            clsConnectionCollection allConnections = new clsConnectionCollection();
            //perform the listing
            allConnections.MyConnections = allConnections.ListConnections();
            //the collection list should not be empty
            Assert.AreNotEqual(0, allConnections.MyConnections.Count);
        }

        [TestMethod]
        public void FilterConnectionsMethodOK()
        {
            //create an instance of the class we want to create
            clsConnectionCollection filteredConnections = new clsConnectionCollection();
            //a test object
            clsConnection AConnection = new clsConnection
            {
                ConnectionActive = false,
                ConnectionStartStation = "TestConnection",
                ConnectionEndStation = "DoNotDelete",
                ConnectionDate = new DateTime(2025, 12, 14),
                ConnectionTicketLimit = 150,
                TicketTypeId = 1,
                ConnectionTime = TimeSpan.Parse("15:20")
            };
            //perform the filtering
            filteredConnections.MyConnections = filteredConnections.FilterConnections(AConnection);
            //there should be exactly 1 result
            Assert.AreEqual(1, filteredConnections.MyConnections.Count);
        }
    }
}
