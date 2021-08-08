using FiveAnime.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FiveAnime.Controllers
{
    public class HomeController : Controller
    {
        private readonly Business.Business businessLogic;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Business.Business businessLogic)
        {
            this._logger = logger;
            this.businessLogic = businessLogic;
        }

        public IActionResult Index()
        {
            var animeList = businessLogic.FetchAllRecentAnime();

            return View(animeList);
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
