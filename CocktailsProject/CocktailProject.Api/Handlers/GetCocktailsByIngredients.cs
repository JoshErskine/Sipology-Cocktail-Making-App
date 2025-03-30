using CocktailProject.Api.Requests;
using CocktailProject.Api.Responses;
using CocktailProject.Implementation.Data;
using MediatR;

namespace CocktailProject.Api.Handlers;

public class GetCocktailsByIngredients : IRequestHandler<GetCocktailsByIngredientsRequest, GetCocktailsByIngredientsResponse>
{
    private readonly CocktailsContext _context;

    public GetCocktailsByIngredients(CocktailsContext context)
    {
        _context = context;
    }

    public async Task<GetCocktailsByIngredientsResponse> Handle(GetCocktailsByIngredientsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}