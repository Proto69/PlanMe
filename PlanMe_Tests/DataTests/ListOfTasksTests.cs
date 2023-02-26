using PlanMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe_Tests.DataTests
{
    [TestFixture]
    public class ListOfTasksTests
    {
        [SetUp]
        public void Setup()
        {
            User user = new User("UploadTest", "Test12345");
            MainModels.user = user;
        }

        [Test]
        public void CreateNewListOfTasks()
        {
            ListOfTasks list = new("Test", "UploadTest");
            ListOfTasksData.Upload(list);
            var all = ListOfTasksData.GetAll("UploadTest").Where(x => x.Name == "Test").ToList();
            int count = all.Count;
            Assert.AreEqual(1, count, "The list has not been uploaded!");
        }

        [Test]
        public void DeleteAListOfTasks()
        {
            ListOfTasks list = new ListOfTasks("Test", "UploadTest");
            ListOfTasksData.Remove(list);
            var all = ListOfTasksData.GetAll("UploadTest").Where(x => x.Name == "Test").ToList();
            int count = all.Count;
            Assert.AreEqual(0, count, "The list has not been deleted!");
        }
    }
}
