using CocktailProject.Api.Responses;
using MediatR;

namespace CocktailProject.Api.Requests;

public class GetCocktailByNameRequest : IRequest<GetCocktailByNameResponse>
{
    public string Name { get; set; }
}