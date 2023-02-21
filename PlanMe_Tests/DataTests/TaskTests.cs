using MySql.Data.MySqlClient;
using PlanMe.Data;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe_Tests.DataTests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void ChecksIfGetsAllTasks()
        {
            List<UserTask> listEvents = new List<UserTask>();
            listEvents = TaskData.GetAll("Get all");
            Assert.AreEqual(2, listEvents.Count, "It does not return all events for user with username Test!");
        }

        [Test]
        public void ChecksIfReturnsUserId()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int id = TaskData.GetUserId("UserId", conn);
                Assert.AreEqual(23, id, "Does not return right id for user Test");
            }
        }

        [Test]
        public void CheckIfUploadsTask()
        {
            UserTask task = new UserTask("MainScreen");
            TaskData.Upload(task, "UploadTest");
            List<UserTask> userTasks = new List<UserTask>();
            userTasks = TaskData.GetAll("UploadTest");
            for (int i = 0; i < userTasks.Count; i++)
            {
                Assert.AreEqual(task.Text, userTasks[i].Text, "Did not upload the task!");
            }
        }


        [Test]
        public void CheckIfDeletesTask()
        {
            UserTask task1 = new UserTask("MainScreen");
            TaskData.Upload(task1, "UploadTest");
            UserTask task = new UserTask("MainScreen");
            TaskData.Delete(task);
            List<UserTask> tasksAfterDeleting = new List<UserTask>();
            tasksAfterDeleting = TaskData.GetAll("UploadTest");

            Assert.AreEqual(0, tasksAfterDeleting.Count, "Task is not deleted!");
        }

        [Test]
        public void CheckIfUpdatesTask()
        {
            Random random = new Random();
            string taskText = "MainScreen" + random.Next().ToString();
            UserTask task = new UserTask(taskText);
            List<UserTask> tasks = new List<UserTask>();
            TaskData.Update(task, "UpdateTest");
            tasks = TaskData.GetAll("UpdateTest");
            for (int i = 0; i < tasks.Count; i++)
            {
                Assert.AreNotEqual("MainScreen", tasks[i].Text, "Update is unsuccessful!");

            }

        }
    }
}
