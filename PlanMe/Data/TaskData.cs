namespace PlanMe.Data
{
    public static class TaskData
    {
        // Adds task to the database for the current user
        public static bool Upload(UserTask task, string name)
        {
            // Get a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection in a using block to ensure proper disposal
            using (conn)
            {
                // Get the ID of the task list given its name
                int listId = MainCommands.GetListId(name, conn);

                // Construct a query to insert the task into the tasks table, with parameters for the list ID and the task's text
                string query = "INSERT INTO tasks (list_id, text) VALUES (@listId, @text)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add the list ID and task's text as parameters to the query
                cmd.Parameters.AddWithValue("@listId", listId);
                cmd.Parameters.AddWithValue("@text", task.Text);

                // Execute the query and return the result
                return MainCommands.RunNonQuery(cmd);
            }
        }


        // Returns all tasks for the current user
        public static List<UserTask> GetAll(string name)
        {
            // Create an empty list to store the retrieved tasks
            List<UserTask> userTasks = new List<UserTask>();

            // Get a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection in a using block to ensure proper disposal
            using (conn)
            {
                // Get the ID of the task list given its name
                int listId = MainCommands.GetListId(name, conn);

                // Construct a query to retrieve the text and completion status of all tasks in the specified list
                string query = "SELECT text, is_done FROM tasks WHERE list_id = @listId";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add the list ID as a parameter to the query
                cmd.Parameters.AddWithValue("@listId", listId);

                // Execute the query and get a reader object to iterate through the results
                MySqlDataReader reader = cmd.ExecuteReader();

                // Iterate through the results and create a new UserTask object for each row, then add it to the list of tasks
                while (reader.Read())
                {
                    string text = reader["text"].ToString();
                    bool isDone = (bool)reader["is_done"];
                    UserTask newTask = new UserTask(text, isDone);
                    userTasks.Add(newTask);
                }
            }

            // Return the list of retrieved tasks
            return userTasks;
        }

        // Updates the task for the current user
        public static bool Update(UserTask task, string name)
        {
            // Get a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection in a using block to ensure proper disposal
            using (conn)
            {
                // Get the ID of the task list given its name
                int listId = MainCommands.GetListId(name, conn);

                // Construct a query to update the is_done column of the specified task in the tasks table
                string query = "UPDATE tasks SET is_done = @is_done WHERE text = @text AND list_id = @list_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to the query for the task text, completion status, and list ID
                cmd.Parameters.AddWithValue("@text", task.Text);
                cmd.Parameters.AddWithValue("@is_done", task.IsDone);
                cmd.Parameters.AddWithValue("@list_id", listId);

                // Execute the query and return the result
                return MainCommands.RunNonQuery(cmd);
            }
        }

        // Deletes task for the current user
        public static bool Delete(UserTask task, string listName)
        {
            // Get a database connection and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection in a using block to ensure proper disposal
            using (conn)
            {
                // Get the ID of the task list given its name
                int listId = MainCommands.GetListId(listName, conn);

                // Construct a query to delete the specified task from the tasks table
                string query = "DELETE FROM tasks WHERE text = @text AND list_id = @list_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to the query for the task text and list ID
                cmd.Parameters.AddWithValue("@text", task.Text);
                cmd.Parameters.AddWithValue("@list_id", listId);

                // Execute the query and return the result
                return MainCommands.RunNonQuery(cmd);
            }
        }

    }
}
