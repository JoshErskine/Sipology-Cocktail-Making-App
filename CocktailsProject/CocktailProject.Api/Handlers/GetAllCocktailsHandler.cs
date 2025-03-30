using CocktailProject.Api.DTOs;
using CocktailProject.Api.Requests;
using CocktailProject.Api.Responses;
using CocktailProject.Implementation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CocktailProject.Api.Handlers;

public class GetAllCocktailsHandler : IRequestHandler<GetAllCocktailsRequest, GetAllCocktailResponse>
{
    private readonly CocktailsContext _context;

    public GetAllCocktailsHandler(CocktailsContext context)
    {
        _context = context;
    }
    
    public async Task<GetAllCocktailResponse> Handle(GetAllCocktailsRequest request, CancellationToken cancellationToken)
    {
        var cocktails = await _context.Cocktail
            .Include(x => x.CocktailIngredients)
            .ThenInclude(x => x.Ingredient)
            .ToListAsync();

        var cocktailDto = cocktails
            .Select(x => new CocktailDto
            {
                Name = x.Name,
                Description = x.Description,
                Ingredient = x.CocktailIngredients.Select(x => new IngredientDto()
                {
                    Name = x.Ingredient.Name,
                }).ToList()
            }).ToList();
        

        return await Task.FromResult(new GetAllCocktailResponse() {Cocktails = cocktailDto});
    }
}