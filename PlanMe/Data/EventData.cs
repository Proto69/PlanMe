using MySql.Data.MySqlClient;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Data
{
    public static class EventData
    {
        //Uploads text, date, time and info into the database
        public static bool Upload(Event action, string username)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int id = GetUserId(username, conn);

                string query = "INSERT INTO events (text, date, time, additional_info, user_id) " +
                    "VALUES (@text, @date, @time, @info, @user_id)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@text", action.Name);
                cmd.Parameters.AddWithValue("@date", action.Date);
                cmd.Parameters.AddWithValue("@time", action.Time);
                cmd.Parameters.AddWithValue("@info", action.Info);
                cmd.Parameters.AddWithValue("@user_id", id);

                return RunNonQuery(cmd);
            }
        }

        //Gets all events for current user
        public static List<Event> GetAll(string username)
        {
            List<Event> userEvents = new List<Event>();
            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn)
            {
                int id = GetUserId(username, conn);

                string query = "SELECT * FROM events WHERE user_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    TimeOnly time = TimeOnly.ParseExact(reader["time"].ToString(), "hh:mm:ss");
                    string info = reader["additinal_info"].ToString();
                    date.AddTicks(time.Ticks);
                    Event newEvent = new Event(name, date, time, info);
                    userEvents.Add(newEvent);
                }
            }
            return userEvents;
        }

        //Updates text, date, time and info for the event with new parameters
        public static bool Update(Event oldEvent, Event newEvent)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "UPDATE events SET text = @newName, date = @newDate, time = @newTime, additional_info = @newInfo " +
                    "WHERE text = @text AND date = @date AND time = @time";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@newName", newEvent.Name);
                cmd.Parameters.AddWithValue("@newDate", newEvent.Date);
                cmd.Parameters.AddWithValue("@newTime", newEvent.Time);
                cmd.Parameters.AddWithValue("@newInfo", newEvent.Info);
                cmd.Parameters.AddWithValue("@text", oldEvent.Name);
                cmd.Parameters.AddWithValue("@date", oldEvent.Date);
                cmd.Parameters.AddWithValue("@time", oldEvent.Time);

                return RunNonQuery(cmd);
            }
        }

        //Delete event by text, date and time for current user
        public static bool Delete(Event action)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "DELETE FROM events WHERE text = @text AND date = @date AND time = @time";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@text", action.Name);   
                cmd.Parameters.AddWithValue("@date", action.Date);   
                cmd.Parameters.AddWithValue("@time", action.Time);   

                return RunNonQuery(cmd);
            }
        }

        //Returns user's id for the event
        private static int GetUserId(string username, MySqlConnection conn)
        {
            string query = "SELECT id FROM users WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = cmd.ExecuteReader();

            int id = 0;

            while (reader.Read())
            {
                id = (int)reader["id"];
            }

            reader.Close();
            return id;
        }

        //Runs the command and returns if the operation was successful
        private static bool RunNonQuery(MySqlCommand cmd)
        {
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                return true;
            return false;
        }

    }
}
