using FluentMigrator;

namespace CocktailProject.Database
{
    public class CocktailMigrationAttribute : MigrationAttribute
    {
        public CocktailMigrationAttribute(int year, int month, int day, int hour, int minute)
            : base(GetVersion(year, month, day, hour, minute))
        {
        }

        private static long GetVersion(int year, int month, int day, int hour, int minute)
        {
            var dateTime = new DateTime(year, month, day, hour, minute, 0);
            return long.Parse(dateTime.ToString("yyyyMMddHHmm"));
        }
    }
}
