using MySql.Data.MySqlClient;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Data
{
    public static class ListOfTasksData
    {
        public static bool Upload(ListOfTasks listOfTasks)
        {
            //string username = MainModels.user.Username;
            string username = listOfTasks.Username;
            bool check = false;
            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "INSERT INTO list_of_tasks (user_id, name) VALUES (@id, @name)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", MainCommands.GetUserId(conn));
                cmd.Parameters.AddWithValue("@name", listOfTasks.Name);

                check = MainCommands.RunNonQuery(cmd);

                query = "INSERT INTO tasks (list_id, text) VALUES";
                
                int listId = MainCommands.GetListId(listOfTasks.Name, conn);

                List<string> list = new();

                foreach (var task in listOfTasks.Tasks)
                {
                    list.Add($"({listId}, \"{task.Text}\")");
                }

                if (list.Count == 0)
                    return check;

                string left = string.Join(",", list);
                query += left;

                cmd = new MySqlCommand(query, conn);

                check = MainCommands.RunNonQuery(cmd);
            }
            return check;
        }

        public static bool Remove(ListOfTasks listOfTasks)
        {
            listOfTasks.DeleteAllTasks();

            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                string query = "DELETE FROM list_of_tasks WHERE name = @name AND user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", listOfTasks.Name);
                //cmd.Parameters.AddWithValue("@user_id", MainCommands.GetUserId(MainModels.user.Username, conn));
                cmd.Parameters.AddWithValue("@user_id", MainCommands.GetUserId(conn));

                return MainCommands.RunNonQuery(cmd);
            }
        }

        public static List<ListOfTasks> GetAll(string username)
        {
            List<ListOfTasks> result = new List<ListOfTasks>();

            MySqlConnection conn = Database.GetConnection();
            conn.Open();
            using (conn)
            {
                int id = MainCommands.GetUserId(username, conn);
                string query = "SELECT name FROM list_of_tasks WHERE user_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    ListOfTasks tasks = new(name, username);
                    result.Add(tasks);
                }
            }
            return result;
        }
    }
}
