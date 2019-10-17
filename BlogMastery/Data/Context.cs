using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogMastery.Models;

namespace BlogMastery.Data
{
    public class Context : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Blog;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(sc => new { sc.PostId, sc.TagId });

            modelBuilder.Entity<Post>().HasData(
               new Post()
               {
                   Id = 1,
                   Title = "Harry Potter",
                   Body = "A sorcerer lost his parents and is taken in by his horrible aunt. The scorcerer's name is Harry Potter and he starts his new life with many adventures as he attends Hogwarts School of Witchcraft and Wizardry, learns how to perform magic and comes face to face with his archenemy, Lord Voldemort.",
                   Reviewer = "Jk Rowling",
                   DateTime = DateTime.Now,
                   GenreId = 4,
               },
              
               new Post()
               {
                   Id = 2,
                   Title = "Avengers",
                   Body = "When Thor's evil brother, Loki, gains access to the unlimited power of the energy cube called the Tesseract, Nick Fury, director of S.H.I.E.L.D., initiates a superhero recruitment effort to defeat the unprecedented threat to Earth. Joining Fury's 'dream team' are Iron Man, Captain America, the Hulk, Thor, the Black Widow and Hawkeye.",
                   Reviewer = "Stan Lee",
                   DateTime = DateTime.Now,
                   GenreId = 1,
               });

            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Sci-fi",
                },

                new Genre()
                {
                    Id = 2,
                    Name = "Romance"
                },
                
                new Genre()
                {
                    Id = 3,
                    Name = "Action"
                },

                new Genre()
                {
                    Id = 4,
                    Name = "Fantasy"
                },


                new Genre()
                {
                    Id = 5,
                    Name = "Horror",
                },

                new Genre()
                {
                    Id = 6,
                    Name = "Drama"
                },

                new Genre()
                {
                    Id = 7,
                    Name = "Comedy"
                });

            modelBuilder.Entity<Tag>().HasData(
               new Tag()
               {
                   Id = 1,
                   Name = "Sci-fi"
               },

               new Tag()
               {
                   Id = 2,
                   Name = "Romance"
               },

               new Tag()
               {
                   Id = 3,
                   Name = "Action"
               },
               
               new Tag()
               {
                   Id = 4,
                   Name = "Fantasy"
               },

               new Tag()
               {
                   Id = 5,
                   Name = "Horror",
               },

                new Tag()
                {
                    Id = 6,
                    Name = "Drama"
                },

                new Tag()
                {
                    Id = 7,
                    Name = "Comedy"
                });

            modelBuilder.Entity<PostTag>().HasData(
                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 1,
                 },

                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 2,
                 },

                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 3,
                 },

                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 4,
                 },
                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 5,
                 },

                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 6,
                 },
                 new PostTag()
                 {
                     PostId = 1,
                     TagId = 7,
                 },

                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 1,
                 },

                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 2,
                 },
                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 3,
                 },

                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 4,
                 },
                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 5,
                 },

                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 6,
                 },
                 new PostTag()
                 {
                     PostId = 2,
                     TagId = 7,
                 });
            base.OnModelCreating(modelBuilder);
        }

    }
}
