namespace PlanMe.Data
{
    public static class EventData
    {
        // Uploads text, date, time and info into the database
        public static bool Upload(Event @event)
        {
            // Establish a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection object in a 'using' statement to ensure it gets closed properly
            using (conn)
            {
                // Get the user ID from the MainModels class
                int userId = MainModels.user.Id;

                // Define the SQL query to insert a new event into the events table
                string query = "INSERT INTO events (name, date, time, additional_info, user_id) " +
                    "VALUES (@name, @date, @time, @info, @user_id)";

                // Create a new command object with the query and connection objects
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add the event properties as parameters to the command object
                cmd.Parameters.AddWithValue("@name", @event.Name);
                cmd.Parameters.AddWithValue("@date", @event.Date);
                cmd.Parameters.AddWithValue("@time", @event.Time);
                cmd.Parameters.AddWithValue("@info", @event.Info);
                cmd.Parameters.AddWithValue("@user_id", userId);

                // Execute the command and return the result of the MainCommands.RunNonQuery method
                return MainCommands.RunNonQuery(cmd);
            }

        }

        // Gets all events for current user
        public static List<Event> GetAll()
        {
            List<Event> userEvents = new List<Event>();

            // Establish a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection object in a 'using' statement to ensure it gets closed properly
            using (conn)
            {
                // Get the user ID from the MainModels class
                int userId = MainModels.user.Id;

                // Define the SQL query to retrieve all events for the specified user
                string query = "SELECT * FROM events WHERE user_id = @userId";

                // Create a new command object with the query and connection objects
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add the user ID as a parameter to the command object
                cmd.Parameters.AddWithValue("@userId", userId);

                // Execute the query and retrieve a MySqlDataReader object
                MySqlDataReader reader = cmd.ExecuteReader();

                // Loop through each row in the reader object and create a new Event object for each one
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    TimeOnly time = TimeOnly.Parse(reader["time"].ToString());
                    string info = reader["additional_info"].ToString();
                    Event newEvent = new Event(name, date, time.ToString("HH:mm:ss"), info);

                    userEvents.Add(newEvent);
                }
            }

            // Return the list of Event objects
            return userEvents;

        }

        // Updates text, date, time and info for the event with new parameters
        public static bool Update(Event oldEvent, Event newEvent)
        {
            // Establish a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection object in a 'using' statement to ensure it gets closed properly
            using (conn)
            {
                // Define the SQL query to update the event with the specified name, date, and time
                string query = "UPDATE events SET name = @newName, date = @newDate, time = @newTime, additional_info = @newInfo " +
                                "WHERE name = @text AND date = @date AND time = @time";

                // Create a new command object with the query and connection objects
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters for the updated event data
                cmd.Parameters.AddWithValue("@newName", newEvent.Name);
                cmd.Parameters.AddWithValue("@newDate", newEvent.Date);
                cmd.Parameters.AddWithValue("@newTime", newEvent.Time);
                cmd.Parameters.AddWithValue("@newInfo", newEvent.Info);

                // Add parameters for the old event data to identify the event to be updated
                cmd.Parameters.AddWithValue("@text", oldEvent.Name);
                cmd.Parameters.AddWithValue("@date", oldEvent.Date);
                cmd.Parameters.AddWithValue("@time", oldEvent.Time);

                // Execute the query and retrieve the number of rows affected
                return MainCommands.RunNonQuery(cmd);
            }

        }

        // Delete event by text, date and time for current user
        public static bool Delete(Event action)
        {
            // Establish a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection object in a 'using' statement to ensure it gets closed properly
            using (conn)
            {
                // Define the SQL query to delete the event with the specified name, date, and time
                string query = "DELETE FROM events WHERE name = @name AND date = @date AND time = @time";

                // Create a new command object with the query and connection objects
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters for the event data to identify the event to be deleted
                cmd.Parameters.AddWithValue("@name", action.Name);
                cmd.Parameters.AddWithValue("@date", action.Date);
                cmd.Parameters.AddWithValue("@time", action.Time);

                // Execute the query and retrieve the number of rows affected
                return MainCommands.RunNonQuery(cmd);
            }
        }

    }
}
