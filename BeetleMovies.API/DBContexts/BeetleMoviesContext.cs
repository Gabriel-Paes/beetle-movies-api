using Microsoft.EntityFrameworkCore;

namespace BeetleMovies.API;

public class BeetleMoviesContext(DbContextOptions<BeetleMoviesContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Director> Directors { get; set; }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
