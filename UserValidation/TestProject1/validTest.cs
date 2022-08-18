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
        
    }
}