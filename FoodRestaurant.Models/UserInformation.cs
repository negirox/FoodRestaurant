using System;

namespace FoodRestaurant.Models
{
    public class UserInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public byte[] UserImage { get; set; }
        public string AadharNo { get; set; }
    }
}
