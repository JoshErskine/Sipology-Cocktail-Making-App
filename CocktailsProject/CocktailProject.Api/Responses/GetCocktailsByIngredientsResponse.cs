using CocktailProject.Api.DTOs;

namespace CocktailProject.Api.Responses;

public class GetCocktailsByIngredientsResponse
{
    public List<CocktailDto> Cocktails { get; set; }
}