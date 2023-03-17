namespace PlanMe.Data
{
    public static class UserData
    {
        //Creates user
        public static bool Create(User user)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                bool smth = MainCommands.RunNonQuery(cmd);

                MainModels.user.Id = MainCommands.GetUserId(user.Username, conn);

                return smth;
            }
        }

        //Updates user's password
        public static bool UpdatePassword(User user)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "UPDATE users SET password = @password WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@username", user.Username);

                return MainCommands.RunNonQuery(cmd);
            }
        }

        //Delete user by his username
        public static bool Delete(string username)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "DELETE FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);

                return MainCommands.RunNonQuery(cmd);
            }
        }

        //Checks if the username and password are valid and returns the User
        public static User Check(string username, string password)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "SELECT username, password FROM users WHERE BINARY username = @username";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                MySqlDataReader reader = cmd.ExecuteReader();

                string user_password = null;
                string newUsername = null;

                if (reader.HasRows)
                {
                    reader.Read();

                    user_password = reader["password"].ToString();
                    newUsername = reader["username"].ToString();
                }
                 
                reader.Close();
                if (password == user_password && newUsername == username)
                {
                    User user = new User(username, user_password);
                    user.Id = MainCommands.GetUserId(username, conn);
                    return user;
                }

                throw new ArgumentException("Invalid username or password!");
            }
        }

    }
}
