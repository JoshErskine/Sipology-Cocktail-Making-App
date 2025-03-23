namespace CocktailProject.Implementation.Data.Models;
public class CocktailModel
{
    public int Id { get; set; }
    public Guid GlobalId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public IEnumerable<CocktailIngredientModel> CocktailIngredients { get; set; }
}