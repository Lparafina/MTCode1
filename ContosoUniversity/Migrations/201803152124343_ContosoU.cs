namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContosoU : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Address_Email", c => c.String());
            AddColumn("dbo.Person", "GPA", c => c.Double());
            AddColumn("dbo.Person", "CE", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "CE");
            DropColumn("dbo.Person", "GPA");
            DropColumn("dbo.Person", "Address_Email");
        }
    }
}
