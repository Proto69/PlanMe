﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlanMe.Models
{
    public static class MainCommands
    {
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

        public static bool RunNonQuery(MySqlCommand cmd)
        {
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                return true;
            return false;
        }

        public static int GetListId(string name, MySqlConnection conn)
        {
            string query = "SELECT id FROM list_of_tasks WHERE name = @name";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = cmd.ExecuteReader();

            int id = 0;

            while (reader.Read())
            {
                id = (int)reader["id"];
            }

            reader.Close();
            return id;
        }
    }
}
