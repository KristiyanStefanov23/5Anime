using System;
using System.ComponentModel.DataAnnotations;

namespace FiveAnime.Data.Models
{
    public class Episode
    {
        public int Id { get; set; }
        [Required]
        public int AnimeId { get; set; }
        [Required]
        public Anime FromAnime { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public string EpisodeVideoUrl { get; set; }
        [Required]
        public int EpisodeNumber { get; set; }
    }
}