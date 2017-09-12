namespace HomeCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTable1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stock", "Movie_ID", "dbo.Movie");
            DropIndex("dbo.Stock", new[] { "Movie_ID" });
            DropColumn("dbo.Stock", "Movie_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stock", "Movie_ID", c => c.Int());
            CreateIndex("dbo.Stock", "Movie_ID");
            AddForeignKey("dbo.Stock", "Movie_ID", "dbo.Movie", "ID");
        }
    }
}
