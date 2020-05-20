namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, Stock) VALUES (1, 'Hangover', 2, 01/01/2000, 01/05/2019, 5)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, Stock) VALUES (2, 'Die Hard', 1, 01/01/2002, 01/05/2019, 5)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, Stock) VALUES (3, 'The Terminator', 1, 01/01/2001, 01/05/2019, 5)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, Stock) VALUES (4, 'Toy Story', 3, 01/01/2003, 01/05/2019, 5)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, Stock) VALUES (5, 'Titanic', 4, 01/01/2005, 01/05/2019, 5)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
