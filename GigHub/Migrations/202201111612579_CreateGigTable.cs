namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGigTable : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE TABLE[dbo].[Gig]([GigID][uniqueidentifier] NOT NULL, [GigStatus][int] NOT NULL");
        }
        
        public override void Down()
        {
        }
    }
}
