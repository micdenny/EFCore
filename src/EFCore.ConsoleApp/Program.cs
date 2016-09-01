using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Data;

namespace EFCore.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Application start");

            var app = new Application();
            app.Run().Wait();

            Console.WriteLine("Application end");
            Console.ReadLine();
        }
    }

    public class Application
    {
        public async Task Run()
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog
                {
                    Url = "http://blogs.msdn.com/adonet"
                });
                var count = await db.SaveChangesAsync();
                Console.WriteLine($"{count} records saved to database.");

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($" - {blog.Url}");
                }
            }
        }
    }
}
