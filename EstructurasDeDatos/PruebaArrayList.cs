using System.Collections;

namespace EstructurasDeDatos
{
    public class PruebaArrayList
    {
        public void ejecutarPruebaArrayList()
        {

            ArrayList names = new ArrayList(3);

            names.Add("Pedro");
            names.Add("Jaime");
            names.Add("Facundo");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            names.Add("Jairo");

            Console.WriteLine(names[3]);

            ArrayList lastNames = new ArrayList()
            {
                "Rodriguez",
                "Paez",
                "Sotelo"
            };

            foreach (var item in lastNames)
            {
                Console.WriteLine(item);
            }

            ArrayList objects = new ArrayList()
            {
                1,
                "Jorge",
                'i',
                0.9
            };

            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }

            objects.AddRange(new ArrayList() {
                "Colombia",
                "Perú",
                "Argentina"
            });

            for (int i = 4; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }

            objects.Remove("Colombia");

            objects.RemoveAt(4);

            Console.WriteLine("Los elementos del arrayList objects después de eliminar Colombia son:");

            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }

            Console.ReadLine();
        }
    }
}
