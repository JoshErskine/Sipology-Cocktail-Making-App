using CocktailProject.Api.DTOs;
using CocktailProject.Implementation.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CocktailProject.Api.Responses;

public class GetCocktailByNameResponse
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<IngredientDto> Ingredients { get; set; }
}