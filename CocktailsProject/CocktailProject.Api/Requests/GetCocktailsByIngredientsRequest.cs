using CocktailProject.Api.Responses;
using MediatR;

namespace CocktailProject.Api.Requests;

public class GetCocktailsByIngredientsRequest : IRequest<GetCocktailsByIngredientsResponse>
{
    public string Ingredient { get; set; }
    public List<string> Ingredients { get; set; }

    public GetCocktailsByIngredientsRequest(string ingredient)
    {
        Ingredient = ingredient;
    }

    public GetCocktailsByIngredientsRequest(List<string> ingredients)
    {
        Ingredients = ingredients;
    }
}