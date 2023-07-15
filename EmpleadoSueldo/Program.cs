using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSueldo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre");
                empleado.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                empleado.apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo");
                empleado.sueldoDiario = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los dias trabajados");
                empleado.DiasTrabajados = int.Parse(Console.ReadLine());
                float total = empleado.CalcularSueldo();
                Console.WriteLine("El sueldo del empleado es: " + total);

            }
            Console.ReadKey();
            
        }
    }
}
