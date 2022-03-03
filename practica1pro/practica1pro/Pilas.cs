using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1pro
{
    class Pilas
    {
        public static void Main()
        {
            Stack<string> urls = new Stack<string>();
            urls.Push("Karen");
            urls.Push("Carla");
            urls.Push("Kenia");
            urls.Push("Mauricio");
            urls.Push("Esteban");
            urls.Push("Alex");


            foreach (string url in urls)
            {
                Console.WriteLine(url);
            }

            Console.WriteLine("\nPopping/ Eliminando '{0}'", urls.Pop());
            Console.WriteLine("Peek/viendo en el siguiente item a desapilar: {0}",
                urls.Peek());
            Console.WriteLine("Popping/ Eliminando '{0}'", urls.Pop());


           Stack<string> stack2 = new Stack<string>(urls.ToArray());

            Console.WriteLine("\nContenido de la primer copia:");
            foreach (string url in stack2)
            {
                Console.WriteLine(url);
            }

            string[] array2 = new string[urls.Count * 2];
            urls.CopyTo(array2, urls.Count);


            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContenido de la segunda copia, con duplicados y nulos:");
            foreach (string url in stack3)
            {
                Console.WriteLine(url);
            }
            Console.WriteLine("\nVerificando si contiene la pila2 el elemento Humberto");
            Console.WriteLine("\nstack2.Contains/ la pila2 contiene (\"www.upes.edu.sv\") = {0}",
                stack2.Contains("Humberto"));
            Console.WriteLine("\nLimpiando la pila2");
            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);

        }
    }
