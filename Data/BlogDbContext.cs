using Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Data
{
    public class BlogDbContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        private IConfigurationRoot configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            optionsBuilder.UseSqlServer(
                @"Server=AIRFAN\SQLEXPRESS;Database=Blogging;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //            .HasOne<Blog>()
            //            .WithOne(x => x.User)
            //            .HasForeignKey<User>(x=>x.Id);

            //modelBuilder.Entity<Post>()
            //            .HasOne<Blog>()
            //            .WithMany(x => x.Posts)
            //            .HasForeignKey(x=>x.BlogId)
            //            .OnDelete(DeleteBehavior.ClientSetNull);

            //SeedData seed = new SeedData();
            //modelBuilder = seed.GenerateModels(modelBuilder);
        }
    }
}
