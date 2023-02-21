using MySql.Data.MySqlClient;
using PlanMe.Models;

namespace PlanMe
{
    public class DataController
    {
        //Creates user by getting name and pass from the view
        public bool CreateUser(string name, string pass)
        {
            return default;
        }

        //Updates user's password
        public void UpdateUserPassword(User user)
        {
            throw new NotImplementedException();
        }

        //Deletes a user specified, from the view
        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

    }
}