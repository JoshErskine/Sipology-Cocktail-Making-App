using CocktailProject.Api.Responses;
using MediatR;

namespace CocktailProject.Api.Requests;

public class GetAllCocktailsRequest : IRequest<GetAllCocktailResponse>
{
    public string Name { get; set; }
    public string Ingredient { get; set; }
}