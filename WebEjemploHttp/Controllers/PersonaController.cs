using Microsoft.AspNetCore.Mvc;

namespace WebEjemploHttp.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonaController : ControllerBase
{
    RepositorioPersonas RepositorioPersonas { get; set; }
    public PersonaController()
    {
        RepositorioPersonas = new RepositorioPersonas();
    }

    [HttpGet]
    public IActionResult ObtenerPersonas()
    {
        var result = RepositorioPersonas.ObtenerListaPersonas();
        return Ok(result);
    }

    [HttpGet]
    [Route("ObtenerPersonaById")]
    public IActionResult ObtenerPersonaById(int id)
    {
        var result = RepositorioPersonas.ObtenerPersonaById(id);
        return Ok(result);
    }

    [HttpPost]
    public IActionResult CrearPersona(Persona persona)
    {
        var result = RepositorioPersonas.AgregarPersona(persona);
        return Ok(result);
    }

    [HttpPut]
    public IActionResult EditarPersona(Persona persona)
    {
        var result = RepositorioPersonas.EditarPersona(persona);
        return Ok(result);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult EliminarPersona(int id)
    {
        var result = RepositorioPersonas.EliminarPersona(id);
        return Ok(result);
    }
}

