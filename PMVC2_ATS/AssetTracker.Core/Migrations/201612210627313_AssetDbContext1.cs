namespace AssetTracker.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetDbContext1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseFiles", "PurchaseOrderId", "dbo.PurchaseOrders");
            DropIndex("dbo.PurchaseFiles", new[] { "PurchaseOrderId" });
            DropTable("dbo.PurchaseFiles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PurchaseFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        PurchaseOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.PurchaseFiles", "PurchaseOrderId");
            AddForeignKey("dbo.PurchaseFiles", "PurchaseOrderId", "dbo.PurchaseOrders", "Id", cascadeDelete: true);
        }
    }
}
