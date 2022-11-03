using AppPOO;
using System.Reflection.Metadata;

Persona persona1 = new Persona();
persona1.Nombre = "Gustavo";
persona1.Apellido = "Ramirez";
persona1.Edad = 34;
persona1.EsActivo = true;

Console.WriteLine("Hola");
Console.WriteLine(persona1.Nombre);
Console.WriteLine("Tu edad es:");
Console.WriteLine(persona1.Edad);

Cliente Cliente1 = new Cliente
{
    Id = 1,
    Nombre = "Alfonso",
    Apellido = "Medina",
    Edad = 30
};

CuentaAhorro cuenta1 = new CuentaAhorro()
{
    Id = 1,
    Name = "Cuenta Ahorros para la vejez",
    ClienteCuenta = Cliente1,
    FechaCreacion = DateTime.Now
};

Console.WriteLine($"Hola {cuenta1.ClienteCuenta.Nombre}! Tu tienes {cuenta1.ClienteCuenta.Edad} años de edad. Tu cuenta principal se llama {cuenta1.Name}, esta cuenta fue creada {cuenta1.FechaCreacion}");

Cliente1.Activar();

Console.WriteLine($"El Cliente {Cliente1.Nombre} con id {Cliente1.Id}, está {(Cliente1.ObtenerEstadoActivo() ? "Activo" : "Inactivo")}");

UsuarioInterno UsuarioInterno1 = new UsuarioInterno();
UsuarioInterno1.Id = 5;
UsuarioInterno1.Nombre = "Gonzalo";
UsuarioInterno1.Apellido = "Rojas";
UsuarioInterno1.Edad = 25;


Console.WriteLine($"Hola {UsuarioInterno1.Nombre}!\nTu tienes {UsuarioInterno1.Edad} años de edad.\nTu eres un usuario interno tu estado es {(UsuarioInterno1.ObtenerEstadoActivo() ? "Activo" : "Inactivo")}.\n Eres un usuario {(UsuarioInterno1.TipoUsuario == TipoUsuario.Base ? "el cual requiere ser configurado en el sistema": "Registrado en nuestra plataforma")}");

UsuarioInterno1.Activar();
UsuarioInterno1.TipoUsuario =  TipoUsuario.Ejecutivo;

Console.WriteLine($"Hola {UsuarioInterno1.Nombre}!\nTu tienes {UsuarioInterno1.Edad} años de edad.\nTu eres un usuario interno tu estado es {(UsuarioInterno1.ObtenerEstadoActivo() ? "Activo" : "Inactivo")}.\n Eres un usuario {(UsuarioInterno1.TipoUsuario == TipoUsuario.Base ? "el cual requiere ser configurado en el sistema" : "Registrado en nuestra plataforma")}");


CuentaAhorro cuentaAhorro1 = new CuentaAhorro();
cuentaAhorro1.Name = "Mi primer cuenta de ahorro";
cuentaAhorro1.Monto = 1000;

Console.WriteLine($"Tu cuenta se llama {cuentaAhorro1.Name} y tu monto es {cuentaAhorro1.CalcularMonto()}");

CuentaCorriente CuentaCorriente1 = new CuentaCorriente();
CuentaCorriente1.Name = "Mi primer cuenta corriente";
CuentaCorriente1.Monto = 1500;

Console.WriteLine($"Tu cuenta se llama {CuentaCorriente1.Name} y tu monto es {CuentaCorriente1.CalcularMonto()}");

Console.Read();