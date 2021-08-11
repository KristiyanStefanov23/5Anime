using FiveAnime.Data.Models;
using FiveAnime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

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
            var animeList = businessLogic.FetchAllAnime();
            var episodeList = businessLogic.FetchAllEpisode();

            var animeAndEpisodeKVP = new KeyValuePair<List<Anime>, List<Episode>>(animeList, episodeList);

            return View(animeAndEpisodeKVP);
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
