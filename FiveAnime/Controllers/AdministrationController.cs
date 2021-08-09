using FiveAnime.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FiveAnime.Business.CloudinaryData;
using FiveAnime.Models;
using System.Linq;

namespace FiveAnime.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private Business.Business businessLogic;
        private readonly ICloudinaryService cloudinaryService;

        public AdministrationController(Business.Business businessLogic, ICloudinaryService cloudinaryService)
        {
            this.businessLogic = businessLogic;
            this.cloudinaryService = cloudinaryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OperationList()
        {
            return View();
        }

        #region CreateOperation

        public IActionResult CreateAnime()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAnime(AnimeModel anime)
        {
            if (!ModelState.IsValid) return View(anime);

            var imageUrl = cloudinaryService.Image(anime.CoverImage, "AnimeCoverImages");
            var animeToUpload = new Anime()
            {
                CoverImageUrl = imageUrl,
                Title = anime.Title,
                Description = anime.Description,
                Episodes = anime.Episodes,
                Filters = anime.Filters,
                Type = anime.Type,
                Studio = anime.Studio,
                Season = anime.Season,
                Year = anime.Year,
                IsCompleted = anime.IsCompleted,
                IsDubbed = anime.IsDubbed
            };
            businessLogic.UploadAnime(animeToUpload);

            return RedirectToAction(nameof(HomeController.Index));
        }

        public IActionResult CreateEpisode()
        {
            ViewBag.AnimeList = businessLogic.GetAllAnimesKVP();

            return View();
        }

        [HttpPost]
        public IActionResult CreateEpisode(EpisodeModel episode)
        {
            ViewBag.AnimeList = businessLogic.GetAllAnimesKVP();
            if (!ModelState.IsValid) return View(episode);

            var videoUrl = cloudinaryService.Video(episode.EpisodeVideo, "AnimeVideos");
            var videoToUpload = new Episode()
            {
                EpisodeVideoUrl = videoUrl,
                FromAnime = businessLogic.FetchAllAnime().Where(x => x.Id == episode.AnimeId).FirstOrDefault(),
                AnimeId = episode.AnimeId,
                PublishDate = System.DateTime.UtcNow
            };
            businessLogic.UploadEpisode(videoToUpload);

            return RedirectToAction(nameof(HomeController.Index));
        }

        public IActionResult CreateFilter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFilter(FilterModel filter)
        {
            if (!ModelState.IsValid) return View(filter);

            return RedirectToAction(nameof(HomeController.Index));
        }

        #endregion

        #region ManageOperation

        public IActionResult ManageAnime()
        {
            var animeList = businessLogic.FetchAllAnime();

            return View(animeList);
        }

        public IActionResult DeleteAnime(int id)
        {
            var anime = businessLogic.FetchAllAnime().Where(x => x.Id == id).FirstOrDefault();

            return View(anime);
        }

        [HttpPost]
        public IActionResult DeleteAnimeConfirm(int id)
        {
            var animeToDelete = businessLogic.FetchAllAnime().Where(x => x.Id == id).FirstOrDefault();
            businessLogic.DeleteAnime(animeToDelete);

            return RedirectToAction(nameof(HomeController.Index));
        }

        #region Episode

        public IActionResult ManageEpisode(int id)
        {
            var episodeList = businessLogic.AnimeEpisodes(id);

            return View(episodeList);
        }

        public IActionResult DeleteEpisode(int id)
        {
            var episode = businessLogic.AnimeEpisodes(id);

            return View(episode);
        }

        [HttpPost]
        public IActionResult DeleteEpisodeConfirm(int id)
        {
            var episodeToDelete = businessLogic.AnimeEpisodes(id).Where(x => x.Id == id).FirstOrDefault();
            businessLogic.DeleteEpisode(episodeToDelete);

            return RedirectToAction(nameof(HomeController.Index));
        }
        #endregion

        #endregion
    }
}
