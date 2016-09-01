using System;
using System.Threading.Tasks;
using EFCore.Data;

namespace EFCore.Common
{
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
                    Console.WriteLine($" - [id:{blog.BlogId}] {blog.Url}");
                }
            }
        }
    }
}
