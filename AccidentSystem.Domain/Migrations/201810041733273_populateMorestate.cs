namespace AccidentSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMorestate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO States (Name) VALUES ('Katsina' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Ebonyi' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Kano' )");
            
        }
        
        public override void Down()
        {
        }
    }
}
