namespace PlanMe.Data
{
    public static class Database
    {
        private static string connectionString = Secrets.connectionString;

        //Makes the connection to the database
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
