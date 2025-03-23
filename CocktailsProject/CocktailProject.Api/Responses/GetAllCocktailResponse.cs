using CocktailProject.Api.DTOs;

namespace CocktailProject.Api.Responses;

public class GetAllCocktailResponse
{
    public List<CocktailDto> Cocktails { get; set; }
}