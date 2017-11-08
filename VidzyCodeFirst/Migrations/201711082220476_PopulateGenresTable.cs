namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Comedy')");
            Sql("INSERT INTO Genres VALUES ('Action')");
            Sql("INSERT INTO Genres VALUES ('Horror')");
            Sql("INSERT INTO Genres VALUES ('Thriller')");
            Sql("INSERT INTO Genres VALUES ('Family')");
            Sql("INSERT INTO Genres VALUES ('Romance')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres [WHERE Name ='Romance']");
            Sql("DELETE FROM Genres [WHERE Name ='Family']");
            Sql("DELETE FROM Genres [WHERE Name ='Thriller']");
            Sql("DELETE FROM Genres [WHERE Name ='Horror']");
            Sql("DELETE FROM Genres [WHERE Name ='Action']");
            Sql("DELETE FROM Genres [WHERE Name ='Comedy']");
        }
    }
}
