using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Liskov_Sub
{
    public interface Item
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

    }
}
