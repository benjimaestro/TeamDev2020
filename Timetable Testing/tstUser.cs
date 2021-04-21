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
        public void EmailPropertyOK()
        {
            clsUser User = new clsUser();
            string TestData = "Adam@Gmail.com";
            User.Email = TestData;
            Assert.AreEqual(User.Email, TestData);
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
            User.LastName = TestData;
            Assert.AreEqual(User.LastName, TestData);
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
        public void TestEmailFound()
        {
            clsUser User = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 3;
            Found = User.Find(UserID);
            if (User.Email != "johndoe@gmail.com")
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
            if (User.LastName != "Doe")
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
        public void TestValidateInvalidEmail()
        {
            clsUser TestItem = new clsUser();
            string Email = "badEmail";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Invalid Email format</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate51Email()
        {
            clsUser TestItem = new clsUser();
            string Email = "123456789@1234567890123456789012345678901234566.com";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Email must be 6-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate50Email()
        {
            clsUser TestItem = new clsUser();
            string Email = "123456789@123456789012345678901234567890123456.com";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49Email()
        {
            clsUser TestItem = new clsUser();
            string Email = "123456789@12345678901234567890123456789012345.com";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidate0Email()
        {
            clsUser TestItem = new clsUser();
            string Email = "";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Email must be 6-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidate6Email()
        {
            clsUser TestItem = new clsUser();
            string Email = "a@a.com";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidateGoodEmail()
        {
            clsUser TestItem = new clsUser();
            string Email = "aaaa@aaaa.com";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        public void TestValidateExtremeEmail()
        {
            clsUser TestItem = new clsUser();
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@aaaaaaaaaa.com";
            string Password = "Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Email must be 6-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankPassword()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Password cannot be blank</br>Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinPassword()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "1";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMin1Password()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Ab";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidPassword()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!Password123!";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49Password()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "ASDasd123!ASDasd123!ASDasd123!ASDasd123!ASDasd123";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxPassword()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!11111111Password123!111111111111111111";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax51Password()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!11111111Password123!11111111111111111111";
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>Password must be 50 characters or under</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremePassword()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!".PadRight(100);
            string FirstName = "test";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "Password must contain at least 1 uppercase, 1 lowercase, 1 number and 1 special character</br>Password must be 50 characters or under</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankFirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "First name must be 1-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinFirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "a";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2FirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "aa";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidFirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "1234512345123451234512345";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49FirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "1234512345123451234512345123451234512345123451234";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxFirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "12345123451234512345123451234512345123451234512345";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax51FirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "123451234512345123451234512345123451234512345123451";
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "First name must be 1-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeFirstName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string FirstName = "1".PadRight(100);
            string LastName = "test";
            string Subject = "Any";

            string ExpectedError = "First name must be 1-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankLastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "Last name must be 1-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinLastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "a";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2LastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "aa";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidLastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "1234512345123451234512345";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate49LastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "1234512345123451234512345123451234512345123451234";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxLastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "12345123451234512345123451234512345123451234512345";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax51LastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "123451234512345123451234512345123451234512345123451";
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "Last name must be 1-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeLastName()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName =  "1".PadRight(100);
            string FirstName = "test";
            string Subject = "Any";

            string ExpectedError = "Last name must be 1-50 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateBlankSubject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "";

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMinSubject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "A";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate2Subject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "An";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMidSubject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "Maths";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidate9Subject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "AAAAAAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMaxSubject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "AAAAAAAAAA";

            string ExpectedError = "";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateMax11Subject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "AAAAAAAAAAA";

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void TestValidateExtremeSubject()
        {
            clsUser TestItem = new clsUser();
            string Email = "test@test.com";
            string Password = "Password123!";
            string LastName = "test";
            string FirstName = "test";
            string Subject = "Any".PadRight(100);

            string ExpectedError = "Subject must be 1-10 characters</br>";
            string Error = TestItem.Validate(Email, FirstName, LastName, Password, Subject);
            Assert.AreEqual(Error, ExpectedError);
        }
        [TestMethod]
        public void GetHashPasswordMethodOK()
        {
            clsUser User = new clsUser();
            string password = "E54EE7E285FBB0275279143ABC4C554E5314E7B417ECAC83A5984A964FACBAAD68866A2841C3E83DDF125A2985566261C4014F9F960EC60253AEBCDA9513A9B4";
            Assert.AreEqual(password, User.GetHashPassword("asd"));
        }
    }
}
