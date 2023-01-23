
namespace EstructurasDeDatos
{
    public class PruebaList
    {
        public void PruebaLista()
        {
            List<int> numerosPares = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                    {
                        numerosPares.Add(i);
                    }
                }
            }

            Console.WriteLine($"La cantidad de datos de la lista numerosPares es: {numerosPares.Count}");

            numerosPares.Insert(0, 1000);

            foreach (var item in numerosPares)
            {
                Console.WriteLine(item);
            }

            List<Persona> personas = new List<Persona>
            {
                new Persona{ Id = 1, Nombre = "Felipe"},
                new Persona{Id=2, Nombre = "Carlos"}
            };

            personas.AddRange(new List<Persona>
            {
                new Persona { Id=3, Nombre="Francisco"},
                new Persona { Id=4, Nombre="Pedro"}
            });

            foreach (var item in personas)
            {
                Console.WriteLine($"Id: {item.Id} Nombre: {item.Nombre}");
            }

            personas.Remove(personas[0]);

            Console.WriteLine("Datos luego de eliminar la primer Persona:");

            foreach (var item in personas)
            {
                Console.WriteLine($"Id: {item.Id} Nombre: {item.Nombre}");
            }

            Console.ReadLine();
        }
    }
}

public class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; }
}
