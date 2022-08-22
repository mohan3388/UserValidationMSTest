using NUnit.Framework;

namespace ValidationTest
{
    public class Tests
    {
      

        [Test]
        public void UserFirstName()
        {
            User valid = new User();
            bool actual = valid.FNameValidation("Mohan");

            Assert.IsTrue(actual);
        }
        [Test]
        public void User_Valid_lname()
        {
            User valid = new User();
            bool actual = valid.LNameValidation("Sahu");

            Assert.IsTrue(actual);
        }
        [Test]
        public void User_Valid_email()
        {
            User valid = new User();
            bool actual = valid.EmailValidation("abc@yahoo.com");
            Assert.IsTrue(actual);
            bool actual2 = valid.EmailValidation("abc-100@yahoo.com");
            Assert.IsTrue(actual2);
            bool actual3 = valid.EmailValidation("abc.100@yahoo.com");
            Assert.IsTrue(actual3);
            bool actual4 = valid.EmailValidation("abc111@abc.com");
            Assert.IsTrue(actual4);
            bool actual5 = valid.EmailValidation("abc-100@abc.net");
            Assert.IsTrue(actual5);
            bool actual6 = valid.EmailValidation("abc.100@abc.com.au");
            Assert.IsTrue(actual6);

        }
        [Test]
        public void User_Valid_Mobile()
        {
            User valid = new User();
            bool actual = valid.MobileValidation("91 7898625487");

            Assert.IsTrue(actual);
        }
        [Test]
        public void User_Valid_Pass()
        {
            User valid = new User();
            bool actual = valid.PassValidation("nohansahu");

            Assert.IsTrue(actual);
        }
    }
}