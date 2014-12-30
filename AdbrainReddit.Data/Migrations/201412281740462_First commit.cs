namespace AdbrainReddit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstcommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        UId = c.Int(nullable: false),
                        Kind = c.String(),
                        MainDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UId)
                .ForeignKey("dbo.MainData", t => t.MainDataId, cascadeDelete: true)
                .Index(t => t.MainDataId);
            
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        UId = c.Int(nullable: false),
                        Domain = c.String(),
                        BannedBy = c.String(),
                        SubReddit = c.String(),
                        SelfTextHtml = c.String(),
                        SelfText = c.String(),
                        Likes = c.Int(),
                        LinkFlairText = c.String(),
                        Id = c.String(),
                        Gilded = c.Int(),
                        Clicked = c.Boolean(nullable: false),
                        ReportReasons = c.String(),
                        Author = c.String(),
                        Score = c.Int(nullable: false),
                        ApprovedBy = c.String(),
                        Over18 = c.Boolean(nullable: false),
                        Hidden = c.Boolean(nullable: false),
                        Thumbnail = c.String(),
                        SubredditId = c.String(),
                        Edited = c.Boolean(nullable: false),
                        LinkFlairCssClass = c.String(),
                        AuthorFlairCssClass = c.String(),
                        Downs = c.Int(nullable: false),
                        Saved = c.Boolean(nullable: false),
                        IsSelf = c.Boolean(nullable: false),
                        Name = c.String(),
                        PermaLink = c.String(),
                        Stickied = c.Boolean(nullable: false),
                        Created = c.Long(nullable: false),
                        Url = c.String(),
                        AuthorFlairText = c.String(),
                        Title = c.String(),
                        CreatedUtc = c.Long(nullable: false),
                        Ups = c.Int(nullable: false),
                        NumComments = c.Int(nullable: false),
                        Visited = c.Boolean(nullable: false),
                        NumReports = c.Int(),
                        Distinguished = c.String(),
                    })
                .PrimaryKey(t => t.UId)
                .ForeignKey("dbo.Children", t => t.UId)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.MainData",
                c => new
                    {
                        UId = c.Int(nullable: false),
                        Modhash = c.String(),
                        After = c.String(),
                        Before = c.String(),
                    })
                .PrimaryKey(t => t.UId)
                .ForeignKey("dbo.RedditResponse", t => t.UId)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.RedditResponse",
                c => new
                    {
                        UId = c.Int(nullable: false),
                        Kind = c.String(),
                    })
                .PrimaryKey(t => t.UId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Children", "MainDataId", "dbo.MainData");
            DropForeignKey("dbo.MainData", "UId", "dbo.RedditResponse");
            DropForeignKey("dbo.Data", "UId", "dbo.Children");
            DropIndex("dbo.MainData", new[] { "UId" });
            DropIndex("dbo.Data", new[] { "UId" });
            DropIndex("dbo.Children", new[] { "MainDataId" });
            DropTable("dbo.RedditResponse");
            DropTable("dbo.MainData");
            DropTable("dbo.Data");
            DropTable("dbo.Children");
        }
    }
}
