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
        
        [HttpGet]
        public async Task<IActionResult> GetAllCocktails([FromQuery]GetAllCocktailsRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            
            return Ok(response);
        }
    }
}
