using CocktailProject.Api.Responses;
using MediatR;

namespace CocktailProject.Api.Requests;

public class GetCocktailsByIngredientsRequest : IRequest<GetCocktailsByIngredientsResponse>
{
    public List<string> IngredientNames { get; set; }

    public GetCocktailsByIngredientsRequest(string ingredient)
    {
        IngredientNames = new List<string> { ingredient };
    }

    public GetCocktailsByIngredientsRequest(List<string> ingredients)
    {
        IngredientNames = ingredients;
    }
}