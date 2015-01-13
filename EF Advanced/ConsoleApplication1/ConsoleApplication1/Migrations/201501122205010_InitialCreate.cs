namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Tags = c.String(),
                        Blog_BlogId = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId)
                .Index(t => t.Blog_BlogId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        Avatar = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Profile_ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Posts", "Blog_BlogId", "dbo.Blogs");
            DropIndex("dbo.Users", new[] { "Profile_ProfileId" });
            DropIndex("dbo.Posts", new[] { "Blog_BlogId" });
            DropTable("dbo.Profiles");
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}
