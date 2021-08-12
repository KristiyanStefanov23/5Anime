using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FiveAnime.Controllers
{
    public class SearchController : Controller
    {
        private readonly Business.Business businessLogic;

        public SearchController(Business.Business businessLogic) => this.businessLogic = businessLogic;

        [HttpGet]
        public JsonResult Anime(string criteria)
        {
            var query = businessLogic.FetchAllAnime().Select(x => x.Title);
            return Json(query.ToList());
        }

        [HttpGet]
        public IActionResult Filter()
        {
            return View();
        }
    }
}
