namespace IdentityCustom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addintable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FatherName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "FatherName");
        }
    }
}
