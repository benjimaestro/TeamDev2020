using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void FindMethod()
        {
            clsRoom Room = new clsRoom();
            Boolean Found = false;
            Int32 RoomID = 1;
            Found = Room.Find(RoomID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindMethodNotFound()
        {
            clsRoom Room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RoomID = 1;
            Found = Room.Find(RoomID);
            if (Room.ID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void InstanceOK()
        {

            clsRoom Room = new clsRoom();

            Assert.IsNotNull(Room);
        }
        [TestMethod]
        public void IDPropertyOK()
        {
            clsRoom Room = new clsRoom();
            Int32 TestData = 1;
            Room.ID = TestData;
            Assert.AreEqual(Room.ID, TestData);
        }
        [TestMethod]
        public void NumberPropertyOK()
        {
            clsRoom Room = new clsRoom();
            Int32 TestData = 1;
            Room.Number = TestData;
            Assert.AreEqual(Room.Number, TestData);
        }
        [TestMethod]
        public void BlockPropertyOK()
        {
            clsRoom Room = new clsRoom();
            string TestData = "A";
            Room.Block = TestData;
            Assert.AreEqual(Room.Block, TestData);
        }
        [TestMethod]
        public void SubjectPropertyOK()
        {
            clsRoom Room = new clsRoom();
            string TestData = "Any";
            Room.Block = TestData;
            Assert.AreEqual(Room.Block, TestData);
        }
        [TestMethod]
        public void RoomNamePropertyOK()
        {
            clsRoom Room = new clsRoom();
            Int32 TestNumber = 1;
            string TestBlock= "A";
            Room.Number = TestNumber;
            Room.Block = TestBlock;
            Assert.AreEqual(Room.RoomName, $"{TestBlock.ToUpper()}.{TestNumber.ToString()}");
        }
        [TestMethod]
        public void TestNumberFound()
        {
            clsRoom Room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RoomID = 1;
            Found = Room.Find(RoomID);
            if (Room.Number != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBlockFound()
        {
            clsRoom Room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RoomID = 1;
            Found = Room.Find(RoomID);
            if (Room.Block != "A")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSubjectFound()
        {
            clsRoom Room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RoomID = 1;
            Found = Room.Find(RoomID);
            if (Room.Subject != "English")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestValidateBlankNumber()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "Room number must be a number</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinus1Number()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "-1";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "Room number must be 1-99</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate0Number()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "0";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "Room number must be 1-99</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinNumber()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "1";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidNumber()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "50";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate98Number()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "98";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate99Number()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "99";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate100Number()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "100";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "Room number must be 1-99</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate10000Number()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10000";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "Room number must be 1-99</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankBlock()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "";
            string Subject = "Any";

            string ExpectedError = "Block must be a single A-Z character</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidBlock()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2Block()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "AA";
            string Subject = "Any";

            string ExpectedError = "Block must be a single A-Z character</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankSubject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "";

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinSubject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "A";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMin2Subject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "AA";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidSubject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "AAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate9Subject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "AAAAAAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxSubject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "AAAAAAAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax11Subject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "AAAAAAAAAAA";

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeSubject()
        {
            clsRoom TestItem = new clsRoom();
            string Number = "10";
            string Block = "A";
            string Subject = "A".PadRight(100);

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(Block, Number, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
    }
}
