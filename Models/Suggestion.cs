using System;
using System.ComponentModel.DataAnnotations;

namespace ProvoTop5Restaurants.Models
{
    public class Suggestion
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        public string? FavDish { get; set; } = "It's all tasty!";

        [Required]
        [Phone]
        [MinLength(7)]
        public string PhoneNum { get; set; }
        // need to make sure we get the phone number in the right format
    }
}
