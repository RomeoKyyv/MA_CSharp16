using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeFirstNewDatabaseSample.Model;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BloggingContext())
            {
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                context.Blogs.Add(blog);
                context.SaveChanges();

                var blogs = context.Blogs.OrderBy(b => b.Name);
                //var query = from b in context.Blogs
                //            orderby b.Name
                //            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in blogs)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
