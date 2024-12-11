using CocktailProject.Database;
using FluentMigrator;

namespace EntityFrameworkIntroduction.Database.Migrations
{
    [CocktailMigration(2024, 05, 20, 09, 44)]
    public class CreateDatabaseTablesAndSeed : ForwardOnlyMigration
    {
        public override void Up()
        {
            Execute.Sql(@"");
        }
    }
}