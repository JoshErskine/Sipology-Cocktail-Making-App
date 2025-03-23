namespace CocktailProject.Api.DTOs;

public class CocktailDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public IngredientDto Ingredient { get; set; }
}