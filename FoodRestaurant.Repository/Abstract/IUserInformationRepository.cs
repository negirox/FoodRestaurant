using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodRestaurant.Models;

namespace FoodRestaurant.Repository.Abstract
{
    public interface IUserInformationRepository
    {
        int CreateUserInformation(UserInformation userInformation);
    }
}
