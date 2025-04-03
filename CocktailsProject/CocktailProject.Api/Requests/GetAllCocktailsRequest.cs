using CocktailProject.Api.DTOs;
using CocktailProject.Api.Responses;
using MediatR;

namespace CocktailProject.Api.Requests;

public class GetAllCocktailsRequest : IRequest<GetAllCocktailResponse>
{
    public List<string> Name { get; set; }
    public IEnumerable<IngredientDto> Ingredients { get; set; }
}