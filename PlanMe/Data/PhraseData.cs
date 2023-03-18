namespace PlanMe.Data
{
    public static class PhraseData
    {
        // Returns phrase from PlanMe_DB/phrase
        public static string GetPhrase()
        {
            string phrase = "";

            // Gets a random id for choosing the phrase
            int id = GetID();

            // Creates a connection and uses it
            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn)
            {
                // Prepares the query with placeholders
                string query = "SELECT phrase FROM phrase WHERE id = @id";

                // Creates the command and adds the values
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                // Starts the reader and reads the result
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                phrase = reader["phrase"].ToString();
            }
            return phrase;
        }

        // Returns phrase's id to know which phrase to pick up
        public static int GetID()
        {
            // Creates connection and opens it
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            // Defines the later returned id
            int id = 0;
            using (conn)
            {
                // Command to get date and id
                string query = "SELECT date, phrase_id FROM check_time";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Reads the first row and saves the values
                reader.Read();

                DateTime date = DateTime.Parse(reader["date"].ToString());
                int phraseID = (int)reader["phrase_id"];

                // If the date is the same as today, returns the id from the database
                if (date == DateTime.Now.Date)
                    return phraseID;

                // Closes the reader 
                reader.Close();

                // Defines the random and sets random id for phrase 
                Random random = new Random();
                id = random.Next(0, 390);

                // Retypes the command to update the date and id in the database
                // to the new ones
                query = "UPDATE check_time SET phrase_id = @newPhrase_id, date = @newDate";
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@newDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@newPhrase_id", id);
                 
                // Executes like this, because it is just an update
                cmd.ExecuteNonQuery();
            }

            // Returns the new id for the day
            return id;
        }
    }
}
