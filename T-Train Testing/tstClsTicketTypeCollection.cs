using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using T_Train_Classes;

namespace TTrainTicketType
{
    [TestClass]
    public class tstClsTicketTypeCollection
    {
        [TestMethod]
        public void InstanceExists()
        {
            clsTicketTypeCollection ATicketTypeCollection = new clsTicketTypeCollection();
            Assert.IsNotNull(ATicketTypeCollection);
        }

        [TestMethod]
        public void TicketTypeCollectionListExists()
        {
            //create an instance of the class we want to create
            clsTicketTypeCollection ATicketTypeCollection = new clsTicketTypeCollection();
            //create some test data to assign to the property
            List<clsTicketType> testList = new List<clsTicketType>();
            //a test object
            clsTicketType ATicketType = new clsTicketType
            {
                //assign all the properties
                TicketTypeActive = true,
                TicketTypeId = 15,
                TicketTypeName = "Summer Special 2021",
                TicketTypePrice = 12.75f,
                TicketTypeRefundable = false
            };
            //add the test object to the list
            testList.Add(ATicketType);
            //assign the list to the collection class
            ATicketTypeCollection.MyTicketTypes = testList;
            //test to see that the two values are the same
            Assert.AreEqual(ATicketTypeCollection.MyTicketTypes, testList);
        }

        [TestMethod]

        public void ThisTicketTypePropertyExists()
        {
            //create an instance of the class we want to create
            clsTicketTypeCollection ATicketTypeCollection = new clsTicketTypeCollection();
            //a test object
            clsTicketType ATicketType = new clsTicketType
            {
                //assign all the properties
                TicketTypeActive = true,
                TicketTypeId = 15,
                TicketTypeName = "Summer Special 2021",
                TicketTypePrice = 12.75f,
                TicketTypeRefundable = false
            };
            //assign the test object to the collection class
            ATicketTypeCollection.ThisTicketType = ATicketType;
            //test to see that the two values are the same
            Assert.AreEqual(ATicketTypeCollection.ThisTicketType, ATicketType);
        }

        [TestMethod]
        public void ListAndCountExist()
        {
            //create an instance of the class we want to create
            clsTicketTypeCollection ATicketTypeCollection = new clsTicketTypeCollection();
            //create some test data to assign to the property
            List<clsTicketType> testList = new List<clsTicketType>();
            //a test object
            clsTicketType ATicketType = new clsTicketType
            {
                //assign all the properties
                TicketTypeActive = true,
                TicketTypeId = 15,
                TicketTypeName = "Summer Special 2021",
                TicketTypePrice = 12.75f,
                TicketTypeRefundable = false
            };
            //add the test object to the list
            testList.Add(ATicketType);
            //assign the list to the collection class
            ATicketTypeCollection.MyTicketTypes = testList;
            //test to see that the two values are the same
            Assert.AreEqual(ATicketTypeCollection.Count, testList.Count);
        }
    }
}
