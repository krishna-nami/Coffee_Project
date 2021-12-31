namespace Online_delivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQualityIntoProductNewWeight : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weights",
                c => new
                    {
                        WeightId = c.Int(nullable: false, identity: true),
                        weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WeightId);
            
            AddColumn("dbo.Products", "qty", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "Pimage", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Pimage", c => c.String());
            AlterColumn("dbo.Products", "name", c => c.String());
            DropColumn("dbo.Products", "qty");
            DropTable("dbo.Weights");
        }
    }
}
