using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Inversion_Dependencias
{
    internal class OracleDB : IDatabase
    {
        public void Diconnect()
        {
            Console.WriteLine("DB desconectada");
        }

        public void OpenConnection()
        {
            Console.WriteLine("DB conectada");
        }
    }
}
