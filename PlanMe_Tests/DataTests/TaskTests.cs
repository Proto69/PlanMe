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
            listEvents = TaskData.GetAll("Pesho", "Get all");
            Assert.AreEqual(2, listEvents.Count, "It does not return all events for user with username Get all!");
        }

        [Test]
        public void ChecksIfReturnsUserId()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int id = MainCommands.GetUserId("UserId", conn);
                Assert.AreEqual(17, id, "Does not return right id for user Test");
            }
        }

        [Test]
        public void CheckIfUploadsTask()
        {
            UserTask task = new UserTask("Testtt");
            TaskData.Upload(task, "Pesho", "UploadTest");
            List<UserTask> userTasks = TaskData.GetAll("Pesho", "UploadTest");
            Assert.AreEqual(1, userTasks.Count, "The task was not uploaded!");
        }

        //Korumpiran e
        [Test]
        public void CheckIfDeletesTask()
        {
            UserTask task = new UserTask("Testtt");
            TaskData.Delete(task, "Pesho", "UploadTest");
            List<UserTask> tasksAfterDeleting = TaskData.GetAll("Pesho", "UploadTest");

            Assert.AreEqual(0, tasksAfterDeleting.Count, "Task is not deleted!");
        }

        [Test]
        public void CheckIfUpdatesTask()
        {
            UserTask task = new UserTask("Update");
            TaskData.Upload(task, "Pesho", "UploadTest");
            task.IsDone = true;
            TaskData.Update(task, "Pesho", "UploadTest");
            List<UserTask> userTasks = TaskData.GetAll("Pesho", "UploadTest");
            Assert.AreEqual(task.IsDone, userTasks[0].IsDone, "The task was not uploaded!");
            TaskData.Delete(task, "Pesho", "UploadTest");
        }
    }
}
