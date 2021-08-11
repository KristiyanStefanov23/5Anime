﻿using FiveAnime.Data;
using FiveAnime.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace FiveAnime.Business
{
    public class Business
    {
        private readonly ApplicationDbContext dbContext;

        public Business(ApplicationDbContext dbContext) => this.dbContext = dbContext;

        public void UploadAnime(Anime anime)
        {
            dbContext.Animes.Add(anime);
            dbContext.SaveChanges();
        }
        public void DeleteAnime(Anime anime)
        {
            dbContext.Animes.Remove(anime);
            dbContext.SaveChanges();
        }
        public void UploadEpisode(Episode episode)
        {
            dbContext.Episodes.Add(episode);
            dbContext.SaveChanges();
        }
        public void DeleteEpisode(Episode episode)
        {
            dbContext.Episodes.Remove(episode);
            dbContext.SaveChanges();
        }
        public void UploadFilter(Filter filter)
        {
            dbContext.Filters.Add(filter);
            dbContext.SaveChanges();
        }
        public void DeleteFilter(Filter filter)
        {
            dbContext.Filters.Remove(filter);
            dbContext.SaveChanges();
        }
        public List<KeyValuePair<int, string>> GetAllAnimesKVP() {
            var anime = new List<KeyValuePair<int, string>>();
            foreach (var animeFromDb in dbContext.Animes.OrderBy(x => x.Id))
            {
                var animeToAdd = new KeyValuePair<int, string>(animeFromDb.Id, animeFromDb.Title);
                anime.Add(animeToAdd);
            }

            return anime;
        }

        public List<Anime> FetchAllAnime() => dbContext.Animes.OrderBy(x => x.Year).ToList();
        public List<Episode> FetchAllEpisode() => dbContext.Episodes.OrderBy(x => x.AnimeId).ToList();
        public List<Filter> FetchAllFilters() => dbContext.Filters.OrderBy(x => x.FilterName).ToList();

        public List<Episode> AnimeEpisodes(int animeId) => dbContext.Episodes.Where(x => x.FromAnime.Id == animeId).ToList();
    }
}