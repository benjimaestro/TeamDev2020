using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstRoomCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            Assert.IsNotNull(Rooms);
        }

        [TestMethod]
        public void RoomListOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            List<clsRoom> TestList = new List<clsRoom>();
            clsRoom TestItem = new clsRoom();
            TestItem.Number = 1;
            TestItem.Block = "B";
            TestItem.Subject = "Any";
            TestList.Add(TestItem);
            Rooms.Roomlist = TestList;
            Assert.AreEqual(Rooms.Roomlist, TestList);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            List<clsRoom> TestList = new List<clsRoom>();
            clsRoom TestItem = new clsRoom();
            Int32 ID = 0;
            TestItem.Number = 1;
            TestItem.Block = "B";
            TestItem.Subject = "Any";

            Rooms.ThisRoom = TestItem;
            ID = Rooms.Add();
            TestItem.ID = ID;
            Rooms.Delete(ID);

            Boolean Found = Rooms.ThisRoom.Find(ID);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void EditMethodOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            clsRoom PreTestItem = new clsRoom();
            clsRoom TestItem = new clsRoom();
            Int32 ID = 0;
            TestItem.Number = 1;
            TestItem.Block = "B";
            TestItem.Subject = "Any";

            Rooms.ThisRoom = TestItem;
            ID = Rooms.Add();
            TestItem.ID = ID;

            TestItem.Number = 2;
            TestItem.Block = "C";
            TestItem.Subject = "Maths";

            Rooms.ThisRoom = TestItem;
            Rooms.Edit();
            Assert.AreEqual(Rooms.ThisRoom, TestItem);
            Rooms.Delete(ID);
        }
        [TestMethod]
        public void SubjectFilterMethodOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            clsRoomCollection FilteredRooms = new clsRoomCollection();
            FilteredRooms.FilterBySubject("");
            Assert.AreEqual(FilteredRooms.Count, FilteredRooms.Count);
        }
        [TestMethod]
        public void SubjectFilterMethodNone()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            clsRoomCollection FilteredRooms = new clsRoomCollection();
            FilteredRooms.FilterBySubject("sdfsdfsdf");
            Assert.AreEqual(FilteredRooms.Count, FilteredRooms.Count);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.Find(1);
            Assert.AreEqual(1, Rooms.ThisRoom.ID);
        }
        [TestMethod]
        public void FindExistingRoomMethodOK()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.FindExistingRoom("A",1);
            Assert.AreEqual(1, Rooms.ThisRoom.ID);
        }
    }
}
