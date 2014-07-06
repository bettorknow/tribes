namespace Tribes.Database.Management.CreateDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKeys : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Tribes", "Id", c => c.Guid(nullable: false, identity: true, defaultValueSql: "newid()"));
            AlterColumn("Clans", "Id", c => c.Guid(nullable: false, identity: true, defaultValueSql: "newid()"));
            AlterColumn("Members", "Id", c => c.Guid(nullable: false, identity: true, defaultValueSql: "newid()"));
        }
        
        public override void Down()
        {
        }
    }
}
