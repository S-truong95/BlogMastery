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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Blog;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
               new Post()
               {
                   Id = 1,
                   Title = "Harry Potter",
                   Body = "sorcerer",
                   Author = "Jk",
                   PublishDate = 2/2/2002,
                   GenreId = 1,
                   TagId = 1
               },
               new Post()
               {
                   Id = 2,
                   Title = "Notebook",
                   Body = "Alzheimers",
                   Author = "Ryan Gosling",
                   PublishDate = 12/02/1991,
                   GenreId = 2,
                   TagId = 2
               },

               new Post()
               {
                   Id = 3,
                   Title = "Matrix",
                   Body = "if or",
                   Author = "steven spielberg",
                   PublishDate = 11 / 02 / 1991,
                   GenreId = 1,
                   TagId = 1
               },

               new Post()
               {
                   Id = 4,
                   Title = "Transformers",
                   Body = "Optimus Prime",
                   Author = "steven spielberg",
                   PublishDate = 12 / 02 / 1991,
                   GenreId = 1,
                   TagId = 1
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
                  
                });

            modelBuilder.Entity<Tag>().HasData(
               new Tag()
               {
                   Id = 1,
                   Name = "sci-fi"
               },

               new Tag()
               {
                   Id = 2,
                   Name = "Romance"
               });
        }

    }
}
