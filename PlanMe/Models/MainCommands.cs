namespace PlanMe.Models
{
    public static class MainCommands
    {
        //Command to get user id by username
        public static int GetUserId(string username, MySqlConnection conn)
        {
            //MySQL query and creating new command
            string query = "SELECT id FROM users WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            
            //Adding parameter to the command
            cmd.Parameters.AddWithValue("@username", username);

            //Executing reader to read values from the result of the query
            MySqlDataReader reader = cmd.ExecuteReader();

            //The reader reads the returned row
            reader.Read();
            
            //Gets the value in column "id"
            int id = (int)reader["id"];

            //Closing the reader to avoid conflicts
            reader.Close();

            return id;
        }

        //Using this method to run queries that don't return anything
        public static bool RunNonQuery(MySqlCommand cmd)
        {
            //Running the command and getting the value of changed rows
            int rows = cmd.ExecuteNonQuery();

            //If it is 1, the command was successful and we return true
            if (rows == 1)
                return true;
            return false;
        }

        //Command to get the id of a list
        public static int GetListId(string name, MySqlConnection conn)
        {
            //MySQL query that will return id of a list
            string query = "SELECT id FROM list_of_tasks WHERE name = @name AND user_id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //We fill the command with parameters
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", MainModels.user.Id);

            //Execute the reader 
            MySqlDataReader reader = cmd.ExecuteReader();

            int id = 0;

            //Reading the value and assigning it to a variable
            while (reader.Read())
            {
                id = (int)reader["id"];
            }

            //Closing the reader and returning the result
            reader.Close();
            return id;
        }
    }
}
