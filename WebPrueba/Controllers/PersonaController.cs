using Microsoft.AspNetCore.Mvc;

namespace WebPruebaHttpHttps.Controllers
{
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
        public List<Persona> ObtenerPersonas()
        {
            return RepositorioPersonas.ObtenerListaPersonas();
        }

        [HttpPost]
        public List<Persona> CrearPersona(Persona persona)
        {
            return RepositorioPersonas.AgregarPersona(persona);
        }

        [HttpPut]
        public List<Persona> EditarPersona(Persona persona)
        {
            return RepositorioPersonas.AgregarPersona(persona);
        }

        [HttpDelete]
        public List<Persona> EliminarPersona(int id)
        {
            return RepositorioPersonas.EliminarPersona(id);
        }
    }
}
