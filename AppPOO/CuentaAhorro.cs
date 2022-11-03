using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOO
{
    internal class CuentaAhorro : Cuenta
    {
        public override decimal CalcularMonto()
        {
            return Monto;
        }
    }
}
