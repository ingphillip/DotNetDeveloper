using SOLIDPrinciple.Liskov_Sub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Sigle_Responsability
{
    internal class LiskovImp
    {
        static void Liskov()
        {
            Inventario inventario = new Inventario();
            ManejadorInventarios ManejadorInventarios = new ManejadorInventarios(inventario);

            ManejadorInventarios.AddItem(new ItemSimple() { });

            InventarioSimple inventarioSimple = new InventarioSimple();
            ManejadorInventarios = new ManejadorInventarios(inventarioSimple);

            ManejadorInventarios.AddItem(new ItemSimple() { });

            InventarioElectronicos inventarioElectronicos = new InventarioElectronicos();
            ManejadorInventarios = new ManejadorInventarios(inventarioElectronicos);

            ManejadorInventarios.AddItem(new ItemElectronico() { });
        }
    }
}
