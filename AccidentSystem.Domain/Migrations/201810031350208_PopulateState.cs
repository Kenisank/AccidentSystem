namespace AccidentSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateState : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO States (Name) VALUES ('Kaduna' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Anambra' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Lagos' )");
        }
        
        public override void Down()
        {
        }
    }
}
