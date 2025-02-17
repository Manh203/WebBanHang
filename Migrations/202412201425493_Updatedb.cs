namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "IsHome", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsHome");
        }
    }
}
