namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        customer_id = c.Int(nullable: false),
                        origin = c.Int(nullable: false),
                        destination = c.Int(nullable: false),
                        depart_date = c.DateTime(nullable: false),
                        return_date = c.DateTime(nullable: false),
                        Guests = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.customer_id, cascadeDelete: true)
                .Index(t => t.customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.bookings", "customer_id", "dbo.Customers");
            DropIndex("dbo.bookings", new[] { "customer_id" });
            DropTable("dbo.bookings");
        }
    }
}
