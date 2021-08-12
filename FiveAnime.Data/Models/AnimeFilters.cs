using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveAnime.Data.Models
{
    public class AnimeFilters
    {
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
        public int FilterId { get; set; }
        public Filter Filter { get; set; }
    }
}
