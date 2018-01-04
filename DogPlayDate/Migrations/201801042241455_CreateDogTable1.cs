namespace DogPlayDate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDogTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dogs", "DogOwner_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Dogs", "DogOwner_Id");
            AddForeignKey("dbo.Dogs", "DogOwner_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dogs", "DogOwner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Dogs", new[] { "DogOwner_Id" });
            DropColumn("dbo.Dogs", "DogOwner_Id");
        }
    }
}
