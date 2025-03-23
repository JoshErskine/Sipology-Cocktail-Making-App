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


    }
}
