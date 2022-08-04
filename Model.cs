using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Blogger> Bloggers { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        //var folder = Environment.SpecialFolder.LocalApplicationData;
        //var path = Environment.GetFolderPath(folder);
        //DbPath = System.IO.Path.Join(path, "blogging.db");
        DbPath = "D:\\blogging-new.db";
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Blog
{
    public Blog()
    {
        Posts = new List<Post>();

    }
    public int BlogId { get; set; }
    public string Url { get; set; }
   // public string Name { get; set; }
   // public int rating { get; set; }

    public List<Post> Posts { get; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}
/*
Blogger
Id - int 
Name - string
Age - int
*/
public class Blogger
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public int Age { get; set; }
}