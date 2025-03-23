namespace CocktailProject.Implementation.Data.Models;
public class CocktailIngredientModel
{
    public int Id { get; set; }
    public Guid GlobalId { get; set; }
    public int Measurement { get; set; }
    public string MeasurementType { get; set; }
    public int CocktailId { get; set; }
    public int IngredientId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public CocktailModel Cocktail { get; set; }
    public IngredientModel Ingredient { get; set; }
}