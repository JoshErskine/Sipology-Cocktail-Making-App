using CocktailProject.Implementation.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CocktailProject.Implementation.Data;

public class CocktailsContext : DbContext
{
    public DbSet<CocktailModel> Cocktail { get; set; }
    public DbSet<CocktailIngredientModel> CocktailIngredient { get; set; }
    public DbSet<IngredientModel> Ingredient { get; set; }
    
    public CocktailsContext(DbContextOptions<CocktailsContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
        
        modelBuilder.Entity<CocktailIngredientModel>()
            .HasKey(ci => ci.Id);
        
        modelBuilder.Entity<CocktailIngredientModel>()
            .HasOne(ci => ci.Cocktail)
            .WithMany(c => c.CocktailIngredients)
            .HasForeignKey(ci => ci.CocktailId);
        
        modelBuilder.Entity<CocktailIngredientModel>()
            .HasOne(ci => ci.Ingredient)
            .WithMany(i => i.CocktailIngredients)
            .HasForeignKey(ci => ci.IngredientId);
        
        modelBuilder.Entity<CocktailModel>()
            .HasKey(ci => ci.Id);
        
        modelBuilder.Entity<IngredientModel>()
            .HasKey(ci => ci.Id);
    }
}