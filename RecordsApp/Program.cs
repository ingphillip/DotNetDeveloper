
using RecordsApp;

Persona persona = new("Juan", "Perez", 35);

Persona personaEditado = persona with { Nombre = "Pedro" };

Empleado empleado = new("Fabian", "Peña", 25, "Arquitecto");

Console.WriteLine(empleado);

Persona personaOrigen = empleado;

Console.WriteLine($"Hola {personaOrigen.Nombre} {personaOrigen.Apellido}, su edad es {personaOrigen.Edad} años");

Console.WriteLine(personaEditado);

Console.WriteLine(persona);

Console.Read();