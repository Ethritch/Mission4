using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHilton.Models
{
    public class MovieFormContext : DbContext
    {
        //Contructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {

        }

        public DbSet<MovieForm> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(
                new MovieForm
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "The Lord of The Rings The Return of The King",
                    Year = "2003",
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false
                },
                new MovieForm
                {
                MovieId = 2,
                    Category = "Comedy",
                    Title = "The Three Amigos",
                    Year = "1986",
                    Director = "John Landis",
                    Rating = "PG",
                    Edited = false
                },
                new MovieForm
                {
                    MovieId = 3,
                        Category = "Adventure/Comedy/Sci-Fi",
                        Title = "Galaxy Quest",
                        Year = "1999",
                        Director = "Dean Parisot",
                        Rating = "PG",
                        Edited = false
                    }

                );
        }

    }
}
