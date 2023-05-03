namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DelivaryMen",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Uname);
            
            CreateTable(
                "dbo.OrderPlacements",
                c => new
                    {
                        OrderBy = c.String(nullable: false, maxLength: 128),
                        OrderDate = c.DateTime(nullable: false),
                        OrderPlace = c.String(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderBy)
                .ForeignKey("dbo.FoodDelivaries", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.FoodDelivaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        FoodName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderPlacements", "OrderId", "dbo.FoodDelivaries");
            DropIndex("dbo.OrderPlacements", new[] { "OrderId" });
            DropTable("dbo.FoodDelivaries");
            DropTable("dbo.OrderPlacements");
            DropTable("dbo.DelivaryMen");
        }
    }
}
