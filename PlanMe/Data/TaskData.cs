namespace PlanMe.Data
{
    public static class TaskData
    {
        //Adds task to the database for the current user
        public static bool Upload(UserTask task, string name)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int listId = MainCommands.GetListId(name, conn);
                string query = "INSERT INTO tasks (list_id, text) VALUES (@listId, @text)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@listId", listId);
                cmd.Parameters.AddWithValue("@text", task.Text);

                return MainCommands.RunNonQuery(cmd);
            }
        }

        //Returns all tasks for the current user
        public static List<UserTask> GetAll(string name, string username)
        {
            List<UserTask> userTasks = new List<UserTask>();
            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn) 
            {
                int listId = MainCommands.GetListId(name, username, conn);

                string query = "SELECT text, is_done FROM tasks WHERE list_id = @listId";
                MySqlCommand cmd = new MySqlCommand(query,conn);

                cmd.Parameters.AddWithValue("@listId", listId);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string text = reader["text"].ToString();
                    bool isDone = (bool)reader["is_done"];
                    UserTask newTask = new UserTask(text, isDone);
                    userTasks.Add(newTask);
                }
            }
            return userTasks;
        }

        //Updates the task for the current user
        public static bool Update(UserTask task, string name)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int listId = MainCommands.GetListId(name, conn);

                string query = "UPDATE tasks SET is_done = @is_done WHERE text = @text AND list_id = @list_id";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@text", task.Text);
                cmd.Parameters.AddWithValue("@is_done", task.IsDone);
                cmd.Parameters.AddWithValue("@list_id", listId);

                return MainCommands.RunNonQuery(cmd);
            }
        }

        //Deletes task for the current user
        public static bool Delete(UserTask task, string listName)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using(conn)
            {
                int listId = MainCommands.GetListId(listName, conn);

                string query = "DELETE FROM tasks WHERE text = @text AND list_id = @list_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@text", task.Text);
                cmd.Parameters.AddWithValue("@list_id", listId);

                return MainCommands.RunNonQuery(cmd);
            }
        }

    }
}
