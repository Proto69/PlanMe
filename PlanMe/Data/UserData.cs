namespace PlanMe.Data
{
    public static class UserData
    {
        // Creates user
        public static bool Create(User user)
        {
            // Gets the connection and opens it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Starts using the connection
            using (conn)
            {
                // Creates MySQL query and command to insert values into users table
                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Fills the command with parameters
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                // Runs the command and saves the returned bool value
                bool result = MainCommands.RunNonQuery(cmd);

                // If the command has been successful, we set the main user 
                if (result)
                {
                    MainModels.user = user;
                    MainModels.user.Id = MainCommands.GetUserId(user.Username, conn);
                }

                return result;
            }
        }

        // Delete user by his username
        public static bool Delete(string username)
        {
            // Get a connection to the database and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection
            using (conn)
            {
                // Construct the SQL query to delete the user with the given username
                string query = "DELETE FROM users WHERE username = @username";

                // Create a MySql command to execute the SQL query
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Set the parameter value for the username
                cmd.Parameters.AddWithValue("@username", username);

                // Execute the SQL query and return the result
                return MainCommands.RunNonQuery(cmd);
            }
        }

        // Checks if the username and password are valid and returns the User
        public static User Check(string username, string password)
        {
            // Get a connection to the database and open it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Use the connection
            using (conn)
            {
                // Construct the SQL query to retrieve the user with the given username
                // The BINARY keyword is used to perform a case-sensitive comparison
                string query = "SELECT username, password FROM users WHERE BINARY username = @username";

                // Create a MySql command to execute the SQL query
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Set the parameter value for the username
                cmd.Parameters.AddWithValue("@username", username);

                // Execute the SQL query and get a reader to read the results
                MySqlDataReader reader = cmd.ExecuteReader();

                // Declare variables to store the user's password and username
                string user_password = null;

                // If the username was found in the database
                if (reader.HasRows)
                {
                    // Read the first row of the result set
                    reader.Read();

                    // Get the password and username values from the row
                    user_password = reader["password"].ToString();
                }

                // Close the reader
                reader.Close();

                // If the given password matches the user's password
                if (password == user_password)
                {
                    // Create a new User object with the given username and password
                    User user = new User(username, user_password);

                    // Gets and sets the user's ID from the database using the MainCommands.GetUserId method
                    user.Id = MainCommands.GetUserId(username, conn);

                    // Return the User object
                    return user;
                }

                // If the username or password is incorrect, throw an ArgumentException with an error message
                throw new ArgumentException("Invalid username or password!");
            }
        }
    }
}
