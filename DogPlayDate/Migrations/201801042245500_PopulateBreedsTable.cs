namespace DogPlayDate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBreedsTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Breeds ON");

            Sql("INSERT INTO Breeds (BreedId, Name) VALUES (1, 'English Staffordshire')");
            Sql("INSERT INTO Breeds (BreedId, Name) VALUES (2, 'Border Collie')");
            Sql("INSERT INTO Breeds (BreedId, Name) VALUES (3, 'Labrador')");
            Sql("INSERT INTO Breeds (BreedId, Name) VALUES (4, 'Blandras')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Breeds WHERE BreedId IN (1, 2, 3, 4)");
        }
    }
}
