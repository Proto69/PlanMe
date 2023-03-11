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
        public void SetUp()
        {
            User user = new User("ListOfTasksTests", "Tests1234");
            MainModels.user = user;
        }

        [Test]
        public void CreateNewListOfTasks()
        {
            ListOfTasks list = new ListOfTasks("Test uploading");
            ListOfTasksData.Upload(list);
            var all = ListOfTasksData.GetAll("ListOfTasksTests");
            all = all.Where(x => x.Name == "Test uploading").ToList();
            int count = all.Count;
            Assert.AreEqual(1, count, "The list has not been uploaded!");
            ListOfTasksData.Remove(list);

        }

        [Test]
        public void DeleteAListOfTasks()
        {

            ListOfTasks list = new ListOfTasks("Remove test 1");
            ListOfTasks newList = new ListOfTasks("Remove test 2");

            ListOfTasksData.Upload(list);
            ListOfTasksData.Upload(newList);
            ListOfTasksData.Remove(list);
            var all = ListOfTasksData.GetAll("ListOfTasksTests").Where(x => x.Name == "Remove test 2").ToList();
            int count = all.Count;

            Assert.AreEqual(1, count, "The list has not been deleted!");

            ListOfTasksData.Remove(newList);
        }


        [Test]
        public void ChecksIfGetsAllListOfTasksForCurrentUser()
        {
            var allLists = ListOfTasksData.GetAll("UserId");
            int count = allLists.Count();
            Assert.AreEqual(2, count, "Get all method does not work!");
        }

        [Test]
        public void ChecksIfGetsOneListOfTasksForCurrentUser()
        {
            var allLists = ListOfTasksData.GetAll("UserId").Where(x => x.Name == "Get all test");
            int count = allLists.Count();
            Assert.AreEqual(1, count, "Get all method does not work!");
        }
    }
}
