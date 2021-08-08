using FiveAnime.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace FiveAnime.Models
{
    public class EpisodeModel
    {
        public int AnimeId { get; set; }
        [Required]
        public Anime FromAnime { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public IFormFile EpisodeVideo { get; set; }
    }
}
