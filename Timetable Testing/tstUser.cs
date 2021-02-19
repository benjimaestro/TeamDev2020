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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void TestValidateInvalidEMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "bademail";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Invalid EMail format</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate51EMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "123456789@1234567890123456789012345678901234566.com";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "EMail must be 6-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate50EMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "123456789@123456789012345678901234567890123456.com";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49EMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "123456789@12345678901234567890123456789012345.com";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidate0EMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "EMail must be 6-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidate6EMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "a@a.com";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidateGoodEMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "aaaa@aaaa.com";
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidateMaxEMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "aaaaa@aaaaa.com".PadRight(100);
            string Password = "password";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankPassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Password cannot be blank</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinPassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "1";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMin1Password()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "11";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidPassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "1234512345123451234512345";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49Password()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "1234567890123456789012345678901234567890123456789";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxPassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345678901234567890123456789012345678901234567890";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax51Password()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "123456789012345678901234567890123456789012345678900";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must be 50 characters or under</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremePassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "1".PadRight(100);
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must be 50 characters or under</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankFirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "First name must be 1-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinFirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "a";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2FirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "aa";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidFirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "1234512345123451234512345";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49FirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "1234512345123451234512345123451234512345123451234";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxFirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "12345123451234512345123451234512345123451234512345";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax51FirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "123451234512345123451234512345123451234512345123451";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "First name must be 1-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeFirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string FirstName = "1".PadRight(100);
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "First name must be 1-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankSecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "Last name must be 1-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinSecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "a";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2SecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "aa";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidSecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "1234512345123451234512345";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49SecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "1234512345123451234512345123451234512345123451234";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxSecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "12345123451234512345123451234512345123451234512345";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax51SecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "123451234512345123451234512345123451234512345123451";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "Last name must be 1-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeSecondName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName =  "1".PadRight(100);
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "Last name must be 1-50 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }



        [TestMethod]
        public void TestValidateBlankSubject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "";

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinSubject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "A";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2Subject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "An";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidSubject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "Maths";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate9Subject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "AAAAAAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxSubject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "AAAAAAAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax11Subject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "AAAAAAAAAAA";

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeSubject()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "12345";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "Any".PadRight(100);

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
    }
}
