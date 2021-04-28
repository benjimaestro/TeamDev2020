using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void AddMethodExists()
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
            //set ThisStaff to the test data
            ATicketTypeCollection.ThisTicketType = ATicketType;
            //store the primary key
            //add the record
            int primaryKey = ATicketTypeCollection.AddTicketType();
            //set the primary key of the test data
            ATicketType.TicketTypeId = primaryKey;
            //find the record
            ATicketTypeCollection.ThisTicketType.FindTicketType(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(ATicketTypeCollection.ThisTicketType, ATicketType);
            //delete the recod not to fill the database with duplicate records
            ATicketTypeCollection.DeleteTicketType();
        }

        [TestMethod]

        public void DeleteMethodOK()
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
            //set ThisStaff to the test data
            ATicketTypeCollection.ThisTicketType = ATicketType;
            //store the primary key
            //add the record
            int primaryKey = ATicketTypeCollection.AddTicketType();
            //set the primary key of the test data
            ATicketType.TicketTypeId = primaryKey;
            //find the record
            ATicketTypeCollection.ThisTicketType.FindTicketType(primaryKey);
            //delete the record
            ATicketTypeCollection.DeleteTicketType();
            //now find the record
            bool found = ATicketTypeCollection.ThisTicketType.FindTicketType(primaryKey);
            //the record must not be found
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
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
            //set ThisStaff to the test data
            ATicketTypeCollection.ThisTicketType = ATicketType;
            //store the primary key
            //add the record
            int primaryKey = ATicketTypeCollection.AddTicketType();
            //set the primary key of the test data
            ATicketType.TicketTypeId = primaryKey;
            //assign all the properties
            ATicketType.TicketTypeActive = false;
            ATicketType.TicketTypeName = "Super Summer Special 2021";
            ATicketType.TicketTypePrice = 15.75f;
            ATicketType.TicketTypeRefundable = true;
            //assign the test object to the real object
            ATicketTypeCollection.ThisTicketType = ATicketType;
            //update data of the real object
            ATicketTypeCollection.ModifyTicketType();
            //find the record
            ATicketTypeCollection.ThisTicketType.FindTicketType(primaryKey);
            //check if the data matches
            Assert.AreEqual(ATicketTypeCollection.ThisTicketType, ATicketType);
            //delete the record not to fill the database with duplicate records
            ATicketTypeCollection.DeleteTicketType();
        }

        [TestMethod]
        public void FilterTicketTypesMethodExists()
        {
            //create test parameters
            string typeName = "testTicketType";
            string maxPrice = "20";
            bool onlyRefundable = false;
            //next assign the parameters
            clsTicketType ATicketType = new clsTicketType
            {
                TicketTypeName = typeName,
                TicketTypePrice = float.Parse(maxPrice),
                TicketTypeRefundable = onlyRefundable
            };
            //create a manager class
            clsTicketTypeCollection TicketTypes = new clsTicketTypeCollection();
            //invoke the method
            TicketTypes.MyTicketTypes = TicketTypes.FilterTicketTypes(ATicketType);
            //there should be a record found (unless test data was modified)
            Assert.AreEqual(1, TicketTypes.Count);
        }

        [TestMethod]
        public void ListTicketTypesMethodExists()
        {
            //create a manager class
            clsTicketTypeCollection TicketTypes = new clsTicketTypeCollection();
            //invoke the method
            TicketTypes.MyTicketTypes = TicketTypes.ListTicketTypes();
            //there should be a record found (unless test data was modified)
            int count = TicketTypes.Count;
            //check if there are any records
            bool found = count > 0;
            Assert.AreEqual(true, found);
        }
    }
}
