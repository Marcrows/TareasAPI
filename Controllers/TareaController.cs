using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller")]
public class TareaController : ControllerBase
{
    ITareasService tareasService;

    public TareaController(ITareasService service)
    {
        tareasService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tareasService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Tarea TareaObject)
    {
        tareasService.Save(TareaObject);
        return Ok();
    }

    [HttpPut("{Id}")]
    public IActionResult Put(Guid Id, [FromBody] Tarea TareaObject)
    {
        tareasService.Update(Id, TareaObject);
        return Ok();
    }

    [HttpDelete("{Id}")]
    public IActionResult Delete(Guid Id)
    {
        tareasService.Delete(Id);
        return Ok();
    }
}