using HiltonMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonMovies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDBContext _movieContext { get; set; }

        // constructor, constructs model context
        public HomeController(ILogger<HomeController> logger, MovieDBContext data)
        {
            _logger = logger;
            _movieContext = data;
        }

        // returns the home page
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // returns the podcast info page
        public IActionResult Bacon()
        {
            return View();
        }

        // returns the page view for the new movie form
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        // posts the new movie entered by the user to the model database
        [HttpPost]
        public IActionResult Movies(MovieDatabase newMovie)
        {
            _movieContext.Add(newMovie);
            _movieContext.SaveChanges();

            return View("Confirmation", newMovie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
