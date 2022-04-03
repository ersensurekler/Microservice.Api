using Microsoft.AspNetCore.Mvc;

namespace Customer.Api.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IResult Get()
        {
            return Results.Accepted();
        }

        [HttpPost]
        public IResult Post()
        {
            return Results.Ok();
        }
    }
}
