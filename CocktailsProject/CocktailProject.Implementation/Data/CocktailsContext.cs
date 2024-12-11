using Microsoft.EntityFrameworkCore;

public class CocktailsContext : DbContext
{
    public CocktailsContext(DbContextOptions<CocktailsContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
    }
}