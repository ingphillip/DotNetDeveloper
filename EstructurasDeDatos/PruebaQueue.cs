using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public class PruebaQueue
    {
        public void Prueba()
        {
            List<int> numeros = new List<int>();

            /*Queue objetos = new Queue();
            objetos.Enqueue(1);
            objetos.Enqueue('a');
            objetos.Enqueue(true);
            objetos.Enqueue(numeros);

            foreach (var item in objetos)
            {
                Console.WriteLine(item);
            }*/

            Queue<string> nombres = new Queue<string>();

            nombres.Enqueue("Jairo");
            nombres.Enqueue("Hernando");
            nombres.Enqueue("Antonio");
            nombres.Enqueue("Fabio");
            nombres.Enqueue("Pedro");

            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            nombres.Dequeue();
            nombres.Dequeue();
            Console.WriteLine("Los usuarios en cola son:");

            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            nombres.Clear();
            Console.WriteLine("Los usuarios pendientes son:");
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
