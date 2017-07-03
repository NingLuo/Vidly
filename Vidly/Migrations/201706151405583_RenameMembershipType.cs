namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMembershipType : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MemebershipTypes", newName: "MembershipTypes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.MembershipTypes", newName: "MemebershipTypes");
        }
    }
}
