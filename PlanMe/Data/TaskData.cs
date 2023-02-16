using MySql.Data.MySqlClient;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Data
{
    public static class TaskData
    {
        public static bool Upload(UserTask task, string username)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int userId = GetUserId(username, conn);
                string query = "INSERT INTO lists (user_id, text) VALUES (@id, @text)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@text", task.Name);

                return RunNonQuery(cmd);
            }
        }

        public static List<UserTask> GetAll(string username)
        {
            throw new NotImplementedException();
        }

        public static bool Update(UserTask task, string username)
        {
            throw new NotImplementedException();
        }

        public static bool Delete(UserTask task, string username)
        {
            throw new NotImplementedException();
        }

        //Returns user's id
        private static int GetUserId(string username, MySqlConnection conn)
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

        //Runs the command and returns if the operation was successful
        private static bool RunNonQuery(MySqlCommand cmd)
        {
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                return true;
            return false;
        }
    }
}
