using CocktailProject.Api.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CocktailProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocktailsController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public CocktailsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // TODO Return all cocktails
        // TODO Return cocktail by name
        // TODO Return cocktails by ingredient
        // TODO Return all cocktails by multiple ingredients
        
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCocktails(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllCocktailsRequest(), cancellationToken);
            
            return Ok(response);
        }

        [HttpGet]
        [Route("by-name{name}")]
        public async Task<IActionResult> GetCocktailByName(string name, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetCocktailByNameRequest(), cancellationToken);
            
            return Ok();
        }

        [HttpGet]
        [Route("by-ingredients{ingredients}")]
        public async Task<IActionResult> GetCocktailsByIngredients(string ingredients,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetCocktailsByIngredientsRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
