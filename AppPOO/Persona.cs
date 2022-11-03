using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOO
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        protected bool EsActivo { get; set; }

        private string Password { get; set; }
        public Persona()
        {
            Password = Guid.NewGuid().ToString();
        }

        public Persona(int id) : this()
        {
            this.Id = id;
        }

        public void Activar()
        {
            EsActivo = true;
        }

        public bool ObtenerEstadoActivo()
        {
            //TODO
            return EsActivo;
        }
    }
}
