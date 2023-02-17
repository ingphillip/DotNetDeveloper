using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Open_Close
{
    public class InventarioDetallado : IInventario
    {
        public List<Item> Items { get; set; }


        public InventarioDetallado(List<Item> items)
        {
            this.Items = items;
        }

        public void AgregarItem(Item item)
        {
            this.Items.Add(item);
        }

        public void EliminarItem(Item item)
        {
            var itemActual = Items.FirstOrDefault(x => x.ID == item.ID);
            if (itemActual != null)
            {
                this.Items.Remove(itemActual);
            }
        }
    }
}
