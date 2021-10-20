using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Empleado
    {

        public int IDEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public double SalarioEmpleado { get; set; }

        public void SetValores(int ID)
        {
            IDEmpleado = ID;
        }

    }
}
