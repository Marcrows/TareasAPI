using Microsoft.AspNetCore.Mvc;

namespace APIProj.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;

    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(IHelloWorldService hw, ILogger<HelloWorldController> logger)
    {
        _logger = logger;
        helloWorldService = hw;
    }

    [HttpGet(Name = "Get")]
    public IActionResult Get()
    {
        _logger.LogDebug("Logging from Get(). Hi!");
        return Ok(helloWorldService.GetHelloWorld());
    }

/*     [HttpGet(Name = "GetBye")]
    [Route("get/bye")]
    public IActionResult GetBye()
    {
        _logger.LogDebug("Saying goodbye @ GetBye()");
        return Ok(helloWorldService.GetByeWorld());
    } */
}