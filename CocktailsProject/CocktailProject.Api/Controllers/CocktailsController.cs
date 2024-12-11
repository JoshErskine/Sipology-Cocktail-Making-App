using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkIntroduction.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocktailsController(IMediator mediator)
        : ControllerBase
    {
    }
}
