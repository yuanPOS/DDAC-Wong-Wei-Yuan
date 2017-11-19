namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.bookings", "origin", c => c.String());
            AlterColumn("dbo.bookings", "destination", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.bookings", "destination", c => c.Int(nullable: false));
            AlterColumn("dbo.bookings", "origin", c => c.Int(nullable: false));
        }
    }
}
