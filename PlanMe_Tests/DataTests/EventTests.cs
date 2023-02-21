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
                int id = EventData.GetUserId("UserId", conn);
                Assert.AreEqual(23, id, "Does not return right id for user Test");
            }
        }

        [Test]
        public void CheckIfUploadsEvent()
        {
            Event @event = new Event("Birthday Party", DateTime.Now.Date.AddDays(new Random().Next(0, 365)),
                new TimeOnly(23, 10, 40), "Bring a gift!");
            EventData.Upload(@event, "UploadTest");
            List<Event> events = new List<Event>();
            events = EventData.GetAll("UploadTest");

            for (int i = 0; i < events.Count; i++)
            {
                Assert.AreEqual(@event, events[i], "The event is not uploaded successfully!");
            }
        }

    }
}
