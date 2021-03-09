using Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
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
            configuration = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).AddJsonFile("appsettings.json").Build();
            //AppDomain.CurrentDomain.BaseDirectory това също работи, ако го подмените на мястото на Assembly.GetExecutingAssembly().Location)
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
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
