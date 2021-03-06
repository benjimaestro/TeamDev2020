﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstTimetable
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsTimetable Timetable = new clsTimetable();

            Assert.IsNotNull(Timetable);
        }
        [TestMethod]
        public void IDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.ID = TestData;
            Assert.AreEqual(Timetable.ID, TestData);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.UserID = TestData;
            Assert.AreEqual(Timetable.UserID, TestData);
        }
        [TestMethod]
        public void P1IDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.P1 = TestData;
            Assert.AreEqual(Timetable.P1, TestData);
        }

        [TestMethod]
        public void P2IDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.P2 = TestData;
            Assert.AreEqual(Timetable.P2, TestData);
        }
        [TestMethod]
        public void P3IDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.P3 = TestData;
            Assert.AreEqual(Timetable.P3, TestData);
        }
        [TestMethod]
        public void P4IDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.P4 = TestData;
            Assert.AreEqual(Timetable.P4, TestData);
        }
        [TestMethod]
        public void P5IDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.P5 = TestData;
            Assert.AreEqual(Timetable.P5, TestData);
        }
        [TestMethod]
        public void WeekNoIDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.WeekNo = TestData;
            Assert.AreEqual(Timetable.WeekNo, TestData);
        }
        [TestMethod]
        public void DayNoIDPropertyOK()
        {
            clsTimetable Timetable = new clsTimetable();
            Int32 TestData = 1;
            Timetable.WeekNo = TestData;
            Assert.AreEqual(Timetable.WeekNo, TestData);
        }

        [TestMethod]
        public void TestIDFound()
        {
            clsTimetable Timetable = new clsTimetable();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 103;
            Found = Timetable.Find(ID);
            if (Timetable.ID != 103)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
       
        [TestMethod]
        public void TestValidateNegativeUserID()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = -1;
            TestItem.P1 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "User ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateRealUserID()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P1 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeUserID()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 999999999;
            TestItem.P1 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "User ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateNegativeP1()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P1 = -1;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P1 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeP1()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P1 = 999999999;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P1 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateRealP1()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P1 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }

        [TestMethod]
        public void TestValidateNegativeP2()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P2 = -1;
            TestItem.P1 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P2 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeP2()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P2 = 999999999;
            TestItem.P1 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P2 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateRealP2()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateNegativeP3()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P3 = -1;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P3 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeP3()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P3 = 999999999;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P3 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateRealP3()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P3 = 7;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P4 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateNegativeP4()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P4 = -1;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P3 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P4 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeP4()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P4 = 999999999;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P3 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P4 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateRealP4()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P4 = 7;
            TestItem.P2 = 7;
            TestItem.P1 = 7;
            TestItem.P3 = 7;
            TestItem.P5 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateNegativeP5()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = -1;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P5 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeP5()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 999999999;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "P5 ID does not exist </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateRealP5()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }

        [TestMethod]
        public void TestValidate0WeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 0;
            TestItem.DayNo = 1;

            string ExpectedError = "WeekNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateNegativeWeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = -1;
            TestItem.DayNo = 1;

            string ExpectedError = "WeekNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate1WeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2WeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 2;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate4WeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 4;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate5WeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 5;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate6WeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 6;
            TestItem.DayNo = 1;

            string ExpectedError = "WeekNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeWeekNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 999999;
            TestItem.DayNo = 1;

            string ExpectedError = "WeekNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateNegativeDayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = -0;

            string ExpectedError = "DayNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate1DayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 1;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2DayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 2;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate4DayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 4;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate5DayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 5;

            string ExpectedError = "";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate6DayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 6;

            string ExpectedError = "DayNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeDayNo()
        {
            clsTimetable TestItem = new clsTimetable();
            TestItem.UserID = 105;
            TestItem.P5 = 7;
            TestItem.P2 = 7;
            TestItem.P3 = 7;
            TestItem.P4 = 7;
            TestItem.P1 = 7;
            TestItem.WeekNo = 1;
            TestItem.DayNo = 999999;

            string ExpectedError = "DayNo must be 1-5 </br>";
            string Error = TestItem.Validate(TestItem.UserID, TestItem.P1, TestItem.P2, TestItem.P3, TestItem.P4, TestItem.P5, TestItem.WeekNo, TestItem.DayNo);
            Assert.AreEqual(Error, ExpectedError);
        }
    }
}
