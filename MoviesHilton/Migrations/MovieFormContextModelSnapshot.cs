// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesHilton.Models;

namespace MoviesHilton.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MoviesHilton.Models.MovieForm", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action/Adventure",
                            Director = "Peter Jackson",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Lord of The Rings The Return of The King",
                            Year = "2003"
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy",
                            Director = "John Landis",
                            Edited = false,
                            Rating = "PG",
                            Title = "The Three Amigos",
                            Year = "1986"
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Adventure/Comedy/Sci-Fi",
                            Director = "Dean Parisot",
                            Edited = false,
                            Rating = "PG",
                            Title = "Galaxy Quest",
                            Year = "1999"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
