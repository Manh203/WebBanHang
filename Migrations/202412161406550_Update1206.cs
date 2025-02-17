namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1206 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_productImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_productImage", "ProductId", "dbo.tb_Product");
            DropIndex("dbo.tb_productImage", new[] { "ProductId" });
            DropTable("dbo.tb_productImage");
        }
    }
}
