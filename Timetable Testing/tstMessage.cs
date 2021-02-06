using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class txtMessage
    {
        [TestMethod]
        public void FindMethod()
        {
            clsMessage Message = new clsMessage();
            Boolean Found = false;
            Int32 MessageID = 1;
            Found = Message.Find(MessageID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindMethodNotFound()
        {
            clsMessage Message = new clsMessage();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MessageID = 1;
            Found = Message.Find(MessageID);
            if (Message.ID != 105)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void InstanceOK()
        {

            clsMessage Message = new clsMessage();

            Assert.IsNotNull(Message);
        }
        [TestMethod]
        public void IDPropertyOK()
        {
            clsMessage Message = new clsMessage();
            Int32 TestData = 1;
            Message.ID = TestData;
            Assert.AreEqual(Message.ID, TestData);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsMessage Message = new clsMessage();
            Int32 TestData = 1;
            Message.UserID = TestData;
            Assert.AreEqual(Message.UserID, TestData);
        }
        [TestMethod]
        public void ToAdminPropertyOK()
        {
            clsMessage Message = new clsMessage();
            bool TestData = true;
            Message.ToAdmin = TestData;
            Assert.AreEqual(Message.ToAdmin, TestData);
        }
        [TestMethod]
        public void ContentPropertyOK()
        {
            clsMessage Message = new clsMessage();
            string TestData = "h";
            Message.Content = TestData;
            Assert.AreEqual(Message.Content, TestData);
        }
        [TestMethod]
        public void TimestampPropertyOK()
        {
            clsMessage Message = new clsMessage();
            string TestData = "h";
            Message.Timestamp = TestData;
            Assert.AreEqual(Message.Timestamp, TestData);
        }

        [TestMethod]
        public void TestUserIDFound()
        {
            clsMessage Message = new clsMessage();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MessageID = 1;
            Found = Message.Find(MessageID);
            if (Message.UserID != 105)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestToAdminFound()
        {
            clsMessage Message = new clsMessage();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MessageID = 1;
            Found = Message.Find(MessageID);
            if (Message.ToAdmin != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContentFound()
        {
            clsMessage Message = new clsMessage();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MessageID = 1;
            Found = Message.Find(MessageID);
            if (Message.Content != "hello")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTimestampFound()
        {
            clsMessage Message = new clsMessage();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MessageID = 1;
            Found = Message.Find(MessageID);
            if (Message.Timestamp != "02/02/2021 15:32:05")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestValidateInvalidUserID()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 999999;
            bool ToAdmin = true;
            string Content = "hello";
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "User ID does not exist </br>";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateValidUserID()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "hello";
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }

        [TestMethod]
        public void TestValidateBlankContent()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "";
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "Message must be 1-512 characters long </br>";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinContent()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "H";
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMin2Content()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "He";
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidContent()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "H".PadRight(255);
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax511Content()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "H".PadRight(511);
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxContent()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "H".PadRight(512);
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax513Content()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "H".PadRight(513);
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "Message must be 1-512 characters long </br>";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeContent()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "H".PadRight(5000);
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "Message must be 1-512 characters long </br>";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankTimestamp()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "Hello";
            string Timestamp = "";

            string ExpectedError = "Timestamp must be 19 characters long </br>";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateValidTimestamp()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "Hello";
            string Timestamp = "02/02/2021 15:32:05";

            string ExpectedError = "";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeTimestamp()
        {
            clsMessage TestItem = new clsMessage();
            Int32 UserID = 105;
            bool ToAdmin = true;
            string Content = "Hello";
            string Timestamp = "02/02/2021 15:32:05".PadRight(100);

            string ExpectedError = "Timestamp must be 19 characters long </br>";
            string Error = TestItem.Validate(UserID, ToAdmin, Content, Timestamp);
            Assert.AreEqual(Error, ExpectedError);
        }



    }
}
