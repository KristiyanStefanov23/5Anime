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
            var animeEpisodes = businessLogic.AnimeEpisodes(animeToDisplay.Id);

            ViewBag.Filters = businessLogic.AnimeFilters(id);

            var currentAnimeAndEpisodes = new KeyValuePair<
                Anime, List<Episode>>(
                animeToDisplay, animeEpisodes);

            return View(currentAnimeAndEpisodes);
        }

        public IActionResult Watch(int episodeId, int animeId)
        {
            var anime = businessLogic.FetchAllAnime().Where(x => x.Id == animeId).FirstOrDefault();
            var allEpisodes = businessLogic.AnimeEpisodes(animeId);
            int currentEpisode = allEpisodes.IndexOf(allEpisodes.Where(x => x.Id == episodeId).FirstOrDefault());
            ViewBag.crEp = currentEpisode;

            var currentAnimeAndEpisodes = new KeyValuePair<
                Anime, List<Episode>>(
                anime, allEpisodes
                );
            return View(currentAnimeAndEpisodes);
        }

        public IActionResult Search(string searchResult)
        {
            var searchResultKVP = new KeyValuePair<
                string, List<Anime>>(
                searchResult, businessLogic.FetchAllAnime().Where(x => x.Title.ToLower().StartsWith(searchResult.ToLower())).ToList()
                );

            return View(searchResultKVP);
        }
    }
}
