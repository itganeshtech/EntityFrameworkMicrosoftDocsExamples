using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    public class LinqOperations
    {
        public void TestInt()
        {
            List<int> integerList = new List<int>()
            {
               11, 25, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12
            };

            /* Method - 1
            //LINQ Query using Query Syntax
            var QuerySyntax = from p in integerList
                              where p > 5
                              select p;
            */

            //var QuerySyntax = from p in integerList
            //                  orderby p 
            //                  select p;

            var QuerySyntax = from p in integerList
                              orderby p descending
                              select p;


            //var QuerySyntax = integerList.Where(x => x > 5);

            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

        }

        public void TestString()
        {
            List<string> strList = new List<string>()
            {
                "Red", "Blue", "Green", "Yellow"
            };

            // Method - 1
            //LINQ Query using Query Syntax

            //// Query 1
            //var QuerySyntax = from p in strList
            //                  where p == "Red"
            //                  select p;


            // Query 2
            //var QuerySyntax = from p in strList
            //                  where p.Length > 4
            //                  select p;


            // Method - 2
            //var QuerySyntax = strList.Where(x => x.Length > 4);

            var QuerySyntax = strList.OrderBy(x => x);


            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

        }

        public void TestObject()
        {
            List<Post> list = new List<Post>()
           {
               new Post(){ BlogId= 1, Title="Hello World Post 1", Content ="abc", PostId = 1 },
               new Post(){ BlogId= 1, Title="Hello World Post 2", Content ="abc", PostId = 2 },
               new Post(){ BlogId= 2, Title="Hello World Post 3", Content ="abc", PostId = 3 },
               new Post(){ BlogId= 3, Title="Hello World Post 4", Content ="abc", PostId = 4 },
           };


            var QuerySyntax = from p in list
                              where p.BlogId == 1
                              select p;



            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item.Title + " ");
            }

        }


        public void TestObject2()
        {
            List<Post> list = new List<Post>()
           {
               new Post(){ BlogId= 1, Title="Hello World Post 1", Content ="abc", PostId = 1 },
               new Post(){ BlogId= 1, Title="Hello World Post 2", Content ="abc", PostId = 2 },
               new Post(){ BlogId= 2, Title="Hello World Post 3", Content ="abc", PostId = 3 },
               new Post(){ BlogId= 3, Title="Hello World Post 4", Content ="abc", PostId = 4 },
           };


            var QuerySyntax = from p in list
                              where p.BlogId == 1
                              select new
                              {
                                  BlogTitle = p.Title,
                                  BlogContent = p.Content
                              };

            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item.BlogTitle + " " + item.BlogContent);
            }
        }


        public void TestObject3()
        {
            List<Post> list = new List<Post>()
           {
               new Post(){ BlogId= 1, Title="Hello World Post 1", Content ="abc", PostId = 1 },
               new Post(){ BlogId= 1, Title="Hello World Post 2", Content ="abc", PostId = 2 },
               new Post(){ BlogId= 2, Title="Hello World Post 3", Content ="abc", PostId = 3 },
               new Post(){ BlogId= 3, Title="Hello World Post 4", Content ="abc", PostId = 4 },
           };


            var QuerySyntax = from p in list
                              where p.BlogId == 1
                              select new
                              {
                                  BlogTitle = p.Title,
                                  BlogContent = p.Content
                              };

            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item.BlogTitle + " " + item.BlogContent);
            }
        }
    }
}
