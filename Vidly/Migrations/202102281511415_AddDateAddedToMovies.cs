namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAddedToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded = GETDATE() WHERE Id = 13;");
            Sql("UPDATE Movies SET DateAdded = GETDATE() WHERE Id = 14;");
            Sql("UPDATE Movies SET DateAdded = GETDATE() WHERE Id = 15;");
            Sql("UPDATE Movies SET DateAdded = GETDATE() WHERE Id = 16;");
            Sql("UPDATE Movies SET DateAdded = GETDATE() WHERE Id = 17;");
        }

        public override void Down()
        {
        }
    }
}
