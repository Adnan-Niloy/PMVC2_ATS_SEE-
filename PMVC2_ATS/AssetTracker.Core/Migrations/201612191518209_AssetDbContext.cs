namespace AssetTracker.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(),
                        Description = c.String(),
                        Status = c.Boolean(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.SubCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropTable("dbo.Products");
        }
    }
}
