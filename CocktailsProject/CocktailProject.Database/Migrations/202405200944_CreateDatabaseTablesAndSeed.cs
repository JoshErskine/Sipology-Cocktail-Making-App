using CocktailProject.Database;
using FluentMigrator;

namespace EntityFrameworkIntroduction.Database.Migrations
{
    [CocktailMigration(2024, 05, 20, 09, 44)]
    public class CreateDatabaseTablesAndSeed : ForwardOnlyMigration
    {
        public override void Up()
        {
            Execute.Sql(@"
        CREATE TABLE Cocktail (
            Id INT PRIMARY KEY IDENTITY(1,1),
            GlobalId UNIQUEIDENTIFIER NOT NULL,
            Name NVARCHAR(255) NOT NULL,
            Description NVARCHAR(MAX),
            DateCreated DATETIME NOT NULL,
            DateModified DATETIME NOT NULL,
            DateDeleted DATETIME
        );
        CREATE TABLE Ingredient (
            Id INT PRIMARY KEY IDENTITY(1,1),
            GlobalId UNIQUEIDENTIFIER NOT NULL,
            Name NVARCHAR(255) NOT NULL,
            DateCreated DATETIME NOT NULL,
            DateModified DATETIME NOT NULL
        );
        CREATE TABLE CocktailIngredient (
            Id INT PRIMARY KEY IDENTITY(1,1),
            GlobalId UNIQUEIDENTIFIER NOT NULL,
            Measurement INT NOT NULL,
            MeasurementType NVARCHAR(50),
            CocktailId INT NOT NULL,
            IngredientId INT NOT NULL,
            DateCreated DATETIME NOT NULL,
            DateModified DATETIME NOT NULL,
            DateDeleted DATETIME NULL,
            FOREIGN KEY (CocktailId) REFERENCES Cocktail(Id),
            FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
        );
");
        }
    }
}