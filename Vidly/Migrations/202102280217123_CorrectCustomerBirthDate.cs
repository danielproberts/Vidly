namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1980-01-01 00:00:00.000' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
