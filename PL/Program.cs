using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            int result1 = 0;
            int result2 = 0;

            Console.WriteLine("Bienvenido a la calculadora que solo resta");
            Console.WriteLine("Ingresa el primer número");
            result1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número");
            result2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado es igual a " + (result1 - result2));
        }
    }
}
