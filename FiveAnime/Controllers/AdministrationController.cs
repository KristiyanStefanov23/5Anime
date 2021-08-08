using FiveAnime.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FiveAnime.Business.CloudinaryData;
using FiveAnime.Models;

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

        public IActionResult Create()
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

        [HttpPost]
        public IActionResult CreateEpisode(Episode episode)
        {
            if (!ModelState.IsValid) return View(episode);
            var videoUrl = cloudinaryService.Video(episode.EpisodeVideo, "AnimeVideos");
            return RedirectToAction(nameof(HomeController.Index));
        }

        #endregion

        #region EditOperation

        public IActionResult Manage()
        {
            return View();
        }

        #endregion
    }
}
