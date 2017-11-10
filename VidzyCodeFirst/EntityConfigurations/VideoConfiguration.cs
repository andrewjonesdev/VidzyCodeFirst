using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            //Table Overrides

            //Primary Key Overrides

            //Property Overrides

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
            
            //Relationship Overrides

            HasRequired(e => e.Genre)
                .WithMany(e => e.Videos)
                .HasForeignKey(c => c.GenreId);

        }
    }
}
