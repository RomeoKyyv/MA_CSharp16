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

                Console.Write("Enter a username for a new User: ");
                var username = Console.ReadLine();
                Console.Write("Enter a display name for the User: ");
                var displayName = Console.ReadLine();
                var user = new User { Username = username, DisplayName = displayName };
                context.Users.Add(user);
                context.SaveChanges();

                Console.WriteLine("All users in the database:");
                foreach (var item in context.Users.OrderBy(u => u.DisplayName))
                {
                    Console.WriteLine($"{item.Username} - {item.DisplayName}");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
