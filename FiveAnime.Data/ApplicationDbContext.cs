using FiveAnime.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FiveAnime.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Filter> Filters { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
