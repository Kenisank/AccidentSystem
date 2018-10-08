namespace AccidentSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccidentRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        StateId = c.Int(nullable: false),
                        Withnesses_Name = c.String(),
                        Withnesses_Number = c.String(),
                        OtherWithnesses_Name = c.String(),
                        OtherWithnesses_Number = c.String(),
                        Evidence_Image = c.String(),
                        Evidence_Description = c.String(),
                        PedestrianEntry_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AffectedPersons", t => t.PedestrianEntry_Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId)
                .Index(t => t.PedestrianEntry_Id);
            
            CreateTable(
                "dbo.Causes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AccidentRecords_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccidentRecords", t => t.AccidentRecords_Id)
                .Index(t => t.AccidentRecords_Id);
            
            CreateTable(
                "dbo.AffectedPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccidentRecordId = c.Int(nullable: false),
                        DeadMale = c.Int(nullable: false),
                        DeadFemale = c.Int(nullable: false),
                        HurtMale = c.Int(nullable: false),
                        HurtFemale = c.Int(nullable: false),
                        SurviedMale = c.Int(nullable: false),
                        SurviedFemale = c.Int(nullable: false),
                        CategoryId = c.Int(),
                        TypeId = c.Int(),
                        PlateNo = c.String(),
                        Model = c.String(),
                        Colour = c.String(),
                        State = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        AccidentRecords_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.TypeId, cascadeDelete: true)
                .ForeignKey("dbo.AccidentRecords", t => t.AccidentRecords_Id)
                .ForeignKey("dbo.AccidentRecords", t => t.AccidentRecordId, cascadeDelete: true)
                .Index(t => t.AccidentRecordId)
                .Index(t => t.CategoryId)
                .Index(t => t.TypeId)
                .Index(t => t.AccidentRecords_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Total = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        DriversCategory = c.Int(nullable: false),
                        PassagersCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AffectedPersons", "AccidentRecordId", "dbo.AccidentRecords");
            DropForeignKey("dbo.AffectedPersons", "AccidentRecords_Id", "dbo.AccidentRecords");
            DropForeignKey("dbo.AffectedPersons", "TypeId", "dbo.Types");
            DropForeignKey("dbo.AccidentRecords", "StateId", "dbo.States");
            DropForeignKey("dbo.AccidentRecords", "PedestrianEntry_Id", "dbo.AffectedPersons");
            DropForeignKey("dbo.AffectedPersons", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Types", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Causes", "AccidentRecords_Id", "dbo.AccidentRecords");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Types", new[] { "CategoryId" });
            DropIndex("dbo.AffectedPersons", new[] { "AccidentRecords_Id" });
            DropIndex("dbo.AffectedPersons", new[] { "TypeId" });
            DropIndex("dbo.AffectedPersons", new[] { "CategoryId" });
            DropIndex("dbo.AffectedPersons", new[] { "AccidentRecordId" });
            DropIndex("dbo.Causes", new[] { "AccidentRecords_Id" });
            DropIndex("dbo.AccidentRecords", new[] { "PedestrianEntry_Id" });
            DropIndex("dbo.AccidentRecords", new[] { "StateId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.States");
            DropTable("dbo.Types");
            DropTable("dbo.Categories");
            DropTable("dbo.AffectedPersons");
            DropTable("dbo.Causes");
            DropTable("dbo.AccidentRecords");
        }
    }
}
