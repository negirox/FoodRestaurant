using System.Data;
using System.Data.SqlClient;
using FoodRestaurant.Models;
using FoodRestaurant.Repository.Abstract;

namespace FoodRestaurant.Repository
{
    public class UserInformationRepository: IUserInformationRepository
    {
        private readonly string _connectionString;

        public UserInformationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int CreateUserInformation(UserInformation userInformation)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("CreateUserInformation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", userInformation.Name);
                    command.Parameters.AddWithValue("@Email", userInformation.Email);
                    command.Parameters.AddWithValue("@DOB", userInformation.DOB);
                    command.Parameters.AddWithValue("@Address", userInformation.Address);
                    command.Parameters.AddWithValue("@UserImage", userInformation.UserImage ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@AadharNo", userInformation.AadharNo);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            return 0;
            

        }
    }
}
