using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace Data
{
    public class BlogDbContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=AIRFAN\SQLEXPRESS;Database=Blogging;Integrated Security=True");
        }
    }
}
