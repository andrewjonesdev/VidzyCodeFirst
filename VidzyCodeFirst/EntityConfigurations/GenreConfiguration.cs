using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            //Table Overrides
            
            //Primary Key Overrides

            //Property Overrides

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            //Relationship Overrides

        }
    }
}
