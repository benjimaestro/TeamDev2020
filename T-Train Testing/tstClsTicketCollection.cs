using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TTrainTicket
{
    [TestClass]
    public class tstClsTicketCollection
    {
        [TestMethod]
        public void InstanceExists()
        {
            clsTicketCollection ATicketCollection = new clsTicketCollection();
            Assert.IsNotNull(ATicketCollection);
        }

        [TestMethod]
        public void TicketCollectionListExists()
        {
            //create an instance of the class we want to create
            clsTicketCollection ATicketCollection = new clsTicketCollection();
            //create some test data to assign to the property
            List<clsTicket> testList = new List<clsTicket>();
            //a test object
            clsTicket ATicket = new clsTicket
            {
                //assign all the properties
                TicketActive = true,
                TicketId = 1,
                ConnectionId = 1,
                CustomerId = 1
            };
            //add the test object to the list
            testList.Add(ATicket);
            //assign the list to the collection class
            ATicketCollection.MyTickets = testList;
            //test to see that the two values are the same
            Assert.AreEqual(ATicketCollection.MyTickets, testList);
        }

        [TestMethod]

        public void ThisTicketTypePropertyExists()
        {
            //create an instance of the class we want to create
            clsTicketCollection ATicketCollection = new clsTicketCollection();
            //a test object
            clsTicket ATicket = new clsTicket
            {
                //assign all the properties
                TicketActive = true,
                TicketId = 1,
                ConnectionId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            ATicketCollection.ThisTicket = ATicket;
            //test to see that the two values are the same
            Assert.AreEqual(ATicketCollection.ThisTicket, ATicket);
        }

        [TestMethod]
        public void ListAndCountExist()
        {
            //create an instance of the class we want to create
            clsTicketCollection ATicketCollection = new clsTicketCollection();
            //create some test data to assign to the property
            List<clsTicket> testList = new List<clsTicket>();
            //a test object
            clsTicket ATicket = new clsTicket
            {
                //assign all the properties
                TicketActive = true,
                TicketId = 1,
                ConnectionId = 1,
                CustomerId = 1
            };
            //add the test object to the list
            testList.Add(ATicket);
            //assign the list to the collection class
            ATicketCollection.MyTickets = testList;
            //test to see that the two values are the same
            Assert.AreEqual(ATicketCollection.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodExists()
        {
            //create an instance of the class we want to create
            clsTicketCollection ATicketCollection = new clsTicketCollection();
            //a test object
            clsTicket ATicket = new clsTicket
            {
                //assign all the properties
                TicketActive = true,
                TicketId = 1,
                ConnectionId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            ATicketCollection.ThisTicket = ATicket;
            //store the primary key
            //add the record
            int primaryKey = ATicketCollection.AddTicket();
            //set the primary key of the test data
            ATicket.TicketId = primaryKey;
            //find the record
            ATicketCollection.ThisTicket.FindTicket(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(ATicketCollection.ThisTicket, ATicket);
            //delete the recod not to fill the database with duplicate records
            ATicketCollection.DeleteTicket();
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsTicketCollection ATicketCollection = new clsTicketCollection();
            //a test object
            clsTicket ATicket = new clsTicket
            {
                //assign all the properties
                TicketActive = true,
                TicketId = 1,
                ConnectionId = 1,
                CustomerId = 1
            };
            //assign the test object to the collection class
            ATicketCollection.ThisTicket = ATicket;
            //store the primary key
            //add the record
            int primaryKey = ATicketCollection.AddTicket();
            //set the primary key of the test data
            ATicket.TicketId = primaryKey;
            //find the record
            ATicketCollection.ThisTicket.FindTicket(primaryKey);
            //delete the record
            ATicketCollection.DeleteTicket();
            //now find the record
            bool found = ATicketCollection.ThisTicket.FindTicket(primaryKey);
            //the record must not be found
            Assert.IsFalse(found);
        }
    }
}
