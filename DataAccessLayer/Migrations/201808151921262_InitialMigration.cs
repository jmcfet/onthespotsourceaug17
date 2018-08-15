namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.NoteForCustomers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            
        }
        
        public override void Down()
        {
           
            DropTable("dbo.NoteForCustomers");
           
        }
    }
}
