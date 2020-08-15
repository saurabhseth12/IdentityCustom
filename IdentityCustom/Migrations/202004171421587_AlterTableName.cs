namespace IdentityCustom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "Account");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClaim");
            RenameColumn(table: "dbo.Account", name: "Id", newName: "AccountId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Account", name: "AccountId", newName: "Id");
            RenameTable(name: "dbo.UserClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.Account", newName: "AspNetUsers");
        }
    }
}
