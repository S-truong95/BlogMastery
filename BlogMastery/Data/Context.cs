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
                   DateTime = DateTime.Now,
                   GenreId = 1,
                   TagId = 1
               },
               new Post()
               {
                   Id = 2,
                   Title = "Notebook",
                   Body = "Alzheimers",
                   Author = "Ryan Gosling",
                   DateTime = DateTime.Now,
                   GenreId = 2,
                   TagId = 2
               },

               new Post()
               {
                   Id = 3,
                   Title = "Matrix",
                   Body = "if or",
                   Author = "steven spielberg",
                   DateTime = DateTime.Now,
                   GenreId = 1,
                   TagId = 1
               },

               new Post()
               {
                   Id = 4,
                   Title = "Transformers",
                   Body = "Optimus Prime",
                   Author = "steven spielberg",
                   DateTime = DateTime.Now,
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
               });
        }

    }
}
