using CocktailProject.Api.DTOs;
using CocktailProject.Api.Requests;
using CocktailProject.Api.Responses;
using CocktailProject.Implementation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CocktailProject.Api.Handlers;

public class GetCocktailByName : IRequestHandler<GetCocktailByNameRequest, GetCocktailByNameResponse>
{
    private readonly CocktailsContext _context;

    public GetCocktailByName(CocktailsContext context)
    {
        _context = context;
    }
    
    public async Task<GetCocktailByNameResponse> Handle(GetCocktailByNameRequest request, CancellationToken cancellationToken)
    {
        var cocktailByName = await _context.Cocktail
            .Where(x => x.Name == request.Name)
            .Include(x => x.CocktailIngredients)
            .ThenInclude(x => x.Ingredient)
            .FirstOrDefaultAsync(x => x.Name == request.Name, cancellationToken);

        if (cocktailByName == null)
        {
            return null;
        }
        
        return await Task.FromResult(new GetCocktailByNameResponse()
        {
            Name = cocktailByName.Name,
            Description = cocktailByName.Description,
            Ingredients = cocktailByName.CocktailIngredients.Select(c => new IngredientDto()
            {
                Name = c.Ingredient.Name,
            }).ToList()
        });
    }
}