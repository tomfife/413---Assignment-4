using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoTop5Restaurants.Models;

namespace ProvoTop5Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Restaurant> restaurantList = new List<Restaurant>(); // Make a list of Restaurant objects 

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add(r);
            }

            return View(restaurantList);
        }

        [HttpPost]
        public IActionResult Suggestions(Suggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(suggestion);
                return View("Confirmation", suggestion);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        public IActionResult SuggestionCollection()
        {
            List<Suggestion> Suggestions = new List<Suggestion>();

            foreach (Suggestion x in TempStorage.Suggestions)
            {
                if (x.FavDish is null)
                {
                    x.FavDish = "It's all tasty!";
                }
                Suggestions.Add(x);
            }
            return View(Suggestions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
