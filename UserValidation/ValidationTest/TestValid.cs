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
            bool actual = valid.EmailValidation("abc.xyz@bl.co.in");

            Assert.IsTrue(actual);
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