namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = Stock");
        }
        
        public override void Down()
        {
        }
    }
}
