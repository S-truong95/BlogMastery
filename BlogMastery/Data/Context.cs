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
                   Title = "the",
                   Body = "if",
                   Author = "Jk",
                   PublishDate = 2,
                   GenreId = 3,
                   TagId = 4,

               });
        }

    }
}
