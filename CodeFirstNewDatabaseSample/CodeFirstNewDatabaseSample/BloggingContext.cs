using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeFirstNewDatabaseSample.Model;
using CodeFirstNewDatabaseSample.Mapping;

namespace CodeFirstNewDatabaseSample
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_name");

            modelBuilder.Configurations.Add(new AuthorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}