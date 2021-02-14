namespace DelaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        Folio = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Percentage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoices");
        }
    }
}
