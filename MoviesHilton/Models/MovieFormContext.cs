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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );
            mb.Entity<MovieForm>().HasData(
                new MovieForm
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Lord of The Rings The Return of The King",
                    Year = "2003",
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false
                },
                new MovieForm
                {
                MovieId = 2,
                    CategoryId = 2,
                    Title = "The Three Amigos",
                    Year = "1986",
                    Director = "John Landis",
                    Rating = "PG",
                    Edited = false
                },
                new MovieForm
                {
                    MovieId = 3,
                        CategoryId = 2,
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
