namespace WebPruebaHttpHttps
{
    public class RepositorioPersonas
    {
        List<Persona> listaPersonas;
        public RepositorioPersonas()
        {
            listaPersonas = new List<Persona>()
            {
                new Persona()
                {
                    Id = 1,
                    Nombre = "Andrés",
                    Apellido = "Perez",
                    Dirección = "Calle 3 # 2-87"
                },
                new Persona()
                {
                   Id = 2,
                   Nombre = "Diego",
                   Apellido = "Rendon",
                   Dirección = "Calle Av 13 # 52-87"
                },
                new Persona()
                {
                   Id = 3,
                   Nombre = "Pedro",
                   Apellido = "Fernandez",
                   Dirección = "Carrera 1 # 5-7"
                },
                new Persona()
                {
                   Id = 3,
                   Nombre = "Juan",
                   Apellido = "Rodriguez",
                   Dirección = "Calle Av 13 # 52-87"
                }
            };
        }

        public List<Persona> ObtenerListaPersonas()
        {
            return listaPersonas;
        }

        public Persona ObtenerPersonaById(int id)
        {
            var persona = listaPersonas.FirstOrDefault(a => a.Id == id);
            return persona;
        }

        public List<Persona> AgregarPersona(Persona persona)
        {
            if (!listaPersonas.Any(x => x.Id == persona.Id))
            {
                listaPersonas.Add(persona);
            }
            return listaPersonas;
        }

        public List<Persona> EditarPersona(Persona persona)
        {
            var personaEditar = listaPersonas.FirstOrDefault(x => x.Id == persona.Id);
            if (personaEditar is not null)
            {
                personaEditar.Nombre = persona.Nombre;
                personaEditar.Apellido = persona.Apellido;
            }
            return listaPersonas;
        }

        public List<Persona> EliminarPersona(int id)
        {
            var personaEliminar = listaPersonas.FirstOrDefault(x => x.Id == id);
            if (personaEliminar is not null)
            {
                listaPersonas.Remove(personaEliminar);
            }
            return listaPersonas;
        }
    }
}
