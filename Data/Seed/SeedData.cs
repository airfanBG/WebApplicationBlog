using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seed
{
    public class SeedData
    {
        public ModelBuilder GenerateModels(ModelBuilder modelBuilder)
        {
            List<Post> posts = new List<Post>()
            {
                new Post { BlogId = 1, Id = 1, Title = "First post", Content = "Test 1" },
                new Post { BlogId = 1, Id = 2, Title = "Second post", Content = "Test 2" },
                new Post { BlogId = 1, Id = 3, Title = "aa post", Content = "Test 3" },
                new Post { BlogId = 1, Id = 4, Title = "dasda post", Content = "Test 4" },
                new Post { BlogId = 1, Id = 5, Title = "KKK post", Content = "Test 5" },
                new Post { BlogId = 1, Id = 6, Title = "BBB post", Content = "Test 6" },
                new Post { BlogId = 1, Id = 7, Title = "UOOO post", Content = "Test 7" },
                new Post { BlogId = 1, Id = 8, Title = "ERRR post", Content = "Test 8" },

            };

            for (int i = 9; i < 100; i++)
            {
                posts.Add(new Post { BlogId = 1, Id = i, Title = Guid.NewGuid().ToString(), Content = Guid.NewGuid().ToString() });
            }
           

            modelBuilder.Entity<Blog>().HasData(new Blog { Id = 1, Url = "http://sample.com",Rating=5 });
           
            modelBuilder.Entity<Post>().HasData(posts);
           
            return modelBuilder;
        }
    }
}
