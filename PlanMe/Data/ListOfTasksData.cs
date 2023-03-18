namespace PlanMe.Data
{
    public static class ListOfTasksData
    {
        // This method uploads a list of tasks to the database
        public static bool Upload(ListOfTasks listOfTasks)
        {
            bool check = false;

            // Get a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection in a using block to ensure proper disposal
            using (conn)
            {
                // Construct a query to insert the new task list into the list_of_tasks table
                string query = "INSERT INTO list_of_tasks (user_id, name) VALUES (@id, @name)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to the query for the user ID and task list name
                cmd.Parameters.AddWithValue("@id", MainModels.user.Id);
                cmd.Parameters.AddWithValue("@name", listOfTasks.Name);

                // Execute the query and store the result
                return MainCommands.RunNonQuery(cmd);
            }
        }

        // This method removes list of tasks from the database
        public static bool Remove(ListOfTasks listOfTasks)
        {
            // Delete all tasks in the list
            listOfTasks.DeleteAllTasks();

            // Open a database connection
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            using (conn)
            {
                // Create a query to delete the list of tasks from the database
                string query = "DELETE FROM list_of_tasks WHERE name = @name AND user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Set parameters for the query
                cmd.Parameters.AddWithValue("@name", listOfTasks.Name);
                cmd.Parameters.AddWithValue("@user_id", MainModels.user.Id);

                // Execute the query and return the result
                return MainCommands.RunNonQuery(cmd);
            }
        }

        // This method updates list of tasks' name
        public static bool Update(string oldName, string newName)
        {
            // Get a connection to the MySQL database
            MySqlConnection conn = Database.GetConnection();

            // Open the connection and wrap it in a using statement to ensure proper disposal
            conn.Open();
            using (conn)
            {
                // Get the user ID of the logged-in user
                int userId = MainModels.user.Id;

                // Create a SQL query to update the name of the list with the specified old name and user ID
                // Set the new name using a parameter
                string query = "UPDATE list_of_tasks SET name = @newName WHERE name = @oldName AND user_id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters for the old name, new name, and user ID
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.Parameters.AddWithValue("@oldName", oldName);
                cmd.Parameters.AddWithValue("@userId", userId);

                // Execute the SQL query using the MySqlCommand object and the MainCommands class to run non-query SQL commands
                return MainCommands.RunNonQuery(cmd);
            }
        }

        // This method retrieves all the list of tasks belonging to a user identified by their username
        public static List<ListOfTasks> GetAll(string username)
        {
            List<ListOfTasks> result = new List<ListOfTasks>();

            // Establish a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection object in a 'using' statement to ensure it gets closed properly
            using (conn)
            {
                // Get the ID of the user from the MainModels class
                int id = MainModels.user.Id;

                // Define the query to retrieve the name of all the list of tasks for this user
                string query = "SELECT name FROM list_of_tasks WHERE user_id = @id";

                // Create a new command object with the query and connection objects
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add the user ID as a parameter to the command object
                cmd.Parameters.AddWithValue("@id", id);

                // Execute the query and retrieve a MySqlDataReader object
                MySqlDataReader reader = cmd.ExecuteReader();

                // Loop through each row in the reader object and create a new ListOfTasks object for each one
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    ListOfTasks tasks = new(name, username);
                    result.Add(tasks);
                }
            }

            // Return the list of ListOfTasks objects
            return result;
        }

    }
}
