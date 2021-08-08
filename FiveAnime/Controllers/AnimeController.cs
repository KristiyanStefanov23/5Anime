using Microsoft.AspNetCore.Mvc;
using FiveAnime.Business;
using System.Linq;
using System.Collections.Generic;
using FiveAnime.Data.Models;

namespace FiveAnime.Controllers
{
    public class AnimeController : Controller
    {
        private readonly Business.Business businessLogic;

        public AnimeController(Business.Business businessLogic) => this.businessLogic = businessLogic;

        public IActionResult SearchResult()
        {
            return View();
        }

        public IActionResult Anime(int id)
        {
            var animeToDisplay = businessLogic.FetchAllAnime().Where(x => x.Id == id).FirstOrDefault();
            var animeEpisodes = businessLogic.AnimeEpisodes(animeToDisplay);

            var currentAnimeAndEpisodes = new KeyValuePair<
                Anime, List<Episode>>(
                animeToDisplay, animeEpisodes);

            return View(currentAnimeAndEpisodes);
        }
    }
}
