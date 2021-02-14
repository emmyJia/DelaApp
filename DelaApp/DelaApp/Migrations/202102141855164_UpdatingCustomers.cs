namespace DelaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "StartTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "StartTime");
        }
    }
}
