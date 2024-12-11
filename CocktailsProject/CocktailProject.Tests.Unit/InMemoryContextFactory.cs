using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction.Tests.Unit
{
    internal class InMemoryContextFactory : IDbContextFactory<CocktailsContext>
    {
        private DbContextOptions<CocktailsContext> _options;

        public InMemoryContextFactory(string name = null)
        {
            _options = new DbContextOptionsBuilder<CocktailsContext>()
                .UseInMemoryDatabase(name ?? "Fakerbase-" + Guid.NewGuid())
                .Options;
        }

        public CocktailsContext CreateDbContext()
        {
            return new CocktailsContext(_options);
        }
    }
}
