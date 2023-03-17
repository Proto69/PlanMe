using MySql.Data.MySqlClient;

namespace PlanMe_Tests.DataTests
{
    [TestFixture]
    public class TaskDataTests
    {
        [SetUp]
        public void SetUp()
        {
            User user = new User("TaskTests", "TaskTests1234");
            MainModels.user = user;
            MainModels.user.FillEventsAndTasks();
            MainModels.user.Id = 90;
        }

        [Test]
        public void ChecksIfGetsAllTasks()
        {
            MainModels.user.Id = 1;
            List<UserTask> listEvents = new List<UserTask>();
            listEvents = TaskData.GetAll("Get all test");
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
            UserTask task = new UserTask("UploadTest");
            TaskData.Upload(task, "Update task");
            List<UserTask> userTasks = TaskData.GetAll("Update task");
            Assert.AreEqual(1, userTasks.Count, "The task was not uploaded!");
            TaskData.Delete(task, "Update task");
        }
       
        [Test]
        public void CheckIfDeletesTask()
        {
            UserTask task1 = new UserTask("DeleteTest1");
            UserTask task2 = new UserTask("DeleteTest2");

            TaskData.Upload(task1, "Update task");
            TaskData.Upload(task2, "Update task");

            TaskData.Delete(task1, "Update task");

            List<UserTask> tasksAfterDeleting = TaskData.GetAll("Update task");

            Assert.AreEqual(1, tasksAfterDeleting.Count, "Task is not deleted!");
            TaskData.Delete(task2, "Update task");
        }

        [Test]
        public void CheckIfUpdatesTask()
        {
            UserTask task = new UserTask("Update");
            TaskData.Upload(task, "Update task");

            task.IsDone = true;
            TaskData.Update(task, "Update task");

            List<UserTask> userTasks = TaskData.GetAll("Update task");
            Assert.AreEqual(task.IsDone, userTasks[0].IsDone, "The task was not uploaded!");

            TaskData.Delete(task, "Update task");
        }
    }
}
