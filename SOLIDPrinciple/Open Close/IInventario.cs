using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Open_Close
{
    public interface IInventario
    {
        List<Item> Items { get; set; }
        void AgregarItem(Item item);
        void EliminarItem(Item item);
    }
}
