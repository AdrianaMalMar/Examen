using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            Console.WriteLine("Ingrese el numero ");
            factorial.Numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= factorial.Numero; i++)
            {
                int total = factorial.Numero * (factorial.Numero-1);
                Console.WriteLine("El factorial es: " + total);
            }

            Console.ReadKey();

        }
    }
}
