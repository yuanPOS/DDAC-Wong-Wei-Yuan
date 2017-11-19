namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.bookings", "trip_type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.bookings", "trip_type");
        }
    }
}
