using SOLIDPrinciple.Open_Close;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Liskov_Sub
{
    public class ManejadorInventarios
    {
        Inventario _inventario;
        public ManejadorInventarios(Inventario inventario)
        {
            _inventario= inventario;
        }

        public void AddItem(Item item)
        {
            _inventario.Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _inventario.Items.Remove(item);
        }
    }
}
