using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoresEdad
{
    public class Program
    {
        static void Main(string[] args)
        {
            SolicitarEdades edades = new SolicitarEdades();
            edades.Edades();

            Console.ReadKey();
        }
    }
}
