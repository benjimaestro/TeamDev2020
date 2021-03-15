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
            string TestData = "E54EE7E285FBB0275279143ABC4C554E5314E7B417ECAC83A5984A964FACBAAD68866A2841C3E83DDF125A2985566261C4014F9F960EC60253AEBCDA9513A9B4";
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
            if (User.Password != "E54EE7E285FBB0275279143ABC4C554E5314E7B417ECAC83A5984A964FACBAAD68866A2841C3E83DDF125A2985566261C4014F9F960EC60253AEBCDA9513A9B4")
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidateExtremeEMail()
        {
            clsUser TestItem = new clsUser();
            string EMail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@aaaaaaaaaa.com";
            string Password = "Password123!";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "EMail must be 6-50 characters</br>";
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

            string ExpectedError = "Password cannot be blank</br>Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>";
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

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMin1Password()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "Ab";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidPassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "Password123!Password123!";
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
            string Password = "ASDasd123!ASDasd123!ASDasd123!ASDasd123!ASDasd123";
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
            string Password = "Password123!11111111Password123!111111111111111111";
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
            string Password = "Password123!11111111Password123!11111111111111111111";
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>Password must be 50 characters or under</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremePassword()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "Password123!".PadRight(100);
            string FirstName = "test";
            string SecondName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>Password must be 50 characters or under</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankFirstName()
        {
            clsUser TestItem = new clsUser();
            string EMail = "test@test.com";
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
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
            string Password = "Password123!";
            string SecondName = "test";
            string FirstName = "test";
            string Subject = "Any".PadRight(100);

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(EMail, FirstName, SecondName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
    }
}
