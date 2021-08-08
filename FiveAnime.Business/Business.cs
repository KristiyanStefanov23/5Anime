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

        public List<Anime> FetchAllRecentAnime()
        {
            return dbContext.Animes.OrderBy(x => x.Year).ToList();
        }
    }
}