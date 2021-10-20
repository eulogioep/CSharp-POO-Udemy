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
        public string Nombre { get; set; }
        public double SalarioEmpleado { get; set; }

        public void SetValores(int ID)
        {
            IDEmpleado = ID;
        }

        public void SetValores(int ID, string NombreEmpleado)
        {
            IDEmpleado = ID;
            Nombre = NombreEmpleado;
        }

        public void SetValores(int ID, string NombreEmpleado, double Salario)
        {
            IDEmpleado = ID;
            Nombre = NombreEmpleado;
            SalarioEmpleado = Salario;
        }

    }
}
