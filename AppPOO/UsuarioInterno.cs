using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOO
{

    public enum TipoUsuario
    {
        Admin = 1,
        Ejecutivo = 2,
        Cajero = 3,
        Base = 4
    }
    public class UsuarioInterno : Persona
    {
        public TipoUsuario TipoUsuario { get; set; }
        public UsuarioInterno() {
            TipoUsuario = TipoUsuario.Base;
        }
    }
}
