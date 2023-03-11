namespace PlanMe.Models
{
    public static class MainCommands
    {
        public static int GetUserId(string username, MySqlConnection conn)
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

        public static int GetUserId(MySqlConnection conn)
        {
            return GetUserId(MainModels.user.Username, conn);
        }

        public static bool RunNonQuery(MySqlCommand cmd)
        {
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                return true;
            return false;
        }

        public static int GetListId(string name, string username, MySqlConnection conn)
        {
            string query = "SELECT id FROM list_of_tasks WHERE name = @name AND user_id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", GetUserId(username, conn));
            MySqlDataReader reader = cmd.ExecuteReader();

            int id = 0;

            while (reader.Read())
            {
                id = (int)reader["id"];
            }

            reader.Close();
            return id;
        }

        public static int GetListId(string name, MySqlConnection conn)
        {
            return GetListId(name, MainModels.user.Username, conn);
        }
    }
}
