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

            Random random = new Random();
            int randomId = random.Next(0, 390);

            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn)
            {
                string query = "SELECT phrase FROM daily_phrase WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", randomId);

                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    phrase = reader["phrase"].ToString();
                }
            }
            return phrase;
        }
    }
}
