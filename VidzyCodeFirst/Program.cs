using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Genre Genre { get; set; }
    }

    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Video { get; set; }
    }

    public class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
