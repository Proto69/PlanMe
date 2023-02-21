using MySql.Data.MySqlClient;
using PlanMe.Data;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlanMe_Tests.DataTests
{
    [TestFixture]
    public class EventTests
    {
        [Test]
        public void ChecksIfGetsAllEvents()
        {
            List<Event> listEvents = new List<Event>();
            listEvents = EventData.GetAll("Get all");
            Assert.AreEqual(1, listEvents.Count, "It does not return all events for user with username Get all!");
        }

        [Test]
        public void ChecksIfReturnsUserId()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int id = EventData.GetUserId("Get all", conn);
                Assert.AreEqual(22, id, "Does not return right id for user Test");
            }
        }

        [Test]
        public void CheckIfUploadsEvent()
        {
            //Generates the DateTime value
            DateTime date = DateTime.Now.Date.AddDays(new Random().Next(0, 365));

            //Creates the event
            Event @event = new Event("Birthday Party", date, "22:00:00", "Bring a gift!");

            //Uploads it and gets the returned value
            bool smth = EventData.Upload(@event, "UploadTest");

            Assert.AreEqual(true, smth, "The event is not uploaded successfully!");

            //Deletes the event afterwards
            EventData.Delete(@event);
        }

        [Test]
        public void CheckIfDeletesEvent()
        {
            DateTime date = DateTime.Now.Date.AddDays(new Random().Next(0, 365));
            TimeOnly time = new TimeOnly(23, 20, 40);

            Event @event = new Event("Birthday Party", date, time.ToString("HH:mm:ss"), "Bring a gift!");

            EventData.Upload(@event, "UploadTest");
            
            bool check = EventData.Delete(@event);

            Assert.AreEqual(check, true, "The event is not deleted!");
        }

        [Test]
        public void CheckIsUpdatesEvent()
        {
            List<Event> events = new List<Event>();
            events = EventData.GetAll("Enter name");
            Random random = new Random();
            string eventInfo = "Test updating " + random.Next().ToString();
            Event @event = new Event("Update test", DateTime.Parse("2023-02-21"), "16:51:43", eventInfo);

            EventData.Update(events[0], @event);

            events = new List<Event>();
            events = EventData.GetAll("Enter name");

            Assert.AreEqual(@event.Info, events[0].Info, "The event is not updated!");
        }

    }
}
