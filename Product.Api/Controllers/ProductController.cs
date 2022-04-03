using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
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
