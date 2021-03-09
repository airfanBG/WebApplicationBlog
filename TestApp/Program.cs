using Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            //CRUD
            using (BlogDbContext db = new BlogDbContext())
            {
                //var res = db.Blogs.Include(x => x.Posts).AsNoTracking().Select(x => new Blog()
                //{
                //    Id = x.Id,
                //    Rating = x.Rating,
                //    Url = x.Url,
                //    Posts = x.Posts
                //}).ToList();
                var res = db.Blogs.ToList();
               
            }
            //CRUD 
            //BlogDbContext context = new BlogDbContext();
            //string clause = "like username or '1'='1'";
            //string username = "";
            //string password = "";
            //var res=context.Users.FromSqlRaw($"select * from users where username=").ToList();
            var a= 0;
            //var res = context.Blogs.Where(x => x.Url == clause).ToList();

            //var result = context.Blogs.FirstOrDefault(x => x.Id == 2);
            //if (result != null)
            //{
            //    context.Blogs.Remove(result);
            //    context.SaveChanges();
            //}
            //var res = context.Blogs
            //    .Where(x => x.Rating > 2)
            //    .Include(x => x.Posts)

            //    .ToList();

            //foreach (var blog in res)
            //{
            //    var chk = blog.Posts == null ? 0 : blog.Posts.Count;
            //    if (chk==0)
            //    {
            //        Console.WriteLine($"Url: {blog.Url} Id: {blog.Id} / Posts: {chk} ");
            //    }
            //    else
            //    {
            //        foreach (var post in blog.Posts)
            //        {
            //            Console.WriteLine($"Id: {blog.Id} Title {post.Title}");
            //        }

            //    }
            //}
        }
    }
}
