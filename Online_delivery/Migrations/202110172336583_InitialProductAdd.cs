namespace Online_delivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialProductAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        Pimage = c.String(),
                        Pbrief = c.String(),
                        details = c.String(),
                        rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
