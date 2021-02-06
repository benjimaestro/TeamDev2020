using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstTimetableCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsTimetableCollection Timetables = new clsTimetableCollection();
            Assert.IsNotNull(Timetables);
        }

        [TestMethod]
        public void TimetableListOK()
        {
            clsTimetableCollection Timetables = new clsTimetableCollection();
            List<clsTimetable> TestList = new List<clsTimetable>();
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 1;
            TestItem.P1 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;
            TestList.Add(TestItem);
            Timetables.Timetablelist = TestList;
            Assert.AreEqual(Timetables.Timetablelist, TestList);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsTimetableCollection Timetables = new clsTimetableCollection();
            List<clsTimetable> TestList = new List<clsTimetable>();
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 99999;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;
            Timetables.ThisTimetable = TestItem;
            Timetables.GenerateTimetable(TestItem.UserID);
            Timetables.DeleteTimetable(TestItem.UserID);

            Boolean Found = Timetables.ThisTimetable.FindByWeekNo(TestItem.UserID, 1);
            Assert.IsFalse(Found);
        }

    }
}
