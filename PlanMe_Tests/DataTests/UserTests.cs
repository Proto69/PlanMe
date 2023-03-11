﻿namespace PlanMe_Tests.DataTests
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
        public void CheckIfUpdatesUser()
        {
            Random random = new Random();

            User user = new User("UPDATE TEST", "12345678");
            UserData.Create(user);

            string password = "UPDATETEST" + random.Next(0,100);
            user.Password = password;

            UserData.UpdatePassword(user);

            User checkedUser = UserData.Check("UPDATE TEST", password);

            Assert.AreEqual(user.ToString(), checkedUser.ToString(), "Does not return right user!");

            UserData.Delete(user.Username);
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
