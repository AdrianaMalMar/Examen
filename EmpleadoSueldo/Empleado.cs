using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSueldo
{
    public class Empleado
    {
        public int DiasTrabajados { get; set; }

        public string nombre;
        public string apellido;
        public float sueldoDiario;

        public float CalcularSueldo()
        {
            return sueldoDiario * DiasTrabajados;
        }
    }
}
