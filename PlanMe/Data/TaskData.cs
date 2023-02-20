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
        //Adds task to the database for the current user
        public static bool Upload(UserTask task, string username)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int userId = GetUserId(username, conn);
                string query = "INSERT INTO tasks (user_id, text) VALUES (@id, @text)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@text", task.Text);

                return RunNonQuery(cmd);
            }
        }

        //Returns all tasks for the current user
        public static List<UserTask> GetAll(string username)
        {
            List<UserTask> userTasks = new List<UserTask>();
            MySqlConnection conn = Database.GetConnection();

            conn.Open();
            using (conn) 
            {
                int id = GetUserId(username, conn);

                string query = "SELECT * FROM tasks WHERE user_id = @id";
                MySqlCommand cmd = new MySqlCommand(query,conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string text = reader["text"].ToString();
                    UserTask newTask = new UserTask(text);
                    userTasks.Add(newTask);
                }
            }
            return userTasks;
        }

        //Updates the task for the current user
        public static bool Update(UserTask task, string username)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "UPDATE tasks SET text = @text, is_done = @is_done";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@text", task.Text);
                cmd.Parameters.AddWithValue("@is_done", task.IsDone);

                return RunNonQuery(cmd);
            }
        }

        //Deletes task for the current user
        public static bool Delete(UserTask task)
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using(conn)
            {
                string query = "DELETE FROM tasks WHERE text = @text";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@text", task.Text);

                return RunNonQuery(cmd);
            }
        }

        //Returns user's id
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
