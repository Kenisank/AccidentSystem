namespace AccidentSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeWithnessesToWithness : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccidentRecords", "Withness_Name", c => c.String());
            AddColumn("dbo.AccidentRecords", "Withness_Number", c => c.String());
            AddColumn("dbo.AccidentRecords", "OtherWithness_Name", c => c.String());
            AddColumn("dbo.AccidentRecords", "OtherWithness_Number", c => c.String());
            DropColumn("dbo.AccidentRecords", "Withnesses_Name");
            DropColumn("dbo.AccidentRecords", "Withnesses_Number");
            DropColumn("dbo.AccidentRecords", "OtherWithnesses_Name");
            DropColumn("dbo.AccidentRecords", "OtherWithnesses_Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccidentRecords", "OtherWithnesses_Number", c => c.String());
            AddColumn("dbo.AccidentRecords", "OtherWithnesses_Name", c => c.String());
            AddColumn("dbo.AccidentRecords", "Withnesses_Number", c => c.String());
            AddColumn("dbo.AccidentRecords", "Withnesses_Name", c => c.String());
            DropColumn("dbo.AccidentRecords", "OtherWithness_Number");
            DropColumn("dbo.AccidentRecords", "OtherWithness_Name");
            DropColumn("dbo.AccidentRecords", "Withness_Number");
            DropColumn("dbo.AccidentRecords", "Withness_Name");
        }
    }
}
