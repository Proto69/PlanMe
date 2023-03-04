﻿using MySql.Data.MySqlClient;
using PlanMe;
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
        [SetUp]
        public void SetUp()
        {
            User user = new User("EventTests", "EventTests123");
            MainModels.user = user;
        }

        [Test]
        public void ChecksIfGetsAllEvents()
        {
            List<Event> listEvents = new List<Event>();
            listEvents = EventData.GetAll("UserId");
            Assert.AreEqual(2, listEvents.Count, "It does not return all events for user with username Get all!");
        }

        [Test]
        public void CheckIfUploadsEvent()
        {
            //Generates the DateTime value
            DateTime date = DateTime.Now.Date.AddDays(new Random().Next(0, 365));

            //Creates the event
            Event @event = new Event("Upload Test", date, "22:00:00", "Testing upload event method!");

            //Uploads it and gets the returned value
            bool smth = EventData.Upload(@event, "EventTests");

            Assert.AreEqual(true, smth, "The event is not uploaded successfully!");

            //Deletes the event afterwards
            EventData.Delete(@event);
        }

        [Test]
        public void CheckIfDeletesEvent()
        {
            DateTime date = DateTime.Now.Date.AddDays(new Random().Next(0, 365));
            TimeOnly time = new TimeOnly(23, 20, 40);

            Event @event = new Event("Delete test", date, time.ToString("HH:mm:ss"), "Testing delete event method!");

            EventData.Upload(@event, "EventTests");
            
            bool check = EventData.Delete(@event);

            Assert.AreEqual(check, true, "The event is not deleted!");
        }

        [Test]
        public void CheckIsUpdatesEvent()
        {
            List<Event> events = new List<Event>();
            events = EventData.GetAll("EventTests");
            Random random = new Random();
            string eventInfo = "Test updating " + random.Next().ToString();
            Event @event = new Event("Update test", DateTime.Parse("2023-02-21"), "16:51:43", eventInfo);

            EventData.Update(events[0], @event);

            events = EventData.GetAll("EventTests");

            Assert.AreEqual(@event.Info, events[0].Info, "The event is not updated!");
        }

    }
}
