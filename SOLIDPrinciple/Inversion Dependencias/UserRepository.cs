using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Inversion_Dependencias
{
    public class UserRepository
    {
        private readonly IDatabase _db;
        public UserRepository(IDatabase database)
        {
            _db= database;
        }

        public List<string> GetUsersNames()
        {
            // todo lo correspondiente al acceso a Datos
            Console.WriteLine($"Estado BD: {_db != null}");
            //TODO: Obtener nombres de BD
            return new List<string>();
        }
    }
}
