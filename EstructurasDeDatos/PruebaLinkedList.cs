using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public class PruebaLinkedList
    {
        public void Prueba()
        {
            LinkedList<char> abecedario = new LinkedList<char>();

            abecedario.AddLast('a');
            abecedario.AddLast('b');
            abecedario.AddLast('c');
            abecedario.AddLast('d');
            abecedario.AddLast('e');
            abecedario.AddLast('f');

            //abecedario.Remove(abecedario.First);

            //foreach (var item in abecedario)
            //{
            //    Console.WriteLine(item);
            //}

            for(LinkedListNode<char> nodo = abecedario.First; nodo!= null;nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value);
            }

            Console.ReadLine();
        }
    }
}
