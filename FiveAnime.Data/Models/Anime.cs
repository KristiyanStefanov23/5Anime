using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiveAnime.Data.Models
{
    public class Anime
    {
        public int Id { get; set; }
        [Required]
        public string CoverImageUrl { get; set; }
        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MaxLength(250)]
        [MinLength(5)]
        public string Description { get; set; }

        public ICollection<Episode> Episodes { get; set; }

        public ICollection<Filter> Filters { get; set; }
        //special pannel info
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Type { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Studio { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Season { get; set; }
        [Required]
        [Range(1977, 2050)]
        public int Year { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
        [Required]
        public bool IsDubbed { get; set; }
    }
}
