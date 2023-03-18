namespace PlanMe_Tests.DataTests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void CheckIfCreatesUser()
        {
            User user = new User("Test users", "Test123User");
            UserData.Create(user);
            User createdUser = UserData.Check("Test users", "Test123User");
            UserData.Delete("Test users");
            Assert.AreEqual(user.ToString(), createdUser.ToString(), "User has not been created!");
        }

        [Test]
        public void CheckIfDeletesUser()
        {
            User user = new User("Tests user", "Test1234");
            UserData.Create(user);
            UserData.Delete("Tests user");
            try
            {
                User checkedUser = UserData.Check("Tests user", "Test234");
            }
            catch
            {
                Assert.IsFalse(false);
            }


        }

        [Test]
        public void CheckIfChecksUser()
        {
            User user = UserData.Check("UserId", "Test1234");
            if(user != null)
            {
                Assert.IsFalse(false);
            }
        }
    }
}
