using FiveAnime.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace FiveAnime.Models
{
    public class EpisodeModel
    {
        [Required]
        public int AnimeId { get; set; }
        public Anime FromAnime { get; set; }
        public DateTime PublishDate { get; set; }
        [Required]
        public IFormFile EpisodeVideo { get; set; }
        public int EpisodeNumber { get; set; }
    }
}
