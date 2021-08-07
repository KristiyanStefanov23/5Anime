using _5Anime.Web.Data;
using System;

namespace _5Anime.Data
{
    public class Business
    {
        private readonly ApplicationDbContext dbContext;

        public Business(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
