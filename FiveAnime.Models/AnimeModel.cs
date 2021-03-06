using FiveAnime.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiveAnime.Models
{
    public class AnimeModel
    {
        public int Id { get; set; }
        [Required]
        public IFormFile CoverImage { get; set; }
        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        [MinLength(5)]
        public string Description { get; set; }

        public List<int> FilterIds { get; set; }

        public ICollection<Episode> Episodes { get; set; }

        public ICollection<Filter> Filters { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Studio { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Season { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
        [Required]
        public bool IsDubbed { get; set; }
    }
}
