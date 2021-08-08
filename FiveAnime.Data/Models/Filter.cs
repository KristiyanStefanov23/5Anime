using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiveAnime.Data.Models
{
    public class Filter
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string FilterName { get; set; }
        public ICollection<Anime> AnimeWithFilter { get; set; }
    }
}
