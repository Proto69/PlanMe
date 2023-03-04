using Org.BouncyCastle.Asn1.Mozilla;
using PlanMe;
using PlanMe.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe_Tests.ControllsTests
{
    [TestFixture]
    public class DataControlTests
    {
        [SetUp]
        public void Setup()
        {
            User user = new User("UploadTest", "Test12345");
            MainModels.user = user;
        }

        [Test]
        public void CheckIfUserIsCreated()
        {
            DataControl.CreateUser("TEST NAME", "TESTPASSWORD1234");
            User user = UserData.Check("TEST NAME", "TESTPASSWORD1234");
            Assert.IsNotNull(user);
            UserData.Delete("TEST NAME");
        }

        [Test]
        public void CheckIfUserIsDeleted()
        {
            DataControl.CreateUser("DELETED TEST", "DELETEDTEST1234");
            User user = UserData.Check("DELETED TEST", "DELETEDTEST1234");
            //bool checker = DataControl.DeleteUser(user);
            bool checker = UserData.Delete("DELETED TEST");
            Assert.IsTrue(checker, "User is not deleted!");
        }

        [Test]
        public void CheckIfPasswordIsUpdated()
        {
            throw new NotImplementedException("Password update test is not implemented!");
        }
    }
}
