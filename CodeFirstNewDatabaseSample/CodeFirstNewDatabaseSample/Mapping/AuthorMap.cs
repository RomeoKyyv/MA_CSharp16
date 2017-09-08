using CodeFirstNewDatabaseSample.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseSample.Mapping
{
    public class AuthorMap: EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            this.ToTable("Author", "dbo");

            this.HasKey(a => a.NickName);

            this.Property(a => a.Address).HasMaxLength(128);
            this.Property(a => a.Age).IsOptional();
        }
    }
}
