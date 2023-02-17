using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Open_Close
{
    public class ConsultasInventario
    {
        IInventario _inventario;
        public ConsultasInventario(IInventario inventario) { 
            _inventario = inventario;
        }

        public List<Item> ConsultarItems()
        {
            return _inventario.Items;
        }
    }
}
