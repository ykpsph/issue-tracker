namespace AddingBootstrapTheme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTheIssueEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        UserID = c.Int(nullable: false),
                        IssuedOn = c.DateTime(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Issues", "UserID", "dbo.Users");
            DropIndex("dbo.Issues", new[] { "UserID" });
            DropTable("dbo.Issues");
        }
    }
}
