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
            Assert.AreEqual(2, listEvents.Count, "It does not return all events for user with username Get all!");
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
            UserTask task = new UserTask("Testtt");
            TaskData.Upload(task, "UploadTest");
            List<UserTask> userTasks = TaskData.GetAll("UploadTest");
            Assert.AreEqual(1, userTasks.Count, "The task was not uploaded!");
        }


        [Test]
        public void CheckIfDeletesTask()
        {
            TaskData.Delete("Testtt");
            List<UserTask> tasksAfterDeleting = TaskData.GetAll("UploadTest");
            Assert.AreEqual(0, tasksAfterDeleting.Count, "Task is not deleted!");
        }

        [Test]
        public void CheckIfUpdatesTask()
        {
            UserTask task = new UserTask("Update");
            TaskData.Upload(task, "UploadTest");
            task.IsDone = true;
            TaskData.Update(task, "UploadTest");
            List<UserTask> userTasks = TaskData.GetAll("UploadTest");
            Assert.AreEqual(task.IsDone, userTasks[0].IsDone, "The task was not uploaded!");
            TaskData.Delete("Update");
        }

        [Test] 
        public void CheckIfChecksRight()
        {
            bool checker = TaskData.Check("Get all");
            Assert.IsTrue(checker, "Task is not checked right!");
        }
    }
}
