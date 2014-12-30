namespace AdbrainReddit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWillCascadeOnDeletetrue : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Data", "UId", "dbo.Children");
            DropForeignKey("dbo.MainData", "UId", "dbo.RedditResponse");
            AddForeignKey("dbo.Data", "UId", "dbo.Children", "UId", cascadeDelete: true);
            AddForeignKey("dbo.MainData", "UId", "dbo.RedditResponse", "UId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MainData", "UId", "dbo.RedditResponse");
            DropForeignKey("dbo.Data", "UId", "dbo.Children");
            AddForeignKey("dbo.MainData", "UId", "dbo.RedditResponse", "UId");
            AddForeignKey("dbo.Data", "UId", "dbo.Children", "UId");
        }
    }
}
