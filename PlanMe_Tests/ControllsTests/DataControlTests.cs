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
            throw new NotImplementedException("Delete user test is not implemented!");
        }

        [Test]
       /* public void CheckIfTaskIsCreated()
        {
            DataControl.CreateTask("TEST TEXT", "Pesho");
            bool checker = TaskData.Check("TEST TEXT");
            Assert.IsTrue(checker, "Task is not created!");
        }
       
        [Test]*/
        public void CheckIfPasswordIsUpdated()
        {
            throw new NotImplementedException("Password update test is not implemented!");
        }

        [Test] 
        public void CheckIfTaskIsUpdated()
        {
            //Not sure if it is possible
            throw new NotImplementedException("Update task test is not implemented!");
        }
    }
}
