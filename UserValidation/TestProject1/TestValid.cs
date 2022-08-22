using UserValidation;

namespace TestProject1
{
    public class TestValid
    {
        [Test]
        public void UserFirstName()
        {
            try
            {
                User valid = new User();
                bool actual = valid.FNameValidation("Mohan");

                Assert.IsTrue(actual);
            }
            catch (UserException ex)
            {
                Assert.AreEqual(ex.Message, "First name is Invalid");
            }

        }
        [Test]
        public void User_Valid_lname()
        {
            try
            {
                User valid = new User();
                bool actual = valid.LNameValidation("Sahu");

                Assert.IsTrue(actual);
            }
            catch (UserException ex)
            {
                Assert.AreEqual(ex.Message, "Last name is Invalid");
            }
        }
        [Test]
        public void User_Valid_email()
        {
            try
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
            catch (UserException ex)
            {
                Assert.AreEqual(ex.Message, "Email is Invalid");
            }

        }
        [Test]
        
        public void User_Valid_Mobile()
        {
            try
            {
                User valid = new User();
                bool actual = valid.MobileValidation("91 7898625487");

                Assert.IsTrue(actual);
            }
            catch (UserException ex)
            {
                Assert.AreEqual(ex.Message, "Mobile number is Invalid");
            }
        }
        [Test]
        public void User_Valid_Pass()
        {
            try
            {
                User valid = new User();
                bool actual = valid.PassValidation("mohansahu");

                Assert.IsTrue(actual);
            }
            catch (UserException ex)
            {
                Assert.AreEqual(ex.Message, "Password is Invalid");
            }
        }
    }
}