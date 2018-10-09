namespace GitHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class POPLATEGENRESTABLE : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Country')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Blue')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Rock')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
