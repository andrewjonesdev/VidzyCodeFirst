namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Romance')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id=6 AND Name='Romance'");
            Sql("DELETE FROM Genres WHERE Id=5 AND Name='Family'");
            Sql("DELETE FROM Genres WHERE Id=4 AND Name='Thriller'");
            Sql("DELETE FROM Genres WHERE Id=3 AND Name='Horror'");
            Sql("DELETE FROM Genres WHERE Id=2 AND Name='Action'");
            Sql("DELETE FROM Genres WHERE Id=1 AND Name='Comedy'");
        }
    }
}
