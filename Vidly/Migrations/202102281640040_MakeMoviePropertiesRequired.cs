namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeMoviePropertiesRequired : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies ALTER COLUMN ReleaseDate datetime NOT NULL; ");
            Sql("ALTER TABLE Movies ALTER COLUMN DateAdded datetime NOT NULL; ");
            Sql("ALTER TABLE Movies ALTER COLUMN NumberInStock int NOT NULL; ");
        }

        public override void Down()
        {
        }
    }
}
