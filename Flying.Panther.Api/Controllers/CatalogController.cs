using Microsoft.AspNetCore.Mvc;

namespace Flying.Panther.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogController : ControllerBase
{
    [HttpGet]
    public IActionResult GetItems()
    {
        return Ok("hello world.");
    }
}