using System;
using System.ComponentModel.DataAnnotations;

namespace ProvoTop5Restaurants.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank; 
        }

        [Required]
        public int Rank { get; }

        [Required]
        public string RestaurantName { get; set; }

        public string? FavDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? PhoneNum { get; set; } = "Not Available";

        public string? WebsiteLink { get; set; } = "Coming Soon";

        public string ImageSrc { get; set; }

        public static Restaurant[] GetRestaurants() // Create a list of restaurants

        {
            Restaurant r1 = new Restaurant(1) // Pass in the ranking, read only
            {
                RestaurantName = "R&R Barbecue",
                // Should populate FavDish with "It's all tasty!"
                Address = "4801 North University Avenue #490",
                PhoneNum = "801-281-5508",
                WebsiteLink = "https://randrbbq.com/menu/",
                ImageSrc = "randr.png"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Malawi's",
                FavDish = "Malawi Capri Pizza",
                Address = "4801 North University Avenue #110",
                PhoneNum = "801-225-2800",
                WebsiteLink = "https://malawispizza.com",
                ImageSrc = "malawis.png"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Happy Sumo",
                FavDish = "Venus Roll",
                Address = "4801 North University Avenue",
                PhoneNum = "801-225-9100",
                WebsiteLink = "https://happysumosushi.com/",
                ImageSrc = "happySumo.png"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Don Jaoquin Street Tacos",
                FavDish = "Tacos de Campechano",
                Address = "150 W 1230 N St",
                PhoneNum = "801-400-2894",
                WebsiteLink = "https://stdonjoaquin.com/",
                ImageSrc = "donTacos.png"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Spicy Thai",
                FavDish = "Spicy Thai",
                Address = "3230 N University Ave",
                PhoneNum = "801-370-0707",
                WebsiteLink = "https://www.spicythaiprovo.com/",
                ImageSrc = "spicyThai.png"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
