namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNewTable : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE TABLE[dbo].[Gig]([GigID][uniqueidentifier] NOT NULL, [GigStatus][int]  NULL)");
        }
        
        public override void Down()
        {
        }
    }
}
