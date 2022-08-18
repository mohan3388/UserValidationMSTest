using UserValidation;

namespace TestProject1
{
    [TestClass]
    public class validTest
    {
        [TestMethod]       
            public void User_Valid_name()
            {
                User valid = new User();
            bool actual = valid.FNameValidation("Mohan");
            
            Assert.IsTrue(actual);
            }
        [TestMethod]
        public void User_Valid_lname()
        {
            User valid = new User();
            bool actual = valid.LNameValidation("Sahu");

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_email()
        {
            User valid = new User();
            bool actual = valid.EmailValidation("abc.xyz@bl.co.in");

            Assert.IsTrue(actual);
        }
    }
}