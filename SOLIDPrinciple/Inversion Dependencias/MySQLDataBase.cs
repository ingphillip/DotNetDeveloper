using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Inversion_Dependencias
{
    public class MySQLDataBase : IDatabase
    {
        public void Diconnect()
        {

            Console.WriteLine("Desconectar BD"); 
        }

        public void OpenConnection()
        {
            Console.WriteLine("Conectar BD");
        }
    }
}
