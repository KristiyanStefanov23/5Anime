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
        private readonly CloudinaryService cloudinaryService;

        public AdministrationController(Business.Business businessLogic, CloudinaryService cloudinaryService)
        {
            this.businessLogic = businessLogic;
            this.cloudinaryService = cloudinaryService;
        }

        public IActionResult Index()
        {
            return View();
        }

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
    }
}
