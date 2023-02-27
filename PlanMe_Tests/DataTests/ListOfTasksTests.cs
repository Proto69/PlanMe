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
            ListOfTasks list = new("Test1", "UploadTest");
            ListOfTasksData.Upload(list);
            var all = ListOfTasksData.GetAll("UploadTest").Where(x => x.Name == "Test1").ToList();
            int count = all.Count;
            Assert.AreEqual(1, count, "The list has not been uploaded!");
            ListOfTasksData.Remove(list);

        }

        //Something is wrong maybe
        [Test]
        public void DeleteAListOfTasks()
        {
            ListOfTasks list = new ListOfTasks("Test2", "UploadTest");
            ListOfTasksData.Upload(list);
            ListOfTasks newList = new ListOfTasks("Test3", "UploadTest");
            ListOfTasksData.Upload(newList);
            ListOfTasksData.Remove(newList);
            var all = ListOfTasksData.GetAll("UploadTest").Where(x => x.Name == "Test2").ToList();
            int count = all.Count;
            Assert.AreEqual(1, count, "The list has not been deleted!");
            ListOfTasksData.Remove(list);
        }

        [Test]
        public void GetsTasksFromListOfTasks()
        {
            ListOfTasks list = MainModels.user.GetListOfTasks("Pesho");
            int count = list.Tasks.Count;
            Assert.AreEqual(1, count, "The tasks are not gotten!");
        }
    }
}
