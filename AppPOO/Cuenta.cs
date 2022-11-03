using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOO
{
    public abstract class Cuenta : ICalculable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Monto { get; set; }
        public Persona ClienteCuenta { get; set; }

        public DateTime FechaCreacion { get; set; }

        public abstract decimal CalcularMonto();
        
    }
}
