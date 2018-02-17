using Microsoft.EntityFrameworkCore;

namespace ColibriAPI.DataAccess
{
    public class ColibriApiContext : DbContext
    {
        public ColibriApiContext(DbContextOptions<ColibriApiContext> options)
            : base(options)
        { }

        public DbSet<Models.Entities.User> Users { get; set; }
    }
}
