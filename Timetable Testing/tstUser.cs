using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void FindMethod()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindMethodNotFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.ID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void InstanceOK()
        {

            clsUser User = new clsUser();

            Assert.IsNotNull(User);
        }
        [TestMethod]
        public void IDPropertyOK()
        {
            clsUser User = new clsUser();
            Int32 TestData = 3;
            User.ID = TestData;
            Assert.AreEqual(User.ID, TestData);
        }
        [TestMethod]
        public void EMailPropertyOK()
        {
            clsUser User = new clsUser();
            string TestData = "Adam@Gmail.com";
            User.EMail = TestData;
            Assert.AreEqual(User.EMail, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsUser User = new clsUser();
            string TestData = "Adam";
            User.FirstName = TestData;
            Assert.AreEqual(User.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsUser User = new clsUser();
            string TestData = "Adam";
            User.SecondName = TestData;
            Assert.AreEqual(User.SecondName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsUser User = new clsUser();
            string TestData = "b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86";
            User.Password = TestData;
            Assert.AreEqual(User.Password, TestData);
        }
        [TestMethod]
        public void SubjectPropertyOK()
        {
            clsUser User = new clsUser();
            string TestData = "I.T.";
            User.Subject = TestData;
            Assert.AreEqual(User.Subject, TestData);
        }

        [TestMethod]
        public void TestEMailFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.EMail != "johndoe@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.Password != "B109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestFirstNameFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.FirstName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestLastNameFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.SecondName != "Doe")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestAdminFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.Admin != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestSubjectFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.Subject != "Any")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
