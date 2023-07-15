using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoresEdad
{
    public class SolicitarEdades
    {
        public int[] Edad;
        public void Edades()
        {
            Edad = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese Edad: ");
                Edad[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < Edad.Length; i++)
            {
                if (Edad[i] >= 18)
                {
                    Console.WriteLine("Los mayores de edad son: " + Edad[i]);

                }
                else
                {
                    Console.WriteLine("Menores de edad son:" + Edad[i]);
                }
            }
            
        }
    }
}
