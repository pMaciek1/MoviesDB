using Microsoft.EntityFrameworkCore;

namespace MoviesDB.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movies {  get; set; }
        public DbSet<MovieToWatch> MoviesToWatch { get; set;}
    }
}
