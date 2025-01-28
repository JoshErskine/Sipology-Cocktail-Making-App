using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CocktailProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocktailsController(IMediator mediator)
        : ControllerBase
    {
    }
}
