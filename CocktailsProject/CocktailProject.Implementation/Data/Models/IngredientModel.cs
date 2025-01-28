namespace CocktailProject.Implementation.Data.Models;
public class IngredientModel
{
    public int Id { get; set; }
    public Guid GlobalId { get; set; }
    public string Name { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public IEnumerable<CocktailIngredientModel> CocktailIngredients { get; set; }
}