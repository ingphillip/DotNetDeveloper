using SOLIDPrinciple.Open_Close;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Liskov_Sub
{
    public class InventarioElectronicos : Inventario
    {
        public void AddItem(ItemElectronico item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItemElectronico item)
        {
            Items.Remove(item);
        }
    }
}
