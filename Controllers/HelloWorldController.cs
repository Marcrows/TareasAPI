using Microsoft.AspNetCore.Mvc;

namespace APIProj.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;

    public HelloWorldController(IHelloWorldService hw)
    {
        helloWorldService = hw;
    }

    public IActionResult Get()
    {
        return Ok(helloWorldService.GetHelloWorld());
    }
}