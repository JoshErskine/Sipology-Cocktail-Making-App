using CocktailProject.Api.DTOs;
using CocktailProject.Api.Requests;
using CocktailProject.Api.Responses;
using CocktailProject.Implementation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
        var cocktails = await _context.Cocktail
            .Include(x => x.CocktailIngredients)
                .ThenInclude(ci => ci.Ingredient)
            .Where(x => x.CocktailIngredients
                .Any(ci => request.IngredientNames
                    .Any(input => ci.Ingredient.Name.ToLower() == input.ToLower())))
            .ToListAsync(cancellationToken);
            

        var cocktailsResponse = cocktails
            .Select(x => new CocktailDto()
            {
                Name = x.Name,
                Description = x.Description,
                Ingredient = x.CocktailIngredients.Select(ci => new IngredientDto()
                {
                    Name = ci.Ingredient.Name,
                }).ToList()
            }).OrderBy(x => x.Name).ToList();
        
        return new GetCocktailsByIngredientsResponse()
        {
            Cocktails = cocktailsResponse
        };
    }
}