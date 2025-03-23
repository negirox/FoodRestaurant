using FoodRestaurant.Models;
namespace FoodRestaurant.Repository.Abstract
{
    public interface IUserRepository
    {
        int CreateUser(User user);
    }
}
