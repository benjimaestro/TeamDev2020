using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using ClassLibrary;

namespace Timetable_Testing
{
    [TestClass]
    public class tstUserCollection
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsUserCollection Users = new clsUserCollection();
            Assert.IsNotNull(Users);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsUserCollection Users = new clsUserCollection();
            List<clsUser> TestList = new List<clsUser>();
            clsUser TestItem = new clsUser();
            TestItem.EMail = "test@test.com";
            TestItem.Password = "password";
            TestItem.FirstName = "test";
            TestItem.SecondName = "test";
            TestItem.Admin = false;
            TestItem.Subject = "Any";
            TestList.Add(TestItem);
            Users.Userlist = TestList;
            Assert.AreEqual(Users.Userlist, TestList);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsUserCollection Users = new clsUserCollection();
            List<clsUser> TestList = new List<clsUser>();
            clsUser TestItem = new clsUser();
            Int32 ID = 0;
            TestItem.EMail = "test@test.com";
            TestItem.Password = "password";
            TestItem.FirstName = "test";
            TestItem.SecondName = "test";
            TestItem.Admin = false;
            TestItem.Subject = "Any";

            Users.ThisUser = TestItem;
            ID = Users.Add();
            TestItem.ID = ID;
            Users.Delete(ID);

            Boolean Found = Users.ThisUser.Find(ID);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void EditMethodOK()
        {
            clsUserCollection Users = new clsUserCollection();
            clsUser PreTestItem = new clsUser();
            clsUser TestItem = new clsUser();
            Int32 ID = 0;
            TestItem.EMail = "test@test.com";
            TestItem.Password = "password";
            TestItem.FirstName = "test";
            TestItem.SecondName = "test";
            TestItem.Admin = false;
            TestItem.Subject = "Any";

            Users.ThisUser = TestItem;
            ID = Users.Add();
            TestItem.ID = ID;

            TestItem.EMail = "hhhtest@test.com";
            TestItem.Password = "hhhpassword";
            TestItem.FirstName = "hhhtest";
            TestItem.SecondName = "hhhtest";
            TestItem.Admin = false;
            TestItem.Subject = "hhhAny";

            Users.ThisUser = TestItem;
            Users.Edit();
            Assert.AreEqual(Users.ThisUser, TestItem);
            Users.Delete(ID);
        }
        public void EMailFilterMethodOK()
        {
            clsUserCollection Users = new clsUserCollection();
            clsUserCollection FilteredUsers = new clsUserCollection();
            FilteredUsers.FilterByEMail("");
            Assert.AreEqual(FilteredUsers.Count, FilteredUsers.Count);
        }
        public void EMailFilterMethodNone()
        {
            clsUserCollection Users = new clsUserCollection();
            clsUserCollection FilteredUsers = new clsUserCollection();
            FilteredUsers.FilterByEMail("sdfhjksdfksdfhjksdfksdfhjksdfk");
            Assert.AreEqual(FilteredUsers.Count, FilteredUsers.Count);
        }
        public void NameFilterMethodOK()
        {
            clsUserCollection Users = new clsUserCollection();
            clsUserCollection FilteredUsers = new clsUserCollection();
            FilteredUsers.FilterByEMail("");
            Assert.AreEqual(FilteredUsers.Count, FilteredUsers.Count);
        }
        public void NameFilterMethodNone()
        {
            clsUserCollection Users = new clsUserCollection();
            clsUserCollection FilteredUsers = new clsUserCollection();
            FilteredUsers.FilterByEMail("sdfhjksdfksdfhjksdfksdfhjksdfk");
            Assert.AreEqual(FilteredUsers.Count, FilteredUsers.Count);
        }
    }
}
