using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveAnime.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult SearchResult()
        {
            return View();
        }

        public IActionResult Anime(int id)
        {


            return View();
        }
    }
}
