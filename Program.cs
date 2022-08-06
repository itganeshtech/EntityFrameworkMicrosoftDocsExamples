using ConsoleApp4;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //CRUD_Operations();

        //SampleQuery();

        new LinqOperations().TestObject2();

    }

    private static void SampleQuery()
    {
        var db = new BloggingContext();

        var blogs = db.Blogs.ToList();

        var posts = db.Posts.Include("Blog")
            .OrderBy(x => x.PostId)
            .ToList();
    }

    private static void CRUD_Operations()
    {
        var db = new BloggingContext();

        // Note: This sample requires the database to be created before running.
        Console.WriteLine($"Database path: {db.DbPath}.");

        // Create
        Console.WriteLine("Inserting a new blog");
        //how to add new info
        db.Add(new Blog { Url = "http://blogs.msdn.com/adonet-ganesh" });
        db.Add(new Blog { Url = "http://blogs.msdn.com/JustinTimeCompiler" });
        db.Add(new Blog { Url = "http://blogs.msdn.com/Loops" });
        db.Add(new Blog { Url = "http://blogs.msdn.com/Selection_Statements" });
        db.SaveChanges();

        // Read
        Console.WriteLine("Querying for a blog");
        var blog = db.Blogs
            .OrderBy(b => b.BlogId)
            .First();


        var blogs = (from p in db.Blogs
                   select p);

        /* METHOD - 1
        // Update
        Console.WriteLine("Updating the blog and adding a post");
        blog.Url = "https://devblogs.microsoft.com/dotnet";
        blog.Posts.Add(
            new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
        db.SaveChanges();
        */

        /* METHOD - 2*/
        db.Posts.Add(new Post() { BlogId = blog.BlogId, Title = "Hello World - Gagan", Content = "I wrote an app using EF Core!" });
        db.SaveChanges();


        // Delete
        Console.WriteLine("Delete the blog");

        //db.Remove(blog);
        // db.SaveChanges();
    }
}