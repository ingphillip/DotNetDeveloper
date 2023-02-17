using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Open_Close
{
    public class DetalleInventarioReporte : IReport
    {
        IInventario _inventario;
        public DetalleInventarioReporte(IInventario inventario)
        {
            _inventario = inventario;
        }

        public void GenerarReporte()
        {
            foreach (var item in _inventario.Items)
            {
                Console.WriteLine($"ID: {item.ID} - Nombre: {item.Nombre} - Cantidad: {item.Cantidad} - Fecha: {item.FechaCreacion}");
            }
        }
    }
}
