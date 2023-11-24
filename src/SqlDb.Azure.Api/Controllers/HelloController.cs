using Microsoft.AspNetCore.Mvc;

namespace SqlDb.Azure.Api;

[ApiController]
public class HelloController : ControllerBase
{

    public HelloController()
    {
    }

    [HttpGet]
    [Route("api/hello")]
    public IActionResult Get()
    {
        return Ok(new { Message = "Hello World!" });
    }
}
