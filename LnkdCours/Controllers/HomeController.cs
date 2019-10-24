using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LnkdCours.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Distributed;

namespace LnkdCours.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _config;

        private readonly IDistributedCache _cache;

        public HomeController(ILogger<HomeController> logger, IConfiguration config, IDistributedCache cache)
        {
            _logger = logger;
            _config = config;
            _cache = cache;
        }

        public IActionResult Index()
        {
            ViewBag.BgColor = _config.GetValue<string>("BgColor");

            ViewBag.Region = _config.GetValue<string>("Region");


            string value = _cache.GetString("CacheDateTime");

            if (value == null)
            {
                value = DateTime.Now.ToString();

                var options = new DistributedCacheEntryOptions { 
                SlidingExpiration = TimeSpan.FromMinutes(1)
                };
 
                _cache.SetString("CacheDateTime", value, options);
            }

            ViewData["CacheDateTime"] = null;
          
            return View();
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
