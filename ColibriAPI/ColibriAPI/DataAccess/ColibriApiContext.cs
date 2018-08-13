using Microsoft.EntityFrameworkCore;

namespace ColibriAPI.DataAccess
{
    public class ColibriApiContext : DbContext
    {
        public ColibriApiContext(DbContextOptions<ColibriApiContext> options)
            : base(options)
        { }

        public DbSet<Models.Entities.Entry> Entries { get; set; }
        public DbSet<Models.Entities.Game> Games { get; set; }
        public DbSet<Models.Entities.Player> Players { get; set; }
        public DbSet<Models.Entities.Roster> Rosters { get; set; }
        public DbSet<Models.Entities.Team> Teams { get; set; }
        public DbSet<Models.Entities.Tournament> Tournaments { get; set; }
        public DbSet<Models.Entities.User> Users { get; set; }
    }
}
