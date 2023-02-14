using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Data
{
    public static class PhraseData
    {
        public static string GetPhrase()
        {
            string phrase = "";

            //Gets a random id for choosing the phrase
            Random random = new Random();
            int randomId = random.Next(DateTime.Now.Day, DateTime.Now.Day + 360);

            //Creates a connection and uses it
            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn)
            {
                //Prepares the query with placeholders
                string query = "SELECT phrase FROM daily_phrase WHERE id = @id";

                //Creates the command and adds the values
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", randomId);

                //Starts the reader and reads the result
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                
                phrase = reader["phrase"].ToString();
            }
            return phrase;
        }
    }
}
