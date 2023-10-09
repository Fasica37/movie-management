using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace movie_management.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Jacky Chan" },
                new Actor { Id = 2, Name = "Girum Erimias" },
                new Actor { Id = 3, Name = "Abebe Belew" }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Toxido", Description = "dkfjal dfda", ActorId = 1 },
                new Movie { Id = 2, Name = "The box", Description = "dkfjal dfda", ActorId = 3 },
                new Movie { Id = 3, Name = "Amalayu", Description = "dkfjal dfda", ActorId = 2 }
            );
        }
    }
}