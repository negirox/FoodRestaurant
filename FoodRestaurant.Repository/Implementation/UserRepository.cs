using System.Data;
using System.Data.SqlClient;
using FoodRestaurant.Models;
using FoodRestaurant.Repository.Abstract;

namespace FoodRestaurant.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int CreateUser(User user)
        {
            int isCreated = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("CreateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    connection.Open();
                   isCreated = command.ExecuteNonQuery();
                }
            }
            return isCreated;
        }
    }
}
