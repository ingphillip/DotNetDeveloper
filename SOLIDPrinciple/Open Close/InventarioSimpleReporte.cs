using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Open_Close
{
    public class InventarioSimpleReporte : IReport
    {
        IInventario _inventario;
        public InventarioSimpleReporte(IInventario inventario)
        {
            _inventario = inventario;
        }
        public void GenerarReporte()
        {
            foreach (var item in _inventario.Items)
            {
                Console.WriteLine($"{item.ID} - {item.Nombre}");
            }
        }
    }
}
