using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOO
{
    internal class CuentaCorriente : Cuenta
    {
        private decimal manejo = 200;
        public override decimal CalcularMonto()
        {
            var valorMontoFinal = Monto - manejo;
            return valorMontoFinal;
        }
    }
}
