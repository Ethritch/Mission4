﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesHilton.Models;

namespace MoviesHilton.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20220202042540_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MoviesHilton.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("MoviesHilton.Models.MovieForm", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

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

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Lord of The Rings The Return of The King",
                            Year = "2003"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "John Landis",
                            Edited = false,
                            Rating = "PG",
                            Title = "The Three Amigos",
                            Year = "1986"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 2,
                            Director = "Dean Parisot",
                            Edited = false,
                            Rating = "PG",
                            Title = "Galaxy Quest",
                            Year = "1999"
                        });
                });

            modelBuilder.Entity("MoviesHilton.Models.MovieForm", b =>
                {
                    b.HasOne("MoviesHilton.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}