using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlanMe.Data
{
    public static class PhraseData
    {
        //Returns phrase from PlanMe_DB/phrase
        public static string GetPhrase()
        {
            string phrase = "";

            //Gets a random id for choosing the phrase
            Random random = new Random();
            int id = GetID();

            //Creates a connection and uses it
            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn)
            {
                //Prepares the query with placeholders
                string query = "SELECT phrase FROM phrase WHERE id = @id";

                //Creates the command and adds the values
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                //Starts the reader and reads the result
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                phrase = reader["phrase"].ToString();
            }
            return phrase;
        }


        public static int GetID()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            int id = 0;
            using (conn)
            {
                string query = "SELECT date, phrase_id FROM check_time";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    int phraseID = (int)reader["phrase_id"];
                    if (date == DateTime.Now.Date)
                        return phraseID;

                }
                Random random = new Random();
                id = random.Next(0, 390);
                string query2 = "UPDATE check_time SET phrase_id = @newPhrase_id, date = @newDate";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);

                cmd.Parameters.AddWithValue("@newDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@newPhrase_id", id);
            }
            return id;
        }
    }
}
