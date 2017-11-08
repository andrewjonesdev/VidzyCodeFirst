namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VidzyCodeFirst.VidzyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VidzyCodeFirst.VidzyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            /*context.Genres.AddOrUpdate(g => g.Name,
                new Genre
                {
                    Name = "Comedy"
                });
            context.Genres.AddOrUpdate(g => g.Name,
                new Genre
                {
                    Name = "Action"
                });
            context.Genres.AddOrUpdate(g => g.Name,
                new Genre
                {
                    Name = "Horror"
                });
            context.Genres.AddOrUpdate(g => g.Name,
                new Genre
                {
                    Name = "Horror"
                });
            context.Genres.AddOrUpdate(g => g.Name,
                new Genre
                {
                    Name = "Family"
                });
            context.Genres.AddOrUpdate(g => g.Name,
                new Genre
                {
                    Name = "Romance"
                });*/
        }
    }
}
