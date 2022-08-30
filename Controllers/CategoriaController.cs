using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller")]
public class CategoriaController : ControllerBase
{
    ICategoriaService categoriaService;

    public CategoriaController(ICategoriaService service)
    {
        categoriaService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(categoriaService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Categoria CategoriaObject)
    {
        categoriaService.Save(CategoriaObject);
        return Ok();
    }

    [HttpPut("{Id}")]
    public IActionResult Put(Guid Id, [FromBody] Categoria CategoriaObject)
    {
        categoriaService.Update(Id, CategoriaObject);
        return Ok();
    }

    [HttpDelete("{Id}")]
    public IActionResult Delete(Guid Id)
    {
        categoriaService.Delete(Id);
        return Ok();
    }

}