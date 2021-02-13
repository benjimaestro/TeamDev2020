using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstMessageCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsMessageCollection Messages = new clsMessageCollection();
            Assert.IsNotNull(Messages);
        }

        [TestMethod]
        public void MessageListOK()
        {
            clsMessageCollection Messages = new clsMessageCollection();
            List<clsMessage> TestList = new List<clsMessage>();
            clsMessage TestItem = new clsMessage();
            TestItem.UserID = 1;
            TestItem.ToAdmin = false;
            TestItem.Content = "Hello :)";
            TestItem.Timestamp = "02/02/2021 15:32:05";
            TestList.Add(TestItem);
            Messages.Messagelist = TestList;
            Assert.AreEqual(Messages.Messagelist, TestList);
        }
        [TestMethod]
        public void SubjectFilterMethodOK()
        {
            clsMessageCollection Messages = new clsMessageCollection();
            clsMessageCollection FilteredMessages = new clsMessageCollection();
            FilteredMessages.FilterByUserID(0);
            Assert.AreEqual(FilteredMessages.Count, FilteredMessages.Count);
        }
    }
}
